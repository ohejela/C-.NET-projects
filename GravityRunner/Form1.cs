// ================================================================
//  Form1.cs  -  GRAVITY RUNNER  (v4 - balanced difficulty + dash)
// ================================================================

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace GravityRunner
{
    public partial class Form1 : Form
    {
        static class GC
        {
            public const int W = 900;
            public const int H = 500;
            public const int GROUND_Y = 380;
            public const float GRAVITY = 0.6f;
            public const float JUMP_VEL = -14f;
            public const float SCROLL_SPD_START = 4f;
            public const float SCROLL_ACCEL = 0.0012f;
            public const int PLAYER_X = 100;
            public const int SPRITE_W = 48;
            public const int SPRITE_H = 64;
            public const int FRAME_DELAY = 16;
            public const int ANIM_FRAMES = 6;
            public const float DASH_VEL = 10f;
            public const int DASH_DURATION = 12;
            public const int DASH_COOLDOWN = 45;
            public const float MIN_GAP_EASY = 420f;
            public const float MIN_GAP_MED = 320f;
            public const float MIN_GAP_HARD = 220f;
        }

        enum HazardKind { Spike, Block, LowBar }

        class Hazard
        {
            public float X;
            public HazardKind Kind;

            public Rectangle GetRect()
            {
                switch (Kind)
                {
                    case HazardKind.Spike: return new Rectangle((int)X, GC.GROUND_Y - 36, 32, 36);
                    case HazardKind.Block: return new Rectangle((int)X, GC.GROUND_Y - 44, 44, 44);
                    case HazardKind.LowBar: return new Rectangle((int)X, GC.GROUND_Y - 60, 80, 16);
                    default: return Rectangle.Empty;
                }
            }

            public void Draw(Graphics g)
            {
                Rectangle r = GetRect();
                switch (Kind)
                {
                    case HazardKind.Spike: DrawSpike(g, r); break;
                    case HazardKind.Block: DrawBlock(g, r); break;
                    case HazardKind.LowBar: DrawLowBar(g, r); break;
                }
            }

            static void DrawSpike(Graphics g, Rectangle r)
            {
                using (var brush = new SolidBrush(Color.FromArgb(200, 50, 50)))
                {
                    int sw = r.Width / 3;
                    for (int i = 0; i < 3; i++)
                    {
                        int bx = r.X + i * sw;
                        Point[] tri = { new Point(bx, r.Bottom), new Point(bx + sw / 2, r.Top), new Point(bx + sw, r.Bottom) };
                        g.FillPolygon(brush, tri);
                        g.DrawPolygon(Pens.DarkRed, tri);
                    }
                }
            }

            static void DrawBlock(Graphics g, Rectangle r)
            {
                using (var brush = new LinearGradientBrush(r, Color.FromArgb(80, 130, 80), Color.FromArgb(30, 80, 30), LinearGradientMode.Vertical))
                    g.FillRectangle(brush, r);
                g.DrawRectangle(new Pen(Color.DarkGreen, 2), r);
                g.DrawLine(new Pen(Color.FromArgb(150, 255, 150), 1), r.Left + 2, r.Top + 2, r.Right - 2, r.Top + 2);
            }

            static void DrawLowBar(Graphics g, Rectangle r)
            {
                using (var brush = new LinearGradientBrush(r, Color.FromArgb(200, 160, 40), Color.FromArgb(140, 100, 10), LinearGradientMode.Vertical))
                    g.FillRectangle(brush, r);
                g.DrawRectangle(new Pen(Color.Goldenrod, 2), r);
                using (var pen = new Pen(Color.FromArgb(120, Color.Black), 2)) { pen.DashStyle = DashStyle.Dash; g.DrawLine(pen, r.Left, r.Top + r.Height / 2, r.Right, r.Top + r.Height / 2); }
                g.FillRectangle(Brushes.DimGray, r.Left, r.Bottom, 8, 20);
                g.FillRectangle(Brushes.DimGray, r.Right - 8, r.Bottom, 8, 20);
            }
        }

        class BgLayer
        {
            readonly Color _color;
            readonly float _parallax;
            readonly List<RectF> _items = new List<RectF>();
            float _scroll;
            struct RectF { public float x; public int y, w, h; }

            public BgLayer(Color c, int count, int yMin, int yMax, int wMin, int wMax, int hMin, int hMax, float parallax)
            {
                _color = c; _parallax = parallax;
                var rng = new Random(count * 17);
                for (int i = 0; i < count; i++)
                    _items.Add(new RectF { x = (float)(rng.NextDouble() * GC.W), y = rng.Next(yMin, yMax), w = rng.Next(wMin, wMax), h = rng.Next(hMin, hMax) });
            }

            public void Update(float speed) { _scroll += speed * _parallax; if (_scroll > GC.W) _scroll -= GC.W; }

            public void Draw(Graphics g)
            {
                using (var brush = new SolidBrush(_color))
                    foreach (var item in _items)
                    {
                        float rx = ((item.x - _scroll) % GC.W + GC.W) % GC.W;
                        g.FillRectangle(brush, rx, item.y, item.w, item.h);
                        if (rx + item.w > GC.W) g.FillRectangle(brush, rx - GC.W, item.y, item.w, item.h);
                    }
            }
        }

        class Particle
        {
            public float X, Y, Vx, Vy;
            public int Life, MaxLife, Size;
            public Color Col;
            public void Tick() { X += Vx; Y += Vy; Vy += 0.3f; Life--; }
            public void Draw(Graphics g)
            {
                float a = (float)Life / MaxLife;
                using (var b = new SolidBrush(Color.FromArgb((int)(255 * a), Col)))
                    g.FillEllipse(b, X, Y, Size, Size);
            }
        }

        // =========================================================
        //  FIELDS
        // =========================================================

        enum GameState { Title, Playing, Dead, Paused }
        GameState _state = GameState.Title;

        float _playerY, _velY;
        bool _onGround, _doubleJumpUsed, _jumpHeld;
        int _animTick, _runFrame;

        // Dash state
        bool _dashHeld;
        int _dashFrames;
        int _dashCooldown;

        float _scrollSpeed;
        int _score, _hiScore, _frameCount;
        float _spawnTimer, _groundScroll;

        readonly List<Hazard> _hazards = new List<Hazard>();
        readonly List<Particle> _particles = new List<Particle>();

        BgLayer _bgCity, _bgMid, _bgNear;
        Bitmap _sprRun1, _sprRun2, _sprJump, _sprDead;
        Bitmap _buffer;
        Graphics _bufG;

        readonly System.Windows.Forms.Timer _gameTimer = new System.Windows.Forms.Timer();
        readonly Random _rng = new Random();

        static readonly Point[] _starPts;
        static Form1()
        {
            var rng = new Random(42);
            _starPts = new Point[120];
            for (int i = 0; i < _starPts.Length; i++)
                _starPts[i] = new Point(rng.Next(GC.W), rng.Next(GC.GROUND_Y - 40));
        }

        // =========================================================
        //  CONSTRUCTOR
        // =========================================================
        public Form1()
        {
            InitializeComponent();

            typeof(Panel).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                ?.SetValue(pnlCanvas, true);

            _buffer = new Bitmap(GC.W, GC.H);
            _bufG = Graphics.FromImage(_buffer);
            _bufG.SmoothingMode = SmoothingMode.AntiAlias;

            LoadSprites();
            picSpritePreview.Image = _sprRun1;

            _bgCity = new BgLayer(Color.FromArgb(40, 50, 80), 12, 120, 280, 20, 60, 40, 100, 0.15f);
            _bgMid = new BgLayer(Color.FromArgb(30, 40, 70), 8, 200, 320, 30, 80, 30, 80, 0.30f);
            _bgNear = new BgLayer(Color.FromArgb(20, 30, 55), 6, 280, 360, 10, 30, 20, 60, 0.60f);

            _gameTimer.Interval = GC.FRAME_DELAY;
            _gameTimer.Tick += OnGameTick;
            _gameTimer.Start();

            pnlCanvas.Focus();
            pnlCanvas.MouseClick += (s, e) => pnlCanvas.Focus();
            ShowTitleOverlay();
        }

        // =========================================================
        //  SPRITES
        // =========================================================
        void LoadSprites()
        {
            _sprRun1 = TryLoadSprite("player_run1.png") ?? BuildFallbackSprite(false, false);
            _sprRun2 = TryLoadSprite("player_run2.png") ?? BuildFallbackSprite(false, false);
            _sprJump = TryLoadSprite("player_jump.png") ?? BuildFallbackSprite(true, false);
            _sprDead = TryLoadSprite("player_dead.png") ?? BuildFallbackSprite(false, true);
            MakeTransparent(_sprRun1); MakeTransparent(_sprRun2);
            MakeTransparent(_sprJump); MakeTransparent(_sprDead);
        }

        static Bitmap TryLoadSprite(string name)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, name);
            return File.Exists(path) ? new Bitmap(path) : null;
        }

        static void MakeTransparent(Bitmap bmp)
        {
            bmp.MakeTransparent(Color.White);
            for (int y = 0; y < bmp.Height; y++)
                for (int x = 0; x < bmp.Width; x++)
                { Color px = bmp.GetPixel(x, y); if (px.A > 0 && px.R > 230 && px.G > 230 && px.B > 230) bmp.SetPixel(x, y, Color.Transparent); }
        }

        static Bitmap BuildFallbackSprite(bool jumping, bool dead)
        {
            var bmp = new Bitmap(GC.SPRITE_W, GC.SPRITE_H);
            using (var g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White); g.SmoothingMode = SmoothingMode.AntiAlias;
                var bodyColor = Color.FromArgb(30, 144, 255);
                var darkBlue = Color.FromArgb(10, 80, 160);
                var skin = Color.FromArgb(255, 205, 160);
                var helm = Color.FromArgb(20, 100, 200);
                var visor = Color.FromArgb(100, 200, 255);
                var stripe = Color.FromArgb(255, 220, 0);
                var boot = Color.FromArgb(40, 40, 40);
                if (dead)
                {
                    g.FillRectangle(new SolidBrush(bodyColor), 4, 34, 36, 14);
                    g.FillRectangle(new SolidBrush(stripe), 10, 35, 16, 12);
                    g.FillRectangle(new SolidBrush(darkBlue), 34, 28, 12, 12);
                    g.FillRectangle(new SolidBrush(boot), 34, 36, 12, 8);
                    g.FillEllipse(new SolidBrush(helm), 0, 26, 18, 20);
                    g.FillEllipse(new SolidBrush(visor), 2, 28, 14, 16);
                    g.FillEllipse(new SolidBrush(skin), 4, 30, 10, 12);
                    g.DrawLine(new Pen(Color.Red, 2), 5, 32, 9, 36); g.DrawLine(new Pen(Color.Red, 2), 9, 32, 5, 36);
                }
                else if (jumping)
                {
                    g.FillRectangle(new SolidBrush(boot), 8, 50, 12, 10);
                    g.FillRectangle(new SolidBrush(boot), 26, 50, 12, 10);
                    g.FillRectangle(new SolidBrush(darkBlue), 8, 38, 12, 14);
                    g.FillRectangle(new SolidBrush(darkBlue), 26, 38, 12, 14);
                    g.FillRectangle(new SolidBrush(bodyColor), 8, 20, 32, 20);
                    g.FillRectangle(new SolidBrush(stripe), 16, 22, 14, 16);
                    g.FillRectangle(new SolidBrush(bodyColor), 1, 10, 8, 12);
                    g.FillRectangle(new SolidBrush(bodyColor), 38, 10, 8, 12);
                    g.FillEllipse(new SolidBrush(skin), 0, 4, 10, 10);
                    g.FillEllipse(new SolidBrush(skin), 38, 4, 10, 10);
                    g.FillRectangle(new SolidBrush(skin), 19, 14, 10, 8);
                    g.FillEllipse(new SolidBrush(helm), 10, 2, 28, 20);
                    g.FillEllipse(new SolidBrush(visor), 14, 5, 20, 14);
                    g.FillEllipse(new SolidBrush(skin), 16, 7, 14, 10);
                    g.FillEllipse(Brushes.Black, 18, 9, 4, 4); g.FillEllipse(Brushes.Black, 25, 9, 4, 4);
                }
                else
                {
                    g.FillRectangle(new SolidBrush(boot), 10, 54, 12, 10);
                    g.FillRectangle(new SolidBrush(boot), 26, 54, 12, 10);
                    g.FillRectangle(new SolidBrush(darkBlue), 10, 42, 12, 14);
                    g.FillRectangle(new SolidBrush(darkBlue), 26, 42, 12, 14);
                    g.FillRectangle(new SolidBrush(bodyColor), 8, 22, 32, 22);
                    g.FillRectangle(new SolidBrush(stripe), 16, 24, 14, 18);
                    g.FillRectangle(new SolidBrush(bodyColor), 2, 22, 8, 18);
                    g.FillRectangle(new SolidBrush(bodyColor), 38, 22, 8, 18);
                    g.FillEllipse(new SolidBrush(skin), 2, 38, 10, 10);
                    g.FillEllipse(new SolidBrush(skin), 36, 38, 10, 10);
                    g.FillRectangle(new SolidBrush(skin), 19, 16, 10, 8);
                    g.FillEllipse(new SolidBrush(helm), 10, 2, 28, 22);
                    g.FillEllipse(new SolidBrush(visor), 14, 6, 20, 14);
                    g.FillEllipse(new SolidBrush(skin), 16, 8, 14, 10);
                    g.FillEllipse(Brushes.Black, 18, 10, 4, 4); g.FillEllipse(Brushes.Black, 25, 10, 4, 4);
                }
            }
            return bmp;
        }

        // =========================================================
        //  OVERLAYS
        // =========================================================
        void ShowTitleOverlay() { pnlTitle.Visible = true; pnlGameOver.Visible = false; pnlPaused.Visible = false; btnPause.Enabled = false; }
        void ShowGameOverOverlay() { lblFinalScore.Text = string.Format("Score: {0:D6}", _score); lblFinalBest.Text = string.Format("Best:  {0:D6}", _hiScore); pnlTitle.Visible = false; pnlGameOver.Visible = true; pnlPaused.Visible = false; btnPause.Enabled = false; }
        void ShowPausedOverlay() { pnlTitle.Visible = false; pnlGameOver.Visible = false; pnlPaused.Visible = true; }
        void HideAllOverlays() { pnlTitle.Visible = false; pnlGameOver.Visible = false; pnlPaused.Visible = false; btnPause.Enabled = true; }

        // =========================================================
        //  START / RESET
        // =========================================================
        void StartGame()
        {
            _playerY = GC.GROUND_Y - GC.SPRITE_H; _velY = 0f; _onGround = true;
            _doubleJumpUsed = false; _jumpHeld = false; _dashHeld = false;
            _dashFrames = 0; _dashCooldown = 0;
            _animTick = 0; _runFrame = 0;
            _scrollSpeed = GC.SCROLL_SPD_START; _score = 0; _frameCount = 0;
            _spawnTimer = 0f; _groundScroll = 0f;
            _hazards.Clear(); _particles.Clear();
            _state = GameState.Playing;
            HideAllOverlays();
            RefreshHUD();
            btnPause.Text = "Pause";
            pnlCanvas.Focus();
        }

        // =========================================================
        //  BUTTON HANDLERS
        // =========================================================
        private void BtnStartGame_Click(object sender, EventArgs e) => StartGame();
        private void BtnRetry_Click(object sender, EventArgs e) => StartGame();

        private void BtnJump_Click(object sender, EventArgs e)
        {
            TryJump();
            pnlCanvas.Focus();
        }

        private void BtnDash_Click(object sender, EventArgs e)
        {
            TryDash();
            pnlCanvas.Focus();
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            if (_state == GameState.Playing)
            {
                _state = GameState.Paused;
                ShowPausedOverlay();
                btnPause.Text = "Resume";
            }
            else if (_state == GameState.Paused)
            {
                _state = GameState.Playing;
                HideAllOverlays();
                btnPause.Text = "Pause";
                pnlCanvas.Focus();
            }
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            if (_state != GameState.Title) StartGame();
        }

        private void BtnResume_Click(object sender, EventArgs e)
        {
            if (_state == GameState.Paused)
            {
                _state = GameState.Playing;
                HideAllOverlays();
                btnPause.Text = "Pause";
                pnlCanvas.Focus();
            }
        }

        // =========================================================
        //  KEYBOARD
        // =========================================================
        private void PnlCanvas_KeyDown(object sender, KeyEventArgs e)
        {
            bool jumpKey = e.KeyCode == Keys.Space || e.KeyCode == Keys.Up || e.KeyCode == Keys.W;
            bool dashKey = e.KeyCode == Keys.Right || e.KeyCode == Keys.D;

            if (jumpKey)
            {
                _jumpHeld = true;
                if (_state == GameState.Title) { StartGame(); return; }
                if (_state == GameState.Dead) { StartGame(); return; }
                if (_state == GameState.Paused) { _state = GameState.Playing; HideAllOverlays(); btnPause.Text = "Pause"; return; }
                TryJump();
            }
            if (dashKey) { _dashHeld = true; if (_state == GameState.Playing) TryDash(); }
            if (e.KeyCode == Keys.P)
            {
                if (_state == GameState.Playing) { _state = GameState.Paused; ShowPausedOverlay(); btnPause.Text = "Resume"; }
                else if (_state == GameState.Paused) { _state = GameState.Playing; HideAllOverlays(); btnPause.Text = "Pause"; }
            }
            if (e.KeyCode == Keys.Escape) { _state = GameState.Title; ShowTitleOverlay(); btnPause.Text = "Pause"; }
        }

        private void PnlCanvas_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Up || e.KeyCode == Keys.W) _jumpHeld = false;
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) _dashHeld = false;
        }

        void TryJump()
        {
            if (_state != GameState.Playing) return;
            if (_onGround) { _velY = GC.JUMP_VEL; _onGround = false; _doubleJumpUsed = false; SpawnJumpParticles(); }
            else if (!_doubleJumpUsed) { _velY = GC.JUMP_VEL * 0.9f; _doubleJumpUsed = true; SpawnJumpParticles(); }
        }

        void TryDash()
        {
            if (_state != GameState.Playing) return;
            if (_onGround) return;
            if (_dashCooldown > 0) return;
            if (_dashFrames > 0) return;
            _dashFrames = GC.DASH_DURATION;
            _dashCooldown = GC.DASH_COOLDOWN;
            SpawnDashParticles();
        }

        // =========================================================
        //  GAME LOOP
        // =========================================================
        void OnGameTick(object sender, EventArgs e)
        {
            if (_state == GameState.Playing) GameUpdate();
            pnlCanvas.Invalidate();
        }

        void GameUpdate()
        {
            _frameCount++;
            _scrollSpeed = GC.SCROLL_SPD_START + _frameCount * GC.SCROLL_ACCEL;
            _score = _frameCount / 6;
            if (_score > _hiScore) _hiScore = _score;

            if (_dashFrames > 0) _dashFrames--;
            if (_dashCooldown > 0) _dashCooldown--;

            // Physics
            float grav = (_jumpHeld && _velY < 0f) ? GC.GRAVITY * 0.7f : GC.GRAVITY;
            _velY += grav;
            _playerY += _velY;
            float groundTop = GC.GROUND_Y - GC.SPRITE_H;
            if (_playerY >= groundTop) { _playerY = groundTop; _velY = 0f; _onGround = true; }
            else _onGround = false;

            // Run animation
            if (_onGround) { _animTick++; int period = Math.Max(2, (int)(GC.ANIM_FRAMES - _scrollSpeed * 0.3f)); if (_animTick >= period) { _animTick = 0; _runFrame ^= 1; } }

            float effectiveScroll = _scrollSpeed + (_dashFrames > 0 ? GC.DASH_VEL : 0f);
            _groundScroll = (_groundScroll + effectiveScroll) % 40f;
            _bgCity.Update(effectiveScroll); _bgMid.Update(effectiveScroll); _bgNear.Update(effectiveScroll);

            // Move hazards
            for (int i = _hazards.Count - 1; i >= 0; i--)
            { _hazards[i].X -= effectiveScroll; if (_hazards[i].X < -120) _hazards.RemoveAt(i); }

            // Find rightmost hazard on screen
            float rightmostX = -999f;
            foreach (Hazard h in _hazards) if (h.X > rightmostX) rightmostX = h.X;

            // Score-based spawn gap
            float minGap;
            if (_score < 100) minGap = GC.MIN_GAP_EASY;
            else if (_score < 300) minGap = GC.MIN_GAP_MED;
            else minGap = GC.MIN_GAP_HARD;

            _spawnTimer += effectiveScroll;
            float baseInterval = Math.Max(minGap, 200f - _score * 0.2f);
            bool gapOk = (rightmostX < 0f) || (GC.W - rightmostX >= minGap);
            bool timerOk = _spawnTimer >= baseInterval;

            if (gapOk && timerOk)
            {
                _spawnTimer = 0f;
                int kindMax = _score < 50 ? 2 : 3;
                _hazards.Add(new Hazard { X = GC.W + 20, Kind = (HazardKind)_rng.Next(kindMax) });
            }

            // Collision - generous hitbox
            var pr = new Rectangle(GC.PLAYER_X + 8, (int)_playerY + 6, GC.SPRITE_W - 16, GC.SPRITE_H - 8);
            foreach (Hazard h in _hazards)
            {
                Rectangle hr = h.GetRect(); hr.Inflate(-6, -6);
                if (pr.IntersectsWith(hr)) { SpawnDeathParticles(); _state = GameState.Dead; ShowGameOverOverlay(); RefreshHUD(); return; }
            }

            // Particles
            for (int i = _particles.Count - 1; i >= 0; i--) { _particles[i].Tick(); if (_particles[i].Life <= 0) _particles.RemoveAt(i); }

            RefreshHUD();
        }

        // =========================================================
        //  HUD
        // =========================================================
        void RefreshHUD()
        {
            lblScore.Text = _score.ToString("D6");
            lblHiScore.Text = _hiScore.ToString("D6");
            float pct = Math.Min(1f, (_scrollSpeed - GC.SCROLL_SPD_START) / 15f);
            pbSpeed.Value = (int)(pct * 100f);

            bool djReady = !_doubleJumpUsed && !_onGround;
            lblDoubleJump.ForeColor = djReady ? Color.FromArgb(100, 200, 255) : Color.FromArgb(70, 70, 90);
            lblDoubleJump.Text = djReady ? "DBL JUMP READY" : "dbl jump used";

            if (_dashFrames > 0)
            { lblDash.ForeColor = Color.FromArgb(255, 200, 50); lblDash.Text = "DASHING!"; }
            else if (_dashCooldown > 0)
            { int p = 100 - (int)(_dashCooldown * 100f / GC.DASH_COOLDOWN); lblDash.ForeColor = Color.FromArgb(100, 100, 60); lblDash.Text = string.Format("dash {0}%", p); }
            else if (!_onGround)
            { lblDash.ForeColor = Color.FromArgb(80, 255, 140); lblDash.Text = "DASH READY"; }
            else
            { lblDash.ForeColor = Color.FromArgb(60, 80, 60); lblDash.Text = "dash (air only)"; }

            if (_state == GameState.Dead) picSpritePreview.Image = _sprDead;
            else if (!_onGround) picSpritePreview.Image = _sprJump;
            else picSpritePreview.Image = (_runFrame == 0) ? _sprRun1 : _sprRun2;
        }

        // =========================================================
        //  PARTICLES
        // =========================================================
        void SpawnDeathParticles()
        {
            Color[] cols = { Color.OrangeRed, Color.Yellow, Color.Orange, Color.White };
            for (int i = 0; i < 30; i++)
            {
                double a = _rng.NextDouble() * Math.PI * 2.0; float s = (float)(_rng.NextDouble() * 6.0 + 1.0);
                _particles.Add(new Particle { X = GC.PLAYER_X + GC.SPRITE_W / 2f, Y = _playerY + GC.SPRITE_H / 2f, Vx = (float)Math.Cos(a) * s, Vy = (float)Math.Sin(a) * s - 3f, Life = _rng.Next(20, 50), MaxLife = 50, Col = cols[_rng.Next(cols.Length)], Size = _rng.Next(4, 10) });
            }
        }

        void SpawnJumpParticles()
        {
            for (int i = 0; i < 8; i++)
                _particles.Add(new Particle { X = GC.PLAYER_X + 10 + _rng.Next(GC.SPRITE_W - 20), Y = _playerY + GC.SPRITE_H, Vx = (float)(_rng.NextDouble() * 4.0 - 2.0), Vy = (float)(_rng.NextDouble() * -2.0 - 1.0), Life = _rng.Next(8, 18), MaxLife = 18, Col = Color.FromArgb(100, 200, 255), Size = _rng.Next(3, 7) });
        }

        void SpawnDashParticles()
        {
            for (int i = 0; i < 14; i++)
                _particles.Add(new Particle { X = GC.PLAYER_X - _rng.Next(0, 30), Y = _playerY + 10 + _rng.Next(GC.SPRITE_H - 20), Vx = (float)(-_rng.NextDouble() * 5.0 - 2.0), Vy = (float)(_rng.NextDouble() * 2.0 - 1.0), Life = _rng.Next(6, 14), MaxLife = 14, Col = (_rng.Next(2) == 0) ? Color.Yellow : Color.Orange, Size = _rng.Next(4, 9) });
        }

        // =========================================================
        //  PAINT
        // =========================================================
        private void PnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            RenderToBuffer();
            e.Graphics.DrawImageUnscaled(_buffer, 0, 0);
        }

        void RenderToBuffer()
        {
            Graphics g = _bufG;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

            using (var sky = new LinearGradientBrush(new Rectangle(0, 0, GC.W, GC.GROUND_Y), Color.FromArgb(5, 5, 30), Color.FromArgb(20, 30, 70), LinearGradientMode.Vertical))
                g.FillRectangle(sky, 0, 0, GC.W, GC.GROUND_Y);

            foreach (Point p in _starPts) g.FillRectangle(Brushes.White, p.X, p.Y, 2, 2);
            g.FillEllipse(new SolidBrush(Color.FromArgb(220, 230, 200)), GC.W - 100, 30, 50, 50);
            g.FillEllipse(new SolidBrush(Color.FromArgb(5, 5, 30)), GC.W - 88, 22, 50, 50);

            _bgCity.Draw(g); _bgMid.Draw(g); _bgNear.Draw(g);

            using (var gnd = new LinearGradientBrush(new Rectangle(0, GC.GROUND_Y, GC.W, GC.H - GC.GROUND_Y), Color.FromArgb(20, 80, 20), Color.FromArgb(10, 40, 10), LinearGradientMode.Vertical))
                g.FillRectangle(gnd, 0, GC.GROUND_Y, GC.W, GC.H - GC.GROUND_Y);
            using (var ep = new Pen(Color.FromArgb(60, 180, 60), 3)) g.DrawLine(ep, 0, GC.GROUND_Y, GC.W, GC.GROUND_Y);
            using (var lp = new Pen(Color.FromArgb(40, 120, 40), 1))
                for (float x = -_groundScroll; x < GC.W; x += 40) g.DrawLine(lp, x, GC.GROUND_Y, x, GC.H);

            foreach (Particle p in _particles) p.Draw(g);
            foreach (Hazard h in _hazards) h.Draw(g);

            // Dash ghost effect
            if (_dashFrames > 0)
            {
                for (int ghost = 1; ghost <= 2; ghost++)
                {
                    float alpha = 80f / ghost;
                    using (var ia = new System.Drawing.Imaging.ImageAttributes())
                    {
                        float[][] mat = { new float[] { 1, 0, 0, 0, 0 }, new float[] { 0, 1, 0, 0, 0 }, new float[] { 0, 0, 1, 0, 0 }, new float[] { 0, 0, 0, alpha / 255f, 0 }, new float[] { 0, 0, 0, 0, 1 } };
                        ia.SetColorMatrix(new System.Drawing.Imaging.ColorMatrix(mat));
                        int gx = GC.PLAYER_X - ghost * 14;
                        g.DrawImage(_sprJump, new Rectangle(gx, (int)_playerY, GC.SPRITE_W, GC.SPRITE_H), 0, 0, GC.SPRITE_W, GC.SPRITE_H, GraphicsUnit.Pixel, ia);
                    }
                }
            }

            Bitmap spr = (_state == GameState.Dead) ? _sprDead : (!_onGround) ? _sprJump : (_runFrame == 0) ? _sprRun1 : _sprRun2;
            g.DrawImage(spr, GC.PLAYER_X, (int)_playerY, GC.SPRITE_W, GC.SPRITE_H);

            // Double-jump glow
            if (!_onGround && _doubleJumpUsed && _state == GameState.Playing)
                using (var gp = new Pen(Color.FromArgb(80, 100, 200, 255), 2))
                    g.DrawEllipse(gp, GC.PLAYER_X - 6, (int)_playerY + GC.SPRITE_H / 2 - 6, GC.SPRITE_W + 12, 20);

            // Dash ring
            if (_dashFrames > 0)
                using (var dp = new Pen(Color.FromArgb(180, 255, 200, 0), 3))
                    g.DrawEllipse(dp, GC.PLAYER_X - 8, (int)_playerY + 4, GC.SPRITE_W + 16, GC.SPRITE_H - 8);
        }

        // =========================================================
        //  CLEANUP
        // =========================================================
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _gameTimer.Stop();
            _bufG?.Dispose();
            _buffer?.Dispose();
            base.OnFormClosing(e);
        }
    }
}
