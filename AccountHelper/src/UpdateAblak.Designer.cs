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
            this.FrissitesKep = new System.Windows.Forms.PictureBox();
            this.okGomb = new System.Windows.Forms.Button();
            this.gitLinkGomb = new System.Windows.Forms.Button();
            this.jelenlegiVerzioDoboz = new System.Windows.Forms.TextBox();
            this.jelenlegiVerzioSzoveg = new System.Windows.Forms.Label();
            this.legujabbVerzioSzoveg = new System.Windows.Forms.Label();
            this.legujabbVerzioDoboz = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FrissitesKep)).BeginInit();
            this.SuspendLayout();
            // 
            // FrissitesKep
            // 
            this.FrissitesKep.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FrissitesKep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FrissitesKep.Image = ((System.Drawing.Image)(resources.GetObject("FrissitesKep.Image")));
            this.FrissitesKep.Location = new System.Drawing.Point(12, 12);
            this.FrissitesKep.Name = "FrissitesKep";
            this.FrissitesKep.Size = new System.Drawing.Size(73, 71);
            this.FrissitesKep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FrissitesKep.TabIndex = 0;
            this.FrissitesKep.TabStop = false;
            // 
            // okGomb
            // 
            this.okGomb.Location = new System.Drawing.Point(122, 60);
            this.okGomb.Name = "okGomb";
            this.okGomb.Size = new System.Drawing.Size(167, 23);
            this.okGomb.TabIndex = 1;
            this.okGomb.Text = "OK";
            this.okGomb.UseVisualStyleBackColor = true;
            this.okGomb.Click += new System.EventHandler(this.OkGomb_Click);
            // 
            // gitLinkGomb
            // 
            this.gitLinkGomb.Location = new System.Drawing.Point(122, 12);
            this.gitLinkGomb.Name = "gitLinkGomb";
            this.gitLinkGomb.Size = new System.Drawing.Size(167, 23);
            this.gitLinkGomb.TabIndex = 2;
            this.gitLinkGomb.Text = "GitHub Link...";
            this.gitLinkGomb.UseVisualStyleBackColor = true;
            this.gitLinkGomb.Click += new System.EventHandler(this.GitLinkGomb_Click);
            // 
            // jelenlegiVerzioDoboz
            // 
            this.jelenlegiVerzioDoboz.Location = new System.Drawing.Point(172, 100);
            this.jelenlegiVerzioDoboz.Name = "jelenlegiVerzioDoboz";
            this.jelenlegiVerzioDoboz.ReadOnly = true;
            this.jelenlegiVerzioDoboz.Size = new System.Drawing.Size(70, 20);
            this.jelenlegiVerzioDoboz.TabIndex = 3;
            // 
            // jelenlegiVerzioSzoveg
            // 
            this.jelenlegiVerzioSzoveg.Location = new System.Drawing.Point(59, 98);
            this.jelenlegiVerzioSzoveg.Name = "jelenlegiVerzioSzoveg";
            this.jelenlegiVerzioSzoveg.Size = new System.Drawing.Size(107, 23);
            this.jelenlegiVerzioSzoveg.TabIndex = 4;
            this.jelenlegiVerzioSzoveg.Text = "Jelenlegi verzió:";
            this.jelenlegiVerzioSzoveg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // legujabbVerzioSzoveg
            // 
            this.legujabbVerzioSzoveg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.legujabbVerzioSzoveg.Location = new System.Drawing.Point(59, 121);
            this.legujabbVerzioSzoveg.Name = "legujabbVerzioSzoveg";
            this.legujabbVerzioSzoveg.Size = new System.Drawing.Size(107, 23);
            this.legujabbVerzioSzoveg.TabIndex = 6;
            this.legujabbVerzioSzoveg.Text = "Legújabb verzió:";
            this.legujabbVerzioSzoveg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // legujabbVerzioDoboz
            // 
            this.legujabbVerzioDoboz.Location = new System.Drawing.Point(172, 123);
            this.legujabbVerzioDoboz.Name = "legujabbVerzioDoboz";
            this.legujabbVerzioDoboz.ReadOnly = true;
            this.legujabbVerzioDoboz.Size = new System.Drawing.Size(70, 20);
            this.legujabbVerzioDoboz.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 149);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(277, 135);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Új verzió érhető el! A frissítés Git pull funkcióval érhető el!";
            // 
            // UpdateAblak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 296);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.legujabbVerzioSzoveg);
            this.Controls.Add(this.legujabbVerzioDoboz);
            this.Controls.Add(this.jelenlegiVerzioSzoveg);
            this.Controls.Add(this.jelenlegiVerzioDoboz);
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
        private System.Windows.Forms.TextBox jelenlegiVerzioDoboz;
        private System.Windows.Forms.Label jelenlegiVerzioSzoveg;
        private System.Windows.Forms.Label legujabbVerzioSzoveg;
        private System.Windows.Forms.TextBox legujabbVerzioDoboz;
        private System.Windows.Forms.TextBox textBox1;
    }
}