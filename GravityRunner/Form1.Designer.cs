// ================================================================
//  Form1.Designer.cs  —  GRAVITY RUNNER
//  Paste this as Form1.Designer.cs in your project.
//  All event handler names use PascalCase to match Form1.cs.
// ================================================================

namespace GravityRunner
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // ── Control declarations ─────────────────────────────────
        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.Panel pnlHUD;
        private System.Windows.Forms.Label lblScoreTitle;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblHiTitle;
        private System.Windows.Forms.Label lblHiScore;
        private System.Windows.Forms.Label lblSpeedTitle;
        private System.Windows.Forms.ProgressBar pbSpeed;
        private System.Windows.Forms.Label lblDoubleJump;
        private System.Windows.Forms.Label lblDash;
        private System.Windows.Forms.PictureBox picSpritePreview;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Label lblControls;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btnJump;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitleHeading;
        private System.Windows.Forms.Label lblTitleInstructions;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Panel pnlGameOver;
        private System.Windows.Forms.Label lblGameOverHeading;
        private System.Windows.Forms.Label lblFinalScore;
        private System.Windows.Forms.Label lblFinalBest;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.Panel pnlPaused;
        private System.Windows.Forms.Label lblPausedHeading;
        private System.Windows.Forms.Button btnResume;

        private void InitializeComponent()
        {
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.pnlHUD = new System.Windows.Forms.Panel();
            this.lblScoreTitle = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblHiTitle = new System.Windows.Forms.Label();
            this.lblHiScore = new System.Windows.Forms.Label();
            this.lblSpeedTitle = new System.Windows.Forms.Label();
            this.pbSpeed = new System.Windows.Forms.ProgressBar();
            this.lblDoubleJump = new System.Windows.Forms.Label();
            this.lblDash = new System.Windows.Forms.Label();
            this.btnDash = new System.Windows.Forms.Button();
            this.picSpritePreview = new System.Windows.Forms.PictureBox();
            this.lblControls = new System.Windows.Forms.Label();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnJump = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitleHeading = new System.Windows.Forms.Label();
            this.lblTitleInstructions = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.pnlGameOver = new System.Windows.Forms.Panel();
            this.lblGameOverHeading = new System.Windows.Forms.Label();
            this.lblFinalScore = new System.Windows.Forms.Label();
            this.lblFinalBest = new System.Windows.Forms.Label();
            this.btnRetry = new System.Windows.Forms.Button();
            this.pnlPaused = new System.Windows.Forms.Panel();
            this.lblPausedHeading = new System.Windows.Forms.Label();
            this.btnResume = new System.Windows.Forms.Button();

            this.SuspendLayout();
            this.pnlCanvas.SuspendLayout();
            this.pnlHUD.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlGameOver.SuspendLayout();
            this.pnlPaused.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSpritePreview)).BeginInit();

            // ── pnlCanvas ────────────────────────────────────────
            this.pnlCanvas.BackColor = System.Drawing.Color.Black;
            this.pnlCanvas.Location = new System.Drawing.Point(0, 0);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(900, 500);
            this.pnlCanvas.TabIndex = 0;
            this.pnlCanvas.TabStop = true;
            this.pnlCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlCanvas_Paint);
            this.pnlCanvas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PnlCanvas_KeyDown);
            this.pnlCanvas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PnlCanvas_KeyUp);

            // ── pnlHUD ───────────────────────────────────────────
            this.pnlHUD.BackColor = System.Drawing.Color.FromArgb(15, 15, 40);
            this.pnlHUD.Location = new System.Drawing.Point(900, 0);
            this.pnlHUD.Name = "pnlHUD";
            this.pnlHUD.Size = new System.Drawing.Size(160, 500);
            this.pnlHUD.TabIndex = 1;

            this.lblScoreTitle.AutoSize = false;
            this.lblScoreTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreTitle.ForeColor = System.Drawing.Color.FromArgb(100, 200, 255);
            this.lblScoreTitle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblScoreTitle.Location = new System.Drawing.Point(8, 12);
            this.lblScoreTitle.Name = "lblScoreTitle";
            this.lblScoreTitle.Size = new System.Drawing.Size(144, 16);
            this.lblScoreTitle.Text = "SCORE";
            this.lblScoreTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblScore.AutoSize = false;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.lblScore.Location = new System.Drawing.Point(8, 28);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(144, 30);
            this.lblScore.Text = "000000";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblHiTitle.AutoSize = false;
            this.lblHiTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblHiTitle.ForeColor = System.Drawing.Color.FromArgb(255, 220, 60);
            this.lblHiTitle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblHiTitle.Location = new System.Drawing.Point(8, 68);
            this.lblHiTitle.Name = "lblHiTitle";
            this.lblHiTitle.Size = new System.Drawing.Size(144, 16);
            this.lblHiTitle.Text = "BEST";
            this.lblHiTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblHiScore.AutoSize = false;
            this.lblHiScore.BackColor = System.Drawing.Color.Transparent;
            this.lblHiScore.ForeColor = System.Drawing.Color.FromArgb(255, 220, 60);
            this.lblHiScore.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.lblHiScore.Location = new System.Drawing.Point(8, 84);
            this.lblHiScore.Name = "lblHiScore";
            this.lblHiScore.Size = new System.Drawing.Size(144, 30);
            this.lblHiScore.Text = "000000";
            this.lblHiScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblSpeedTitle.AutoSize = false;
            this.lblSpeedTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSpeedTitle.ForeColor = System.Drawing.Color.FromArgb(30, 200, 100);
            this.lblSpeedTitle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblSpeedTitle.Location = new System.Drawing.Point(8, 128);
            this.lblSpeedTitle.Name = "lblSpeedTitle";
            this.lblSpeedTitle.Size = new System.Drawing.Size(144, 16);
            this.lblSpeedTitle.Text = "SPEED";
            this.lblSpeedTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.pbSpeed.Location = new System.Drawing.Point(8, 146);
            this.pbSpeed.Name = "pbSpeed";
            this.pbSpeed.Size = new System.Drawing.Size(144, 14);
            this.pbSpeed.Minimum = 0;
            this.pbSpeed.Maximum = 100;
            this.pbSpeed.Value = 0;
            this.pbSpeed.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbSpeed.ForeColor = System.Drawing.Color.FromArgb(30, 200, 100);
            this.pbSpeed.BackColor = System.Drawing.Color.FromArgb(30, 30, 60);

            this.lblDoubleJump.AutoSize = false;
            this.lblDoubleJump.BackColor = System.Drawing.Color.FromArgb(30, 30, 60);
            this.lblDoubleJump.ForeColor = System.Drawing.Color.FromArgb(100, 200, 255);
            this.lblDoubleJump.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold);
            this.lblDoubleJump.Location = new System.Drawing.Point(8, 172);
            this.lblDoubleJump.Name = "lblDoubleJump";
            this.lblDoubleJump.Size = new System.Drawing.Size(144, 22);
            this.lblDoubleJump.Text = "⚡ DBL JUMP READY";
            this.lblDoubleJump.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDoubleJump.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDash.AutoSize = false; this.lblDash.BackColor = System.Drawing.Color.FromArgb(30, 30, 20);
            this.lblDash.ForeColor = System.Drawing.Color.FromArgb(80, 255, 140);
            this.lblDash.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold);
            this.lblDash.Location = new System.Drawing.Point(8, 198); this.lblDash.Name = "lblDash";
            this.lblDash.Size = new System.Drawing.Size(144, 22); this.lblDash.Text = "▶ dash (air only)";
            this.lblDash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.picSpritePreview.BackColor = System.Drawing.Color.FromArgb(25, 25, 55);
            this.picSpritePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSpritePreview.Location = new System.Drawing.Point(8, 208);
            this.picSpritePreview.Name = "picSpritePreview";
            this.picSpritePreview.Size = new System.Drawing.Size(144, 80);
            this.picSpritePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSpritePreview.TabStop = false;

            this.lblControls.AutoSize = false;
            this.lblControls.BackColor = System.Drawing.Color.Transparent;
            this.lblControls.ForeColor = System.Drawing.Color.FromArgb(140, 140, 180);
            this.lblControls.Font = new System.Drawing.Font("Consolas", 7.5F);
            this.lblControls.Location = new System.Drawing.Point(8, 302);
            this.lblControls.Name = "lblControls";
            this.lblControls.Size = new System.Drawing.Size(144, 90);
            this.lblControls.Text = "CONTROLS\r\n─────────\r\nSPACE / ↑  Jump\r\n(again) Dbl-Jump\r\nP  Pause\r\nESC  Title";
            this.lblControls.TextAlign = System.Drawing.ContentAlignment.TopLeft;

            this.pnlHUD.Controls.Add(this.lblScoreTitle);
            this.pnlHUD.Controls.Add(this.lblScore);
            this.pnlHUD.Controls.Add(this.lblHiTitle);
            this.pnlHUD.Controls.Add(this.lblHiScore);
            this.pnlHUD.Controls.Add(this.lblSpeedTitle);
            this.pnlHUD.Controls.Add(this.pbSpeed);
            this.pnlHUD.Controls.Add(this.lblDoubleJump);
            this.pnlHUD.Controls.Add(this.lblDash);
            this.pnlHUD.Controls.Add(this.picSpritePreview);
            this.pnlHUD.Controls.Add(this.lblControls);

            // ── pnlControls ──────────────────────────────────────
            this.pnlControls.BackColor = System.Drawing.Color.FromArgb(10, 10, 30);
            this.pnlControls.Location = new System.Drawing.Point(0, 500);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(1060, 50);
            this.pnlControls.TabIndex = 2;

            this.btnJump.BackColor = System.Drawing.Color.FromArgb(30, 100, 200);
            this.btnJump.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJump.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 160, 255);
            this.btnJump.FlatAppearance.BorderSize = 1;
            this.btnJump.ForeColor = System.Drawing.Color.White;
            this.btnJump.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.btnJump.Location = new System.Drawing.Point(10, 8);
            this.btnJump.Name = "btnJump";
            this.btnJump.Size = new System.Drawing.Size(140, 34);
            this.btnJump.TabIndex = 0;
            this.btnJump.Text = "▲  JUMP";
            this.btnJump.UseVisualStyleBackColor = false;
            this.btnJump.Click += new System.EventHandler(this.BtnJump_Click);

            this.btnDash.BackColor = System.Drawing.Color.FromArgb(60, 50, 10);
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 200, 50);
            this.btnDash.ForeColor = System.Drawing.Color.FromArgb(255, 220, 80);
            this.btnDash.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.btnDash.Location = new System.Drawing.Point(150, 8); this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(130, 34); this.btnDash.Text = "▶  DASH";
            this.btnDash.UseVisualStyleBackColor = false;
            this.btnDash.Click += new System.EventHandler(this.BtnDash_Click);
            // then in pnlControls.Controls.Add: add btnDash after btnJump
            // also shift btnPause to X=290, btnRestart to X=430

            this.btnPause.BackColor = System.Drawing.Color.FromArgb(60, 60, 20);
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 200, 60);
            this.btnPause.FlatAppearance.BorderSize = 1;
            this.btnPause.ForeColor = System.Drawing.Color.FromArgb(255, 230, 60);
            this.btnPause.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.btnPause.Location = new System.Drawing.Point(160, 8);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(140, 34);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "⏸  PAUSE";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.BtnPause_Click);

            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(60, 20, 20);
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 60, 60);
            this.btnRestart.FlatAppearance.BorderSize = 1;
            this.btnRestart.ForeColor = System.Drawing.Color.FromArgb(255, 100, 100);
            this.btnRestart.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.btnRestart.Location = new System.Drawing.Point(310, 8);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(140, 34);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "↺  RESTART";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.BtnRestart_Click);

            this.pnlControls.Controls.Add(this.btnJump);
            this.pnlControls.Controls.Add(this.btnPause);
            this.pnlControls.Controls.Add(this.btnRestart);

            // ── pnlTitle ─────────────────────────────────────────
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(210, 5, 5, 20);
            this.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitle.Location = new System.Drawing.Point(230, 150);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(440, 200);
            this.pnlTitle.TabIndex = 10;
            this.pnlTitle.Visible = true;

            this.lblTitleHeading.AutoSize = false;
            this.lblTitleHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleHeading.ForeColor = System.Drawing.Color.FromArgb(100, 200, 255);
            this.lblTitleHeading.Font = new System.Drawing.Font("Consolas", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitleHeading.Location = new System.Drawing.Point(0, 16);
            this.lblTitleHeading.Name = "lblTitleHeading";
            this.lblTitleHeading.Size = new System.Drawing.Size(438, 44);
            this.lblTitleHeading.Text = "GRAVITY RUNNER";
            this.lblTitleHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblTitleInstructions.AutoSize = false;
            this.lblTitleInstructions.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleInstructions.ForeColor = System.Drawing.Color.White;
            this.lblTitleInstructions.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblTitleInstructions.Location = new System.Drawing.Point(10, 68);
            this.lblTitleInstructions.Name = "lblTitleInstructions";
            this.lblTitleInstructions.Size = new System.Drawing.Size(418, 60);
            this.lblTitleInstructions.Text = "SPACE / ↑ — Jump  (press again for double-jump)\r\nP — Pause          ESC — Title screen";
            this.lblTitleInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.btnStartGame.BackColor = System.Drawing.Color.FromArgb(30, 100, 200);
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 200, 255);
            this.btnStartGame.FlatAppearance.BorderSize = 1;
            this.btnStartGame.ForeColor = System.Drawing.Color.White;
            this.btnStartGame.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.btnStartGame.Location = new System.Drawing.Point(130, 148);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(178, 36);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "▶  START GAME";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.BtnStartGame_Click);

            this.pnlTitle.Controls.Add(this.lblTitleHeading);
            this.pnlTitle.Controls.Add(this.lblTitleInstructions);
            this.pnlTitle.Controls.Add(this.btnStartGame);

            // ── pnlGameOver ──────────────────────────────────────
            this.pnlGameOver.BackColor = System.Drawing.Color.FromArgb(210, 5, 5, 20);
            this.pnlGameOver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGameOver.Location = new System.Drawing.Point(230, 150);
            this.pnlGameOver.Name = "pnlGameOver";
            this.pnlGameOver.Size = new System.Drawing.Size(440, 200);
            this.pnlGameOver.TabIndex = 11;
            this.pnlGameOver.Visible = false;

            this.lblGameOverHeading.AutoSize = false;
            this.lblGameOverHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOverHeading.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblGameOverHeading.Font = new System.Drawing.Font("Consolas", 28F, System.Drawing.FontStyle.Bold);
            this.lblGameOverHeading.Location = new System.Drawing.Point(0, 16);
            this.lblGameOverHeading.Name = "lblGameOverHeading";
            this.lblGameOverHeading.Size = new System.Drawing.Size(438, 46);
            this.lblGameOverHeading.Text = "GAME OVER";
            this.lblGameOverHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblFinalScore.AutoSize = false;
            this.lblFinalScore.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalScore.ForeColor = System.Drawing.Color.White;
            this.lblFinalScore.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.lblFinalScore.Location = new System.Drawing.Point(0, 72);
            this.lblFinalScore.Name = "lblFinalScore";
            this.lblFinalScore.Size = new System.Drawing.Size(438, 26);
            this.lblFinalScore.Text = "Score: 000000";
            this.lblFinalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblFinalBest.AutoSize = false;
            this.lblFinalBest.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalBest.ForeColor = System.Drawing.Color.FromArgb(255, 220, 60);
            this.lblFinalBest.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.lblFinalBest.Location = new System.Drawing.Point(0, 100);
            this.lblFinalBest.Name = "lblFinalBest";
            this.lblFinalBest.Size = new System.Drawing.Size(438, 26);
            this.lblFinalBest.Text = "Best:  000000";
            this.lblFinalBest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.btnRetry.BackColor = System.Drawing.Color.FromArgb(30, 100, 200);
            this.btnRetry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetry.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 200, 255);
            this.btnRetry.FlatAppearance.BorderSize = 1;
            this.btnRetry.ForeColor = System.Drawing.Color.White;
            this.btnRetry.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.btnRetry.Location = new System.Drawing.Point(130, 150);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(178, 36);
            this.btnRetry.TabIndex = 0;
            this.btnRetry.Text = "↺  TRY AGAIN";
            this.btnRetry.UseVisualStyleBackColor = false;
            this.btnRetry.Click += new System.EventHandler(this.BtnRetry_Click);

            this.pnlGameOver.Controls.Add(this.lblGameOverHeading);
            this.pnlGameOver.Controls.Add(this.lblFinalScore);
            this.pnlGameOver.Controls.Add(this.lblFinalBest);
            this.pnlGameOver.Controls.Add(this.btnRetry);

            // ── pnlPaused ────────────────────────────────────────
            this.pnlPaused.BackColor = System.Drawing.Color.FromArgb(210, 5, 5, 20);
            this.pnlPaused.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPaused.Location = new System.Drawing.Point(310, 185);
            this.pnlPaused.Name = "pnlPaused";
            this.pnlPaused.Size = new System.Drawing.Size(280, 130);
            this.pnlPaused.TabIndex = 12;
            this.pnlPaused.Visible = false;

            this.lblPausedHeading.AutoSize = false;
            this.lblPausedHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblPausedHeading.ForeColor = System.Drawing.Color.Yellow;
            this.lblPausedHeading.Font = new System.Drawing.Font("Consolas", 28F, System.Drawing.FontStyle.Bold);
            this.lblPausedHeading.Location = new System.Drawing.Point(0, 14);
            this.lblPausedHeading.Name = "lblPausedHeading";
            this.lblPausedHeading.Size = new System.Drawing.Size(278, 46);
            this.lblPausedHeading.Text = "PAUSED";
            this.lblPausedHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.btnResume.BackColor = System.Drawing.Color.FromArgb(60, 60, 20);
            this.btnResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResume.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnResume.FlatAppearance.BorderSize = 1;
            this.btnResume.ForeColor = System.Drawing.Color.Yellow;
            this.btnResume.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.btnResume.Location = new System.Drawing.Point(54, 76);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(172, 36);
            this.btnResume.TabIndex = 0;
            this.btnResume.Text = "▶  RESUME";
            this.btnResume.UseVisualStyleBackColor = false;
            this.btnResume.Click += new System.EventHandler(this.BtnResume_Click);

            this.pnlPaused.Controls.Add(this.lblPausedHeading);
            this.pnlPaused.Controls.Add(this.btnResume);

            // ── Add overlay panels to canvas ─────────────────────
            this.pnlCanvas.Controls.Add(this.pnlPaused);
            this.pnlCanvas.Controls.Add(this.pnlGameOver);
            this.pnlCanvas.Controls.Add(this.pnlTitle);

            // ── Form1 ────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(10, 10, 30);
            this.ClientSize = new System.Drawing.Size(1060, 550);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Gravity Runner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Controls.Add(this.pnlCanvas);
            this.Controls.Add(this.pnlHUD);
            this.Controls.Add(this.pnlControls);

            this.pnlCanvas.ResumeLayout(false);
            this.pnlHUD.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlGameOver.ResumeLayout(false);
            this.pnlPaused.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSpritePreview)).EndInit();
            this.ResumeLayout(false);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }
    }
}

