namespace AccountHelper.src
{
    partial class StartupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupForm));
            this.FelsoSav = new System.Windows.Forms.MenuStrip();
            this.nyilvántartásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XKROlvasóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.munkaidőToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlsoSav = new System.Windows.Forms.StatusStrip();
            this.IdoSav = new System.Windows.Forms.ToolStripStatusLabel();
            this.CegekSav = new System.Windows.Forms.ToolStripStatusLabel();
            this.VerzioszamSav = new System.Windows.Forms.ToolStripStatusLabel();
            this.Splash = new System.Windows.Forms.PictureBox();
            this.Idozito = new System.Windows.Forms.Timer(this.components);
            this.beállításokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FelsoSav.SuspendLayout();
            this.AlsoSav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Splash)).BeginInit();
            this.SuspendLayout();
            // 
            // FelsoSav
            // 
            this.FelsoSav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyilvántartásToolStripMenuItem,
            this.XKROlvasóToolStripMenuItem,
            this.munkaidőToolStripMenuItem,
            this.beállításokToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.FelsoSav.Location = new System.Drawing.Point(0, 0);
            this.FelsoSav.Name = "FelsoSav";
            this.FelsoSav.Size = new System.Drawing.Size(800, 24);
            this.FelsoSav.TabIndex = 1;
            this.FelsoSav.Text = "menuStrip1";
            // 
            // nyilvántartásToolStripMenuItem
            // 
            this.nyilvántartásToolStripMenuItem.Name = "nyilvántartásToolStripMenuItem";
            this.nyilvántartásToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.nyilvántartásToolStripMenuItem.Text = "Nyilvántartás";
            this.nyilvántartásToolStripMenuItem.Click += new System.EventHandler(this.NyilvántartásToolStripMenuItem_Click);
            // 
            // XKROlvasóToolStripMenuItem
            // 
            this.XKROlvasóToolStripMenuItem.Name = "XKROlvasóToolStripMenuItem";
            this.XKROlvasóToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.XKROlvasóToolStripMenuItem.Text = "XKR Olvasó";
            this.XKROlvasóToolStripMenuItem.Click += new System.EventHandler(this.XKROlvasóToolStripMenuItem_Click);
            // 
            // munkaidőToolStripMenuItem
            // 
            this.munkaidőToolStripMenuItem.Name = "munkaidőToolStripMenuItem";
            this.munkaidőToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.munkaidőToolStripMenuItem.Text = "Munkaidő";
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.KilépésToolStripMenuItem_Click);
            // 
            // AlsoSav
            // 
            this.AlsoSav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IdoSav,
            this.CegekSav,
            this.VerzioszamSav});
            this.AlsoSav.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.AlsoSav.Location = new System.Drawing.Point(0, 623);
            this.AlsoSav.Name = "AlsoSav";
            this.AlsoSav.Size = new System.Drawing.Size(800, 24);
            this.AlsoSav.SizingGrip = false;
            this.AlsoSav.TabIndex = 2;
            this.AlsoSav.Text = "statusStrip1";
            // 
            // IdoSav
            // 
            this.IdoSav.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.IdoSav.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.IdoSav.Name = "IdoSav";
            this.IdoSav.Size = new System.Drawing.Size(44, 19);
            this.IdoSav.Text = "<idő>";
            // 
            // CegekSav
            // 
            this.CegekSav.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.CegekSav.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.CegekSav.Name = "CegekSav";
            this.CegekSav.Size = new System.Drawing.Size(107, 19);
            this.CegekSav.Text = "<betöltött cégek>";
            // 
            // VerzioszamSav
            // 
            this.VerzioszamSav.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.VerzioszamSav.IsLink = true;
            this.VerzioszamSav.Name = "VerzioszamSav";
            this.VerzioszamSav.Size = new System.Drawing.Size(85, 19);
            this.VerzioszamSav.Text = "<verzioszam>";
            this.VerzioszamSav.Click += new System.EventHandler(this.VerzioszamSav_Click);
            // 
            // Splash
            // 
            this.Splash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Splash.Image = global::AccountHelper.Properties.Resources.accounthelper;
            this.Splash.Location = new System.Drawing.Point(0, 24);
            this.Splash.Name = "Splash";
            this.Splash.Size = new System.Drawing.Size(800, 623);
            this.Splash.TabIndex = 0;
            this.Splash.TabStop = false;
            // 
            // Idozito
            // 
            this.Idozito.Tick += new System.EventHandler(this.Idozito_Tick);
            // 
            // beállításokToolStripMenuItem
            // 
            this.beállításokToolStripMenuItem.Name = "beállításokToolStripMenuItem";
            this.beállításokToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.beállításokToolStripMenuItem.Text = "Beállítások";
            this.beállításokToolStripMenuItem.Click += new System.EventHandler(this.BeállításokToolStripMenuItem_Click);
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 647);
            this.Controls.Add(this.AlsoSav);
            this.Controls.Add(this.Splash);
            this.Controls.Add(this.FelsoSav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.FelsoSav;
            this.MaximizeBox = false;
            this.Name = "StartupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountHelper";
            this.Load += new System.EventHandler(this.StartupForm_Load);
            this.Shown += new System.EventHandler(this.StartupForm_Shown);
            this.FelsoSav.ResumeLayout(false);
            this.FelsoSav.PerformLayout();
            this.AlsoSav.ResumeLayout(false);
            this.AlsoSav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Splash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Splash;
        private System.Windows.Forms.MenuStrip FelsoSav;
        private System.Windows.Forms.ToolStripMenuItem nyilvántartásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XKROlvasóToolStripMenuItem;
        private System.Windows.Forms.StatusStrip AlsoSav;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem munkaidőToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel IdoSav;
        private System.Windows.Forms.ToolStripStatusLabel CegekSav;
        private System.Windows.Forms.Timer Idozito;
        private System.Windows.Forms.ToolStripStatusLabel VerzioszamSav;
        private System.Windows.Forms.ToolStripMenuItem beállításokToolStripMenuItem;
    }
}