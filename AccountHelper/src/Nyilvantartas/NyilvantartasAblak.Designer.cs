namespace AccountHelper.src.Nyilvantartas
{
    partial class NyilvantartasAblak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NyilvantartasAblak));
            this.Tab = new System.Windows.Forms.TabControl();
            this.oldal_Ceg = new System.Windows.Forms.TabPage();
            this.cegLista = new System.Windows.Forms.ListView();
            this.oszlop_cegNev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oszlop_fajlHelye = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oldal_Alkalmazott = new System.Windows.Forms.TabPage();
            this.szerkesztesGomb = new System.Windows.Forms.Button();
            this.frissitesGomb = new System.Windows.Forms.Button();
            this.hozzaadasGomb = new System.Windows.Forms.Button();
            this.torlesGomb = new System.Windows.Forms.Button();
            this.Tab.SuspendLayout();
            this.oldal_Ceg.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.oldal_Ceg);
            this.Tab.Controls.Add(this.oldal_Alkalmazott);
            this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab.Location = new System.Drawing.Point(0, 0);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(495, 706);
            this.Tab.TabIndex = 0;
            this.Tab.Tag = "";
            // 
            // oldal_Ceg
            // 
            this.oldal_Ceg.Controls.Add(this.szerkesztesGomb);
            this.oldal_Ceg.Controls.Add(this.frissitesGomb);
            this.oldal_Ceg.Controls.Add(this.hozzaadasGomb);
            this.oldal_Ceg.Controls.Add(this.torlesGomb);
            this.oldal_Ceg.Controls.Add(this.cegLista);
            this.oldal_Ceg.Location = new System.Drawing.Point(4, 22);
            this.oldal_Ceg.Name = "oldal_Ceg";
            this.oldal_Ceg.Padding = new System.Windows.Forms.Padding(3);
            this.oldal_Ceg.Size = new System.Drawing.Size(487, 680);
            this.oldal_Ceg.TabIndex = 0;
            this.oldal_Ceg.Text = "Cégek";
            this.oldal_Ceg.UseVisualStyleBackColor = true;
            // 
            // cegLista
            // 
            this.cegLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.oszlop_cegNev,
            this.oszlop_fajlHelye});
            this.cegLista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cegLista.FullRowSelect = true;
            this.cegLista.GridLines = true;
            this.cegLista.HideSelection = false;
            this.cegLista.Location = new System.Drawing.Point(3, 73);
            this.cegLista.Name = "cegLista";
            this.cegLista.Size = new System.Drawing.Size(481, 604);
            this.cegLista.TabIndex = 0;
            this.cegLista.UseCompatibleStateImageBehavior = false;
            this.cegLista.View = System.Windows.Forms.View.Details;
            // 
            // oszlop_cegNev
            // 
            this.oszlop_cegNev.Text = "Cég neve";
            this.oszlop_cegNev.Width = 155;
            // 
            // oszlop_fajlHelye
            // 
            this.oszlop_fajlHelye.Text = "Forrás";
            this.oszlop_fajlHelye.Width = 321;
            // 
            // oldal_Alkalmazott
            // 
            this.oldal_Alkalmazott.Location = new System.Drawing.Point(4, 22);
            this.oldal_Alkalmazott.Name = "oldal_Alkalmazott";
            this.oldal_Alkalmazott.Padding = new System.Windows.Forms.Padding(3);
            this.oldal_Alkalmazott.Size = new System.Drawing.Size(487, 680);
            this.oldal_Alkalmazott.TabIndex = 1;
            this.oldal_Alkalmazott.Text = "Alkalmazottak";
            this.oldal_Alkalmazott.UseVisualStyleBackColor = true;
            // 
            // szerkesztesGomb
            // 
            this.szerkesztesGomb.BackColor = System.Drawing.Color.Transparent;
            this.szerkesztesGomb.Image = global::AccountHelper.Properties.Resources.icon_edit;
            this.szerkesztesGomb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.szerkesztesGomb.Location = new System.Drawing.Point(361, 19);
            this.szerkesztesGomb.Name = "szerkesztesGomb";
            this.szerkesztesGomb.Size = new System.Drawing.Size(118, 39);
            this.szerkesztesGomb.TabIndex = 4;
            this.szerkesztesGomb.Text = "Szerkesztés  ";
            this.szerkesztesGomb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.szerkesztesGomb.UseVisualStyleBackColor = false;
            this.szerkesztesGomb.Click += new System.EventHandler(this.SzerkesztesGomb_Click);
            // 
            // frissitesGomb
            // 
            this.frissitesGomb.BackColor = System.Drawing.Color.Transparent;
            this.frissitesGomb.Image = global::AccountHelper.Properties.Resources.icon_refresh;
            this.frissitesGomb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.frissitesGomb.Location = new System.Drawing.Point(244, 19);
            this.frissitesGomb.Name = "frissitesGomb";
            this.frissitesGomb.Size = new System.Drawing.Size(111, 39);
            this.frissitesGomb.TabIndex = 3;
            this.frissitesGomb.Text = "Frissítés    ";
            this.frissitesGomb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.frissitesGomb.UseVisualStyleBackColor = false;
            this.frissitesGomb.Click += new System.EventHandler(this.FrissitesGomb_Click);
            // 
            // hozzaadasGomb
            // 
            this.hozzaadasGomb.BackColor = System.Drawing.Color.Transparent;
            this.hozzaadasGomb.Image = ((System.Drawing.Image)(resources.GetObject("hozzaadasGomb.Image")));
            this.hozzaadasGomb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hozzaadasGomb.Location = new System.Drawing.Point(8, 19);
            this.hozzaadasGomb.Name = "hozzaadasGomb";
            this.hozzaadasGomb.Size = new System.Drawing.Size(115, 39);
            this.hozzaadasGomb.TabIndex = 2;
            this.hozzaadasGomb.Text = "Hozzáadás    ";
            this.hozzaadasGomb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hozzaadasGomb.UseVisualStyleBackColor = false;
            this.hozzaadasGomb.Click += new System.EventHandler(this.HozzaadasGomb_Click);
            // 
            // torlesGomb
            // 
            this.torlesGomb.BackColor = System.Drawing.Color.Transparent;
            this.torlesGomb.Image = global::AccountHelper.Properties.Resources.icon_delete_alt;
            this.torlesGomb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.torlesGomb.Location = new System.Drawing.Point(129, 19);
            this.torlesGomb.Name = "torlesGomb";
            this.torlesGomb.Size = new System.Drawing.Size(109, 39);
            this.torlesGomb.TabIndex = 1;
            this.torlesGomb.Text = "Törlés      ";
            this.torlesGomb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.torlesGomb.UseVisualStyleBackColor = false;
            this.torlesGomb.Click += new System.EventHandler(this.TorlesGomb_Click);
            // 
            // NyilvantartasAblak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 706);
            this.Controls.Add(this.Tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NyilvantartasAblak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nyilvántartás";
            this.Load += new System.EventHandler(this.NyilvantartasAblak_Load);
            this.Tab.ResumeLayout(false);
            this.oldal_Ceg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage oldal_Ceg;
        private System.Windows.Forms.TabPage oldal_Alkalmazott;
        private System.Windows.Forms.Button torlesGomb;
        private System.Windows.Forms.ListView cegLista;
        private System.Windows.Forms.Button hozzaadasGomb;
        private System.Windows.Forms.ColumnHeader oszlop_cegNev;
        private System.Windows.Forms.ColumnHeader oszlop_fajlHelye;
        private System.Windows.Forms.Button frissitesGomb;
        private System.Windows.Forms.Button szerkesztesGomb;
    }
}