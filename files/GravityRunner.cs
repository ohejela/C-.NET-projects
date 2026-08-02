using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

// ============================================================
//  GRAVITY RUNNER  –  C# Windows Forms
//  Single-file source.  Drop the 4 sprite PNGs next to the EXE
//  (player_run1.png, player_run2.png, player_jump.png, player_dead.png)
//  or they will be procedurally painted at runtime as a fallback.
// ============================================================

namespace GravityRunner
{
    // ─────────────────────────────────────────────────────────
    //  Entry point
    // ─────────────────────────────────────────────────────────
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GameForm());
        }
    }

    // ─────────────────────────────────────────────────────────
    //  Constants
    // ─────────────────────────────────────────────────────────
    static class C
    {
        public const int W            = 900;
        public const int H            = 500;
        public const int GROUND_Y     = 380;        // top of ground strip
        public const float GRAVITY    = 0.6f;
        public const float JUMP_VEL   = -14f;
        public const float SCROLL_SPD_START = 5f;
        public const float SCROLL_ACCEL    = 0.002f; // speed increase per frame
        public const int PLAYER_X     = 100;
        public const int SPRITE_W     = 48;
        public const int SPRITE_H     = 64;
        public const int FRAME_DELAY  = 16;         // ~60 fps
        public const int ANIM_FRAMES  = 6;          // ticks per run frame flip
    }

    // ─────────────────────────────────────────────────────────
    //  Hazard types
    // ─────────────────────────────────────────────────────────
    enum HazardKind { Spike, Block, LowBar }

    // ─────────────────────────────────────────────────────────
    //  Hazard
    // ─────────────────────────────────────────────────────────
    class Hazard
    {
        public float X;
        public HazardKind Kind;

        // Hit-box relative to top-left of hazard rect
        public Rectangle GetRect()
        {
            switch (Kind)
            {
                case HazardKind.Spike:
                    return new Rectangle((int)X, C.GROUND_Y - 36, 32, 36);
                case HazardKind.Block:
                    return new Rectangle((int)X, C.GROUND_Y - 44, 44, 44);
                case HazardKind.LowBar:
                    return new Rectangle((int)X, C.GROUND_Y - 60, 80, 16);
                default:
                    return Rectangle.Empty;
            }
        }

        public void Draw(Graphics g)
        {
            Rectangle r = GetRect();
            switch (Kind)
            {
                case HazardKind.Spike:
                    DrawSpike(g, r);
                    break;
                case HazardKind.Block:
                    DrawBlock(g, r);
                    break;
                case HazardKind.LowBar:
                    DrawLowBar(g, r);
                    break;
            }
        }

        static void DrawSpike(Graphics g, Rectangle r)
        {
            using (var brush = new SolidBrush(Color.FromArgb(200, 50, 50)))
            {
                // 3 triangular spikes side by side
                int sw = r.Width / 3;
                for (int i = 0; i < 3; i++)
                {
                    int bx = r.X + i * sw;
                    Point[] tri =
                    {
                        new Point(bx,          r.Bottom),
                        new Point(bx + sw / 2, r.Top),
                        new Point(bx + sw,     r.Bottom)
                    };
                    g.FillPolygon(brush, tri);
                    g.DrawPolygon(Pens.DarkRed, tri);
                }
            }
        }

        static void DrawBlock(Graphics g, Rectangle r)
        {
            using (var brush = new LinearGradientBrush(r,
                Color.FromArgb(80, 130, 80), Color.FromArgb(30, 80, 30),
                LinearGradientMode.Vertical))
            {
                g.FillRectangle(brush, r);
            }
            g.DrawRectangle(new Pen(Color.DarkGreen, 2), r);
            // highlight
            g.DrawLine(new Pen(Color.FromArgb(150, 255, 150), 1),
                r.Left + 2, r.Top + 2, r.Right - 2, r.Top + 2);
        }

        static void DrawLowBar(Graphics g, Rectangle r)
        {
            using (var brush = new LinearGradientBrush(r,
                Color.FromArgb(200, 160, 40), Color.FromArgb(140, 100, 10),
                LinearGradientMode.Vertical))
            {
                g.FillRectangle(brush, r);
            }
            g.DrawRectangle(new Pen(Color.Goldenrod, 2), r);
            // warning stripes
            using (var pen = new Pen(Color.FromArgb(120, Color.Black), 2))
            {
                pen.DashStyle = DashStyle.Dash;
                g.DrawLine(pen, r.Left, r.Top + r.Height / 2,
                                r.Right, r.Top + r.Height / 2);
            }
            // end posts
            g.FillRectangle(Brushes.DimGray, r.Left, r.Bottom, 8, 20);
            g.FillRectangle(Brushes.DimGray, r.Right - 8, r.Bottom, 8, 20);
        }
    }

    // ─────────────────────────────────────────────────────────
    //  Parallax background layer
    // ─────────────────────────────────────────────────────────
    class BgLayer
    {
        readonly Color _color;
        readonly int   _count;
        readonly int   _yMin, _yMax, _wMin, _wMax, _hMin, _hMax;
        readonly float _parallax;
        readonly List<(float x, int y, int w, int h)> _items = new List<(float, int, int, int)>();
        float _scroll;

        public BgLayer(Color c, int count, int yMin, int yMax,
                       int wMin, int wMax, int hMin, int hMax, float parallax)
        {
            _color = c; _count = count;
            _yMin = yMin; _yMax = yMax;
            _wMin = wMin; _wMax = wMax;
            _hMin = hMin; _hMax = hMax;
            _parallax = parallax;

            var rng = new Random(count * 17);
            for (int i = 0; i < count; i++)
            {
                float x = (float)(rng.NextDouble() * C.W);
                int   y = rng.Next(_yMin, _yMax);
                int   w = rng.Next(_wMin, _wMax);
                int   h = rng.Next(_hMin, _hMax);
                _items.Add((x, y, w, h));
            }
        }

        public void Update(float speed)
        {
            _scroll += speed * _parallax;
            if (_scroll > C.W) _scroll -= C.W;
        }

        public void Draw(Graphics g)
        {
            using var brush = new SolidBrush(_color);
            foreach (var (x, y, w, h) in _items)
            {
                float rx = ((x - _scroll) % C.W + C.W) % C.W;
                g.FillRectangle(brush, rx, y, w, h);
                // wrap around
                if (rx + w > C.W)
                    g.FillRectangle(brush, rx - C.W, y, w, h);
            }
        }
    }

    // ─────────────────────────────────────────────────────────
    //  Particle for death effect
    // ─────────────────────────────────────────────────────────
    class Particle
    {
        public float X, Y, Vx, Vy;
        public int Life, MaxLife;
        public Color Col;
        public int Size;

        public void Update()
        {
            X += Vx; Y += Vy; Vy += 0.3f; Life--;
        }

        public void Draw(Graphics g)
        {
            float alpha = (float)Life / MaxLife;
            using var brush = new SolidBrush(
                Color.FromArgb((int)(255 * alpha), Col));
            g.FillEllipse(brush, X, Y, Size, Size);
        }
    }

    // ─────────────────────────────────────────────────────────
    //  Star for background
    // ─────────────────────────────────────────────────────────

    // ─────────────────────────────────────────────────────────
    //  Main Form / Game Loop
    // ─────────────────────────────────────────────────────────
    class GameForm : Form
    {
        // ── State ──
        enum State { Title, Playing, Dead, Paused }
        State _state = State.Title;

        // ── Player ──
        float _playerY;
        float _velY;
        bool  _onGround;
        bool  _doubleJumpUsed;
        int   _animTick;
        int   _runFrame;  // 0 or 1
        bool  _jumpHeld;

        // ── Game vars ──
        float        _scrollSpeed;
        int          _score;
        int          _hiScore;
        int          _frameCount;
        float        _spawnTimer;
        float        _spawnInterval;
        List<Hazard> _hazards = new List<Hazard>();
        List<Particle> _particles = new List<Particle>();

        // ── Background ──
        BgLayer _bgCity, _bgMid, _bgNear;
        float _groundScroll;

        // ── Sprites ──
        Bitmap _sprRun1, _sprRun2, _sprJump, _sprDead;
        static readonly Color TRANS_KEY = Color.White;

        // ── Buffers ──
        Bitmap _backbuffer;
        Graphics _bbg;

        // ── Timer ──
        Timer _timer = new Timer();
        Random _rng = new Random();

        public GameForm()
        {
            Text            = "Gravity Runner";
            ClientSize      = new Size(C.W, C.H);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox     = false;
            DoubleBuffered  = true;
            BackColor       = Color.Black;

            LoadSprites();
            BuildBackground();

            _backbuffer = new Bitmap(C.W, C.H);
            _bbg        = Graphics.FromImage(_backbuffer);
            _bbg.SmoothingMode = SmoothingMode.AntiAlias;

            _timer.Interval = C.FRAME_DELAY;
            _timer.Tick    += OnTick;
            _timer.Start();

            KeyDown += OnKeyDown;
            KeyUp   += OnKeyUp;
        }

        // ── Sprite loading ────────────────────────────────────
        void LoadSprites()
        {
            _sprRun1 = TryLoadSprite("player_run1.png") ?? BuildFallbackSprite(false, false);
            _sprRun2 = TryLoadSprite("player_run2.png") ?? BuildFallbackSprite(false, false);
            _sprJump = TryLoadSprite("player_jump.png") ?? BuildFallbackSprite(true,  false);
            _sprDead = TryLoadSprite("player_dead.png") ?? BuildFallbackSprite(false, true);

            MakeTransparent(_sprRun1);
            MakeTransparent(_sprRun2);
            MakeTransparent(_sprJump);
            MakeTransparent(_sprDead);
        }

        static Bitmap TryLoadSprite(string name)
        {
            // Look next to EXE first, then current directory
            string exeDir  = AppDomain.CurrentDomain.BaseDirectory;
            string fullPath = Path.Combine(exeDir, name);
            if (!File.Exists(fullPath)) fullPath = name;
            if (!File.Exists(fullPath)) return null;
            return new Bitmap(fullPath);
        }

        /// <summary>
        /// Replace all white-ish pixels with transparent.
        /// Threshold allows for anti-aliasing fringe pixels.
        /// </summary>
        static void MakeTransparent(Bitmap bmp)
        {
            // Fast path: use MakeTransparent for exact white
            bmp.MakeTransparent(Color.White);

            // Also clean fringe AA pixels (r,g,b all > 230)
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color px = bmp.GetPixel(x, y);
                    if (px.A > 0 && px.R > 230 && px.G > 230 && px.B > 230)
                        bmp.SetPixel(x, y, Color.Transparent);
                }
            }
        }

        /// <summary>Fallback sprite drawn purely in code (no file needed).</summary>
        static Bitmap BuildFallbackSprite(bool jumping, bool dead)
        {
            var bmp = new Bitmap(C.SPRITE_W, C.SPRITE_H);
            using var g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            var bodyColor = Color.FromArgb(30, 144, 255);
            var darkBlue  = Color.FromArgb(10,  80, 160);
            var skin      = Color.FromArgb(255, 205, 160);
            var helmet    = Color.FromArgb(20, 100, 200);
            var visor     = Color.FromArgb(100, 200, 255);
            var stripe    = Color.FromArgb(255, 220,   0);
            var boot      = Color.FromArgb(40,  40,  40);

            if (dead)
            {
                // Lying on side
                g.FillRectangle(new SolidBrush(bodyColor), 4,  34, 36, 14);
                g.FillRectangle(new SolidBrush(stripe),    10, 35, 16, 12);
                g.FillRectangle(new SolidBrush(darkBlue),  34, 28, 12, 12);
                g.FillRectangle(new SolidBrush(boot),      34, 36, 12,  8);
                g.FillEllipse(new SolidBrush(helmet), 0, 26, 18, 20);
                g.FillEllipse(new SolidBrush(visor),  2, 28, 14, 16);
                g.FillEllipse(new SolidBrush(skin),   4, 30, 10, 12);
                g.DrawLine(new Pen(Color.Red, 2), 5, 32, 9, 36);
                g.DrawLine(new Pen(Color.Red, 2), 9, 32, 5, 36);
            }
            else if (jumping)
            {
                // Tucked
                g.FillRectangle(new SolidBrush(boot),     8,  50, 12, 10);
                g.FillRectangle(new SolidBrush(boot),    26,  50, 12, 10);
                g.FillRectangle(new SolidBrush(darkBlue), 8,  38, 12, 14);
                g.FillRectangle(new SolidBrush(darkBlue),26,  38, 12, 14);
                g.FillRectangle(new SolidBrush(bodyColor), 8, 20, 32, 20);
                g.FillRectangle(new SolidBrush(stripe),  16, 22, 14, 16);
                // Arms up
                g.FillRectangle(new SolidBrush(bodyColor), 1, 10, 8, 12);
                g.FillRectangle(new SolidBrush(bodyColor),38, 10, 8, 12);
                g.FillEllipse(new SolidBrush(skin),  0,  4, 10, 10);
                g.FillEllipse(new SolidBrush(skin), 38,  4, 10, 10);
                g.FillRectangle(new SolidBrush(skin),19, 14, 10,  8);
                g.FillEllipse(new SolidBrush(helmet), 10, 2, 28, 20);
                g.FillEllipse(new SolidBrush(visor),  14, 5, 20, 14);
                g.FillEllipse(new SolidBrush(skin),   16, 7, 14, 10);
                g.FillEllipse(Brushes.Black, 18,  9, 4, 4);
                g.FillEllipse(Brushes.Black, 25,  9, 4, 4);
            }
            else
            {
                // Standing run
                g.FillRectangle(new SolidBrush(boot),    10, 54, 12, 10);
                g.FillRectangle(new SolidBrush(boot),    26, 54, 12, 10);
                g.FillRectangle(new SolidBrush(darkBlue),10, 42, 12, 14);
                g.FillRectangle(new SolidBrush(darkBlue),26, 42, 12, 14);
                g.FillRectangle(new SolidBrush(bodyColor), 8, 22, 32, 22);
                g.FillRectangle(new SolidBrush(stripe),  16, 24, 14, 18);
                g.FillRectangle(new SolidBrush(bodyColor), 2, 22, 8, 18);
                g.FillRectangle(new SolidBrush(bodyColor),38, 22, 8, 18);
                g.FillEllipse(new SolidBrush(skin),  2, 38, 10, 10);
                g.FillEllipse(new SolidBrush(skin), 36, 38, 10, 10);
                g.FillRectangle(new SolidBrush(skin),19, 16, 10, 8);
                g.FillEllipse(new SolidBrush(helmet), 10, 2, 28, 22);
                g.FillEllipse(new SolidBrush(visor),  14, 6, 20, 14);
                g.FillEllipse(new SolidBrush(skin),   16, 8, 14, 10);
                g.FillEllipse(Brushes.Black, 18, 10, 4, 4);
                g.FillEllipse(Brushes.Black, 25, 10, 4, 4);
            }
            return bmp;
        }

        // ── Background setup ──────────────────────────────────
        void BuildBackground()
        {
            // distant skyline
            _bgCity = new BgLayer(
                Color.FromArgb(40, 50, 80),
                12, 120, 280, 20, 60, 40, 100, 0.15f);
            // mid buildings
            _bgMid  = new BgLayer(
                Color.FromArgb(30, 40, 70),
                8, 200, 320, 30, 80, 30, 80, 0.3f);
            // near objects
            _bgNear = new BgLayer(
                Color.FromArgb(20, 30, 55),
                6, 280, 360, 10, 30, 20, 60, 0.6f);
        }

        // ── Game Reset ────────────────────────────────────────
        void StartGame()
        {
            _playerY      = C.GROUND_Y - C.SPRITE_H;
            _velY         = 0;
            _onGround     = true;
            _doubleJumpUsed = false;
            _animTick     = 0;
            _runFrame     = 0;
            _scrollSpeed  = C.SCROLL_SPD_START;
            _score        = 0;
            _frameCount   = 0;
            _spawnTimer   = 0;
            _spawnInterval= 80;
            _hazards.Clear();
            _particles.Clear();
            _groundScroll = 0;
            _state        = State.Playing;
        }

        // ── Input ─────────────────────────────────────────────
        void OnKeyDown(object s, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Up ||
                e.KeyCode == Keys.W)
            {
                if (_state == State.Title)  { StartGame(); return; }
                if (_state == State.Dead)   { StartGame(); return; }
                if (_state == State.Paused) { _state = State.Playing; return; }

                if (_state == State.Playing)
                {
                    if (_onGround)
                    {
                        _velY  = C.JUMP_VEL;
                        _onGround = false;
                        _doubleJumpUsed = false;
                        _jumpHeld = true;
                    }
                    else if (!_doubleJumpUsed)
                    {
                        _velY  = C.JUMP_VEL * 0.9f;
                        _doubleJumpUsed = true;
                        _jumpHeld = true;
                        SpawnJumpParticles();
                    }
                }
            }

            if (e.KeyCode == Keys.P && _state == State.Playing)
                _state = State.Paused;
            if (e.KeyCode == Keys.P && _state == State.Paused)
                _state = State.Playing;
            if (e.KeyCode == Keys.Escape)
                _state = State.Title;
        }

        void OnKeyUp(object s, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Up ||
                e.KeyCode == Keys.W)
                _jumpHeld = false;
        }

        // ── Main tick ─────────────────────────────────────────
        void OnTick(object s, EventArgs e)
        {
            if (_state == State.Playing)
                Update();
            Render();
            using var g = CreateGraphics();
            g.DrawImageUnscaled(_backbuffer, 0, 0);
        }

        void Update()
        {
            _frameCount++;
            _scrollSpeed = C.SCROLL_SPD_START + _frameCount * C.SCROLL_ACCEL;
            _score       = _frameCount / 6;
            if (_score > _hiScore) _hiScore = _score;

            // ── Physics ──
            float gravity = (_jumpHeld && _velY < 0) ? C.GRAVITY * 0.7f : C.GRAVITY;
            _velY    += gravity;
            _playerY += _velY;

            float groundTop = C.GROUND_Y - C.SPRITE_H;
            if (_playerY >= groundTop)
            {
                _playerY  = groundTop;
                _velY     = 0;
                _onGround = true;
            }
            else
                _onGround = false;

            // ── Animation ──
            if (_onGround)
            {
                _animTick++;
                int period = Math.Max(2, (int)(C.ANIM_FRAMES - _scrollSpeed * 0.3f));
                if (_animTick >= period) { _animTick = 0; _runFrame ^= 1; }
            }

            // ── Ground scroll ──
            _groundScroll = (_groundScroll + _scrollSpeed) % 40;

            // ── Parallax ──
            _bgCity.Update(_scrollSpeed);
            _bgMid.Update(_scrollSpeed);
            _bgNear.Update(_scrollSpeed);

            // ── Hazard spawning ──
            _spawnTimer += _scrollSpeed;
            _spawnInterval = Math.Max(30, 80 - _frameCount * 0.01f);
            if (_spawnTimer >= _spawnInterval * _scrollSpeed / C.SCROLL_SPD_START)
            {
                _spawnTimer = 0;
                SpawnHazard();
            }

            // ── Move hazards ──
            for (int i = _hazards.Count - 1; i >= 0; i--)
            {
                _hazards[i].X -= _scrollSpeed;
                if (_hazards[i].X < -120) _hazards.RemoveAt(i);
            }

            // ── Collision ──
            Rectangle playerRect = new Rectangle(
                C.PLAYER_X + 6, (int)_playerY + 4,
                C.SPRITE_W - 12, C.SPRITE_H - 4);

            foreach (var h in _hazards)
            {
                Rectangle hr = h.GetRect();
                hr.Inflate(-4, -4);  // forgiveness margin
                if (playerRect.IntersectsWith(hr))
                {
                    SpawnDeathParticles();
                    _state = State.Dead;
                    return;
                }
            }

            // ── Particles ──
            for (int i = _particles.Count - 1; i >= 0; i--)
            {
                _particles[i].Update();
                if (_particles[i].Life <= 0) _particles.RemoveAt(i);
            }
        }

        // ── Spawn helpers ─────────────────────────────────────
        void SpawnHazard()
        {
            // Avoid back-to-back identical types
            HazardKind kind = (HazardKind)_rng.Next(3);
            _hazards.Add(new Hazard { X = C.W + 20, Kind = kind });
        }

        void SpawnDeathParticles()
        {
            Color[] cols = { Color.OrangeRed, Color.Yellow, Color.Orange, Color.White };
            for (int i = 0; i < 30; i++)
            {
                float angle = (float)(_rng.NextDouble() * Math.PI * 2);
                float speed = (float)(_rng.NextDouble() * 6 + 1);
                _particles.Add(new Particle
                {
                    X       = C.PLAYER_X + C.SPRITE_W / 2f,
                    Y       = _playerY   + C.SPRITE_H / 2f,
                    Vx      = (float)Math.Cos(angle) * speed,
                    Vy      = (float)Math.Sin(angle) * speed - 3,
                    Life    = _rng.Next(20, 50),
                    MaxLife = 50,
                    Col     = cols[_rng.Next(cols.Length)],
                    Size    = _rng.Next(4, 10)
                });
            }
        }

        void SpawnJumpParticles()
        {
            for (int i = 0; i < 8; i++)
            {
                _particles.Add(new Particle
                {
                    X       = C.PLAYER_X + 10 + _rng.Next(C.SPRITE_W - 20),
                    Y       = _playerY   + C.SPRITE_H,
                    Vx      = (float)(_rng.NextDouble() * 4 - 2),
                    Vy      = (float)(_rng.NextDouble() * -2 - 1),
                    Life    = _rng.Next(8, 18),
                    MaxLife = 18,
                    Col     = Color.FromArgb(100, 200, 255),
                    Size    = _rng.Next(3, 7)
                });
            }
        }

        // ── Render ────────────────────────────────────────────
        void Render()
        {
            var g  = _bbg;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

            // Sky gradient
            using (var sky = new LinearGradientBrush(
                new Rectangle(0, 0, C.W, C.GROUND_Y),
                Color.FromArgb(5, 5, 30), Color.FromArgb(20, 30, 70),
                LinearGradientMode.Vertical))
                g.FillRectangle(sky, 0, 0, C.W, C.GROUND_Y);

            // Stars (static, no scroll)
            DrawStars(g);

            // Moon
            g.FillEllipse(new SolidBrush(Color.FromArgb(220, 230, 200)), C.W - 100, 30, 50, 50);
            g.FillEllipse(new SolidBrush(Color.FromArgb(5, 5, 30)),      C.W - 88,  22, 50, 50);

            // Parallax layers
            _bgCity.Draw(g);
            _bgMid.Draw(g);
            _bgNear.Draw(g);

            // Ground
            DrawGround(g);

            // Particles (behind player)
            foreach (var p in _particles) p.Draw(g);

            // Hazards
            foreach (var h in _hazards) h.Draw(g);

            // Player
            DrawPlayer(g);

            // HUD
            DrawHUD(g);

            // Overlays
            switch (_state)
            {
                case State.Title: DrawTitle(g);  break;
                case State.Dead:  DrawDead(g);   break;
                case State.Paused:DrawPaused(g); break;
            }
        }

        static readonly Point[] _starPts;

        static GameForm()
        {
            var rng = new Random(42);
            _starPts = new Point[120];
            for (int i = 0; i < _starPts.Length; i++)
                _starPts[i] = new Point(rng.Next(C.W), rng.Next(C.GROUND_Y - 40));
        }

        static void DrawStars(Graphics g)
        {
            foreach (var p in _starPts)
                g.FillRectangle(Brushes.White, p.X, p.Y, 2, 2);
        }

        void DrawGround(Graphics g)
        {
            // Ground fill
            using (var gnd = new LinearGradientBrush(
                new Rectangle(0, C.GROUND_Y, C.W, C.H - C.GROUND_Y),
                Color.FromArgb(20, 80, 20), Color.FromArgb(10, 40, 10),
                LinearGradientMode.Vertical))
                g.FillRectangle(gnd, 0, C.GROUND_Y, C.W, C.H - C.GROUND_Y);

            // Top edge highlight
            using var edgePen = new Pen(Color.FromArgb(60, 180, 60), 3);
            g.DrawLine(edgePen, 0, C.GROUND_Y, C.W, C.GROUND_Y);

            // Scrolling lane marks
            using var lanePen = new Pen(Color.FromArgb(40, 120, 40), 1);
            for (float x = -_groundScroll; x < C.W; x += 40)
                g.DrawLine(lanePen, x, C.GROUND_Y, x, C.H);
        }

        void DrawPlayer(Graphics g)
        {
            Bitmap spr;
            if (_state == State.Dead)
                spr = _sprDead;
            else if (!_onGround)
                spr = _sprJump;
            else
                spr = (_runFrame == 0) ? _sprRun1 : _sprRun2;

            g.DrawImage(spr, C.PLAYER_X, (int)_playerY, C.SPRITE_W, C.SPRITE_H);

            // Double jump glow ring
            if (!_onGround && _doubleJumpUsed && _state == State.Playing)
            {
                using var glowPen = new Pen(Color.FromArgb(80, 100, 200, 255), 2);
                g.DrawEllipse(glowPen,
                    C.PLAYER_X - 6, (int)_playerY + C.SPRITE_H / 2 - 6,
                    C.SPRITE_W + 12, 20);
            }
        }

        void DrawHUD(Graphics g)
        {
            using var font   = new Font("Consolas", 14, FontStyle.Bold);
            using var shadow = new SolidBrush(Color.FromArgb(120, Color.Black));
            using var white  = new SolidBrush(Color.White);

            string scoreStr = $"SCORE  {_score:D6}   HI  {_hiScore:D6}";
            g.DrawString(scoreStr, font, shadow, 11, 11);
            g.DrawString(scoreStr, font, white,  10, 10);

            // Speed bar
            float pct = Math.Min(1f, (_scrollSpeed - C.SCROLL_SPD_START) / 15f);
            DrawBar(g, C.W - 160, 10, 140, 14, pct,
                    Color.FromArgb(30, 200, 100), "SPEED");
        }

        static void DrawBar(Graphics g, int x, int y, int w, int h,
                            float pct, Color col, string label)
        {
            g.FillRectangle(new SolidBrush(Color.FromArgb(80, 0, 0, 0)),
                            x, y, w, h);
            g.FillRectangle(new SolidBrush(col), x, y, (int)(w * pct), h);
            g.DrawRectangle(new Pen(Color.FromArgb(150, Color.White)), x, y, w, h);
            using var f = new Font("Consolas", 8);
            g.DrawString(label, f, Brushes.White, x + 2, y + 1);
        }

        static void DrawOverlayBox(Graphics g, string[] lines,
                                   string sub, Color titleColor)
        {
            int bx = C.W / 2 - 220, by = C.H / 2 - 100;
            int bw = 440, bh = 200;

            using var bg = new SolidBrush(Color.FromArgb(190, 5, 5, 20));
            g.FillRoundedRectangle(bg, new Rectangle(bx, by, bw, bh), 16);
            using var border = new Pen(Color.FromArgb(120, titleColor), 2);
            g.DrawRoundedRectangle(border, new Rectangle(bx, by, bw, bh), 16);

            int oy = by + 20;
            foreach (string line in lines)
            {
                bool isTitle = Array.IndexOf(lines, line) == 0;
                float fs = isTitle ? 28 : 16;
                using var f = new Font("Consolas", fs, FontStyle.Bold);
                using var b = new SolidBrush(isTitle ? titleColor : Color.White);
                SizeF sz = g.MeasureString(line, f);
                g.DrawString(line, f, b, C.W / 2f - sz.Width / 2, oy);
                oy += (int)sz.Height + 4;
            }

            if (!string.IsNullOrEmpty(sub))
            {
                using var f2 = new Font("Consolas", 13);
                using var b2 = new SolidBrush(Color.FromArgb(180, Color.Cyan));
                SizeF sz = g.MeasureString(sub, f2);
                g.DrawString(sub, f2, b2,
                    C.W / 2f - sz.Width / 2, by + bh - 36);
            }
        }

        void DrawTitle(Graphics g) =>
            DrawOverlayBox(g,
                new[] { "GRAVITY RUNNER",
                        "SPACE / UP  –  Jump (double-jump allowed)",
                        "P  –  Pause     ESC  –  Title" },
                "Press SPACE to Start",
                Color.FromArgb(100, 200, 255));

        void DrawDead(Graphics g) =>
            DrawOverlayBox(g,
                new[] { "GAME OVER",
                       $"Score: {_score}",
                       $"Best:  {_hiScore}" },
                "Press SPACE to Retry",
                Color.OrangeRed);

        void DrawPaused(Graphics g) =>
            DrawOverlayBox(g,
                new[] { "PAUSED" },
                "Press P to Resume",
                Color.Yellow);

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _timer.Stop();
            _bbg.Dispose();
            _backbuffer.Dispose();
            base.OnFormClosing(e);
        }
    }

    // ─────────────────────────────────────────────────────────
    //  Graphics extension helpers
    // ─────────────────────────────────────────────────────────
    static class GraphicsEx
    {
        public static void FillRoundedRectangle(this Graphics g,
            Brush brush, Rectangle r, int radius)
        {
            using var path = RoundedPath(r, radius);
            g.FillPath(brush, path);
        }

        public static void DrawRoundedRectangle(this Graphics g,
            Pen pen, Rectangle r, int radius)
        {
            using var path = RoundedPath(r, radius);
            g.DrawPath(pen, path);
        }

        static GraphicsPath RoundedPath(Rectangle r, int rad)
        {
            int d = rad * 2;
            var p = new GraphicsPath();
            p.AddArc(r.Left,          r.Top,           d, d, 180, 90);
            p.AddArc(r.Right - d,     r.Top,           d, d, 270, 90);
            p.AddArc(r.Right - d,     r.Bottom - d,    d, d,   0, 90);
            p.AddArc(r.Left,          r.Bottom - d,    d, d,  90, 90);
            p.CloseFigure();
            return p;
        }
    }
}
