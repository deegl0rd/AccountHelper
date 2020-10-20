using AccountHelper.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AccountHelper.src
{
    partial class NevjegyPanel
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(NevjegyPanel));
            this.NevjegyPanelCim = new Label();
            this.NevjegyPanelKep = new PictureBox();
            this.NevjegyPanelVerSzam = new Label();
            this.NevjegyPanelCeg = new Label();
            this.NevjegyPanelLicenszTajekoztato = new Label();
            this.NevjegyPanelSzovegDoboz = new TextBox();
            ((ISupportInitialize)this.NevjegyPanelKep).BeginInit();
            this.SuspendLayout();
            this.NevjegyPanelCim.AutoSize = true;
            this.NevjegyPanelCim.Font = new Font("Ebrima", 20.25f, FontStyle.Bold);
            this.NevjegyPanelCim.Location = new Point(167, 9);
            this.NevjegyPanelCim.Name = "nevjegyPanelCim";
            this.NevjegyPanelCim.Size = new Size(269, 37);
            this.NevjegyPanelCim.TabIndex = 0;
            this.NevjegyPanelCim.Text = "<terméknév helye>";
            this.NevjegyPanelKep.Image = (Image)Resources.xkr_picture;
            this.NevjegyPanelKep.Location = new Point(12, 12);
            this.NevjegyPanelKep.Name = "nevjegyPanelKep";
            this.NevjegyPanelKep.Size = new Size(150, 150);
            this.NevjegyPanelKep.TabIndex = 1;
            this.NevjegyPanelKep.TabStop = false;
            this.NevjegyPanelVerSzam.AutoSize = true;
            this.NevjegyPanelVerSzam.Font = new Font("Ebrima", 12f, FontStyle.Bold);
            this.NevjegyPanelVerSzam.Location = new Point(170, 46);
            this.NevjegyPanelVerSzam.Name = "nevjegyPanelVerSzam";
            this.NevjegyPanelVerSzam.Size = new Size(164, 21);
            this.NevjegyPanelVerSzam.TabIndex = 2;
            this.NevjegyPanelVerSzam.Text = "<verziószám helye>";
            this.NevjegyPanelCeg.AutoSize = true;
            this.NevjegyPanelCeg.Font = new Font("Ebrima", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte)238);
            this.NevjegyPanelCeg.Location = new Point(171, 86);
            this.NevjegyPanelCeg.Name = "nevjegyPanelCeg";
            this.NevjegyPanelCeg.Size = new Size(93, 15);
            this.NevjegyPanelCeg.TabIndex = 3;
            this.NevjegyPanelCeg.Text = "<Cégnév helye>";
            this.NevjegyPanelLicenszTajekoztato.Font = new Font("Ebrima", 8.25f);
            this.NevjegyPanelLicenszTajekoztato.Location = new Point(171, 118);
            this.NevjegyPanelLicenszTajekoztato.Name = "nevjegyPanelLicenszTajekoztato";
            this.NevjegyPanelLicenszTajekoztato.Size = new Size(332, 44);
            this.NevjegyPanelLicenszTajekoztato.TabIndex = 4;
            this.NevjegyPanelLicenszTajekoztato.Text = "A termék határozatlan ideig zárt alapú egyedi licensz alatt fut. A termék nem terjeszthető illetve változtatható.";
            this.NevjegyPanelSzovegDoboz.Font = new Font("Ebrima", 8.25f);
            this.NevjegyPanelSzovegDoboz.Location = new Point(12, 168);
            this.NevjegyPanelSzovegDoboz.Multiline = true;
            this.NevjegyPanelSzovegDoboz.Name = "nevjegyPanelSzovegDoboz";
            this.NevjegyPanelSzovegDoboz.ReadOnly = true;
            this.NevjegyPanelSzovegDoboz.ScrollBars = ScrollBars.Both;
            this.NevjegyPanelSzovegDoboz.Size = new Size(491, 218);
            this.NevjegyPanelSzovegDoboz.TabIndex = 5;
            this.NevjegyPanelSzovegDoboz.TabStop = false;
            this.NevjegyPanelSzovegDoboz.Text = componentResourceManager.GetString("nevjegyPanelSzovegDoboz.Text");
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(515, 398);
            this.Controls.Add((Control)this.NevjegyPanelSzovegDoboz);
            this.Controls.Add((Control)this.NevjegyPanelLicenszTajekoztato);
            this.Controls.Add((Control)this.NevjegyPanelCeg);
            this.Controls.Add((Control)this.NevjegyPanelVerSzam);
            this.Controls.Add((Control)this.NevjegyPanelKep);
            this.Controls.Add((Control)this.NevjegyPanelCim);
            this.Font = new Font("Ebrima", 8.25f);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = nameof(NevjegyPanel);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Névjegydoboz";
            this.Load += new EventHandler(this.NevjegyPanel_Load);
            ((ISupportInitialize)this.NevjegyPanelKep).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label NevjegyPanelCim;
        private System.Windows.Forms.PictureBox NevjegyPanelKep;
        private System.Windows.Forms.Label NevjegyPanelVerSzam;
        private System.Windows.Forms.Label NevjegyPanelCeg;
        private System.Windows.Forms.Label NevjegyPanelLicenszTajekoztato;
        private System.Windows.Forms.TextBox NevjegyPanelSzovegDoboz;
    }
}