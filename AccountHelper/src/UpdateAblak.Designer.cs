namespace AccountHelper.src
{
    partial class UpdateAblak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateAblak));
            this.okGomb = new System.Windows.Forms.Button();
            this.gitLinkGomb = new System.Windows.Forms.Button();
            this.jelenlegiVerzioSzoveg = new System.Windows.Forms.Label();
            this.legujabbVerzioSzoveg = new System.Windows.Forms.Label();
            this.jelenlegiVerzioDoboz = new System.Windows.Forms.TextBox();
            this.legujabbVerzioDoboz = new System.Windows.Forms.TextBox();
            this.FrissitesKep = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FrissitesKep)).BeginInit();
            this.SuspendLayout();
            // 
            // okGomb
            // 
            this.okGomb.Location = new System.Drawing.Point(206, 65);
            this.okGomb.Name = "okGomb";
            this.okGomb.Size = new System.Drawing.Size(83, 23);
            this.okGomb.TabIndex = 1;
            this.okGomb.Text = "OK";
            this.okGomb.UseVisualStyleBackColor = true;
            this.okGomb.Click += new System.EventHandler(this.OkGomb_Click);
            // 
            // gitLinkGomb
            // 
            this.gitLinkGomb.Location = new System.Drawing.Point(97, 65);
            this.gitLinkGomb.Name = "gitLinkGomb";
            this.gitLinkGomb.Size = new System.Drawing.Size(103, 23);
            this.gitLinkGomb.TabIndex = 2;
            this.gitLinkGomb.Text = "GitHub Repo";
            this.gitLinkGomb.UseVisualStyleBackColor = true;
            this.gitLinkGomb.Click += new System.EventHandler(this.GitLinkGomb_Click);
            // 
            // jelenlegiVerzioSzoveg
            // 
            this.jelenlegiVerzioSzoveg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jelenlegiVerzioSzoveg.Location = new System.Drawing.Point(94, 9);
            this.jelenlegiVerzioSzoveg.Name = "jelenlegiVerzioSzoveg";
            this.jelenlegiVerzioSzoveg.Size = new System.Drawing.Size(131, 23);
            this.jelenlegiVerzioSzoveg.TabIndex = 4;
            this.jelenlegiVerzioSzoveg.Text = "Jelenlegi verzió:";
            this.jelenlegiVerzioSzoveg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // legujabbVerzioSzoveg
            // 
            this.legujabbVerzioSzoveg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.legujabbVerzioSzoveg.Location = new System.Drawing.Point(94, 34);
            this.legujabbVerzioSzoveg.Name = "legujabbVerzioSzoveg";
            this.legujabbVerzioSzoveg.Size = new System.Drawing.Size(131, 23);
            this.legujabbVerzioSzoveg.TabIndex = 6;
            this.legujabbVerzioSzoveg.Text = "Legújabb verzió:";
            this.legujabbVerzioSzoveg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // jelenlegiVerzioDoboz
            // 
            this.jelenlegiVerzioDoboz.Location = new System.Drawing.Point(231, 11);
            this.jelenlegiVerzioDoboz.Name = "jelenlegiVerzioDoboz";
            this.jelenlegiVerzioDoboz.ReadOnly = true;
            this.jelenlegiVerzioDoboz.Size = new System.Drawing.Size(58, 20);
            this.jelenlegiVerzioDoboz.TabIndex = 7;
            // 
            // legujabbVerzioDoboz
            // 
            this.legujabbVerzioDoboz.Location = new System.Drawing.Point(231, 36);
            this.legujabbVerzioDoboz.Name = "legujabbVerzioDoboz";
            this.legujabbVerzioDoboz.ReadOnly = true;
            this.legujabbVerzioDoboz.Size = new System.Drawing.Size(58, 20);
            this.legujabbVerzioDoboz.TabIndex = 8;
            // 
            // FrissitesKep
            // 
            this.FrissitesKep.BackColor = System.Drawing.Color.White;
            this.FrissitesKep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FrissitesKep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FrissitesKep.Image = ((System.Drawing.Image)(resources.GetObject("FrissitesKep.Image")));
            this.FrissitesKep.Location = new System.Drawing.Point(12, 12);
            this.FrissitesKep.Name = "FrissitesKep";
            this.FrissitesKep.Size = new System.Drawing.Size(76, 76);
            this.FrissitesKep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FrissitesKep.TabIndex = 0;
            this.FrissitesKep.TabStop = false;
            this.FrissitesKep.Tag = "";
            this.FrissitesKep.Click += new System.EventHandler(this.FrissitesKep_Click);
            this.FrissitesKep.MouseEnter += new System.EventHandler(this.FrissitesKep_MouseEnter);
            this.FrissitesKep.MouseLeave += new System.EventHandler(this.FrissitesKep_MouseLeave);
            // 
            // UpdateAblak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 100);
            this.ControlBox = false;
            this.Controls.Add(this.legujabbVerzioDoboz);
            this.Controls.Add(this.jelenlegiVerzioDoboz);
            this.Controls.Add(this.legujabbVerzioSzoveg);
            this.Controls.Add(this.jelenlegiVerzioSzoveg);
            this.Controls.Add(this.gitLinkGomb);
            this.Controls.Add(this.okGomb);
            this.Controls.Add(this.FrissitesKep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UpdateAblak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Újabb verzió érhető el!";
            this.Load += new System.EventHandler(this.UpdateAblak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FrissitesKep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FrissitesKep;
        private System.Windows.Forms.Button okGomb;
        private System.Windows.Forms.Button gitLinkGomb;
        private System.Windows.Forms.Label jelenlegiVerzioSzoveg;
        private System.Windows.Forms.Label legujabbVerzioSzoveg;
        private System.Windows.Forms.TextBox jelenlegiVerzioDoboz;
        private System.Windows.Forms.TextBox legujabbVerzioDoboz;
    }
}