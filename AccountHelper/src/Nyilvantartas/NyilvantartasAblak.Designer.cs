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
            this.menuVezerlo = new System.Windows.Forms.TabControl();
            this.oldal_Ceg = new System.Windows.Forms.TabPage();
            this.csoport_Cegek = new System.Windows.Forms.GroupBox();
            this.szerkesztesGomb = new System.Windows.Forms.Button();
            this.torlesGomb = new System.Windows.Forms.Button();
            this.hozzaadasGomb = new System.Windows.Forms.Button();
            this.frissitesGomb = new System.Windows.Forms.Button();
            this.tagLista = new System.Windows.Forms.ListView();
            this.oszlop_tagNeve = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oszlop_tagCimke = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tartalomDoboz = new System.Windows.Forms.TextBox();
            this.cegLista = new System.Windows.Forms.ListView();
            this.oszlop_cegNev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oszlop_fajlHelye = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.csoport_Tagok = new System.Windows.Forms.GroupBox();
            this.menuVezerlo.SuspendLayout();
            this.oldal_Ceg.SuspendLayout();
            this.csoport_Cegek.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuVezerlo
            // 
            this.menuVezerlo.Controls.Add(this.oldal_Ceg);
            this.menuVezerlo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuVezerlo.Location = new System.Drawing.Point(0, 0);
            this.menuVezerlo.Name = "menuVezerlo";
            this.menuVezerlo.SelectedIndex = 0;
            this.menuVezerlo.Size = new System.Drawing.Size(796, 706);
            this.menuVezerlo.TabIndex = 0;
            this.menuVezerlo.Tag = "";
            // 
            // oldal_Ceg
            // 
            this.oldal_Ceg.Controls.Add(this.csoport_Tagok);
            this.oldal_Ceg.Controls.Add(this.csoport_Cegek);
            this.oldal_Ceg.Controls.Add(this.frissitesGomb);
            this.oldal_Ceg.Controls.Add(this.tagLista);
            this.oldal_Ceg.Controls.Add(this.tartalomDoboz);
            this.oldal_Ceg.Controls.Add(this.cegLista);
            this.oldal_Ceg.Location = new System.Drawing.Point(4, 22);
            this.oldal_Ceg.Name = "oldal_Ceg";
            this.oldal_Ceg.Padding = new System.Windows.Forms.Padding(3);
            this.oldal_Ceg.Size = new System.Drawing.Size(788, 680);
            this.oldal_Ceg.TabIndex = 0;
            this.oldal_Ceg.Text = "Cégek";
            this.oldal_Ceg.UseVisualStyleBackColor = true;
            // 
            // csoport_Cegek
            // 
            this.csoport_Cegek.Controls.Add(this.szerkesztesGomb);
            this.csoport_Cegek.Controls.Add(this.torlesGomb);
            this.csoport_Cegek.Controls.Add(this.hozzaadasGomb);
            this.csoport_Cegek.Location = new System.Drawing.Point(3, 6);
            this.csoport_Cegek.Name = "csoport_Cegek";
            this.csoport_Cegek.Size = new System.Drawing.Size(372, 61);
            this.csoport_Cegek.TabIndex = 7;
            this.csoport_Cegek.TabStop = false;
            this.csoport_Cegek.Text = "Cégek";
            // 
            // szerkesztesGomb
            // 
            this.szerkesztesGomb.BackColor = System.Drawing.Color.Transparent;
            this.szerkesztesGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szerkesztesGomb.Image = global::AccountHelper.Properties.Resources.icon_edit;
            this.szerkesztesGomb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.szerkesztesGomb.Location = new System.Drawing.Point(243, 16);
            this.szerkesztesGomb.Name = "szerkesztesGomb";
            this.szerkesztesGomb.Size = new System.Drawing.Size(123, 39);
            this.szerkesztesGomb.TabIndex = 4;
            this.szerkesztesGomb.Text = "Szerkesztés  ";
            this.szerkesztesGomb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.szerkesztesGomb.UseVisualStyleBackColor = false;
            this.szerkesztesGomb.Click += new System.EventHandler(this.SzerkesztesGomb_Click);
            // 
            // torlesGomb
            // 
            this.torlesGomb.BackColor = System.Drawing.Color.Transparent;
            this.torlesGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.torlesGomb.Image = global::AccountHelper.Properties.Resources.icon_delete_alt;
            this.torlesGomb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.torlesGomb.Location = new System.Drawing.Point(137, 16);
            this.torlesGomb.Name = "torlesGomb";
            this.torlesGomb.Size = new System.Drawing.Size(100, 39);
            this.torlesGomb.TabIndex = 1;
            this.torlesGomb.Text = "Törlés      ";
            this.torlesGomb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.torlesGomb.UseVisualStyleBackColor = false;
            this.torlesGomb.Click += new System.EventHandler(this.TorlesGomb_Click);
            // 
            // hozzaadasGomb
            // 
            this.hozzaadasGomb.BackColor = System.Drawing.Color.Transparent;
            this.hozzaadasGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hozzaadasGomb.Image = ((System.Drawing.Image)(resources.GetObject("hozzaadasGomb.Image")));
            this.hozzaadasGomb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hozzaadasGomb.Location = new System.Drawing.Point(6, 16);
            this.hozzaadasGomb.Name = "hozzaadasGomb";
            this.hozzaadasGomb.Size = new System.Drawing.Size(125, 39);
            this.hozzaadasGomb.TabIndex = 2;
            this.hozzaadasGomb.Text = "Hozzáadás    ";
            this.hozzaadasGomb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hozzaadasGomb.UseVisualStyleBackColor = false;
            this.hozzaadasGomb.Click += new System.EventHandler(this.HozzaadasGomb_Click);
            // 
            // frissitesGomb
            // 
            this.frissitesGomb.BackColor = System.Drawing.Color.Transparent;
            this.frissitesGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.frissitesGomb.Image = global::AccountHelper.Properties.Resources.icon_refresh;
            this.frissitesGomb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.frissitesGomb.Location = new System.Drawing.Point(381, 22);
            this.frissitesGomb.Name = "frissitesGomb";
            this.frissitesGomb.Size = new System.Drawing.Size(103, 39);
            this.frissitesGomb.TabIndex = 3;
            this.frissitesGomb.Text = "Frissítés    ";
            this.frissitesGomb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.frissitesGomb.UseVisualStyleBackColor = false;
            this.frissitesGomb.Click += new System.EventHandler(this.FrissitesGomb_Click);
            // 
            // tagLista
            // 
            this.tagLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.oszlop_tagNeve,
            this.oszlop_tagCimke});
            this.tagLista.FullRowSelect = true;
            this.tagLista.GridLines = true;
            this.tagLista.HideSelection = false;
            this.tagLista.Location = new System.Drawing.Point(490, 73);
            this.tagLista.Name = "tagLista";
            this.tagLista.Size = new System.Drawing.Size(295, 604);
            this.tagLista.TabIndex = 6;
            this.tagLista.UseCompatibleStateImageBehavior = false;
            this.tagLista.View = System.Windows.Forms.View.Details;
            // 
            // oszlop_tagNeve
            // 
            this.oszlop_tagNeve.Text = "Név";
            this.oszlop_tagNeve.Width = 175;
            // 
            // oszlop_tagCimke
            // 
            this.oszlop_tagCimke.Text = "Címke";
            this.oszlop_tagCimke.Width = 115;
            // 
            // tartalomDoboz
            // 
            this.tartalomDoboz.Enabled = false;
            this.tartalomDoboz.Location = new System.Drawing.Point(3, 379);
            this.tartalomDoboz.Multiline = true;
            this.tartalomDoboz.Name = "tartalomDoboz";
            this.tartalomDoboz.ReadOnly = true;
            this.tartalomDoboz.Size = new System.Drawing.Size(481, 298);
            this.tartalomDoboz.TabIndex = 5;
            // 
            // cegLista
            // 
            this.cegLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.oszlop_cegNev,
            this.oszlop_fajlHelye});
            this.cegLista.FullRowSelect = true;
            this.cegLista.GridLines = true;
            this.cegLista.HideSelection = false;
            this.cegLista.Location = new System.Drawing.Point(3, 73);
            this.cegLista.Name = "cegLista";
            this.cegLista.Size = new System.Drawing.Size(481, 300);
            this.cegLista.TabIndex = 0;
            this.cegLista.UseCompatibleStateImageBehavior = false;
            this.cegLista.View = System.Windows.Forms.View.Details;
            this.cegLista.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CegLista_MouseClick);
            // 
            // oszlop_cegNev
            // 
            this.oszlop_cegNev.Text = "Cég neve";
            this.oszlop_cegNev.Width = 155;
            // 
            // oszlop_fajlHelye
            // 
            this.oszlop_fajlHelye.Text = "Forrás";
            this.oszlop_fajlHelye.Width = 150;
            // 
            // csoport_Tagok
            // 
            this.csoport_Tagok.Location = new System.Drawing.Point(490, 6);
            this.csoport_Tagok.Name = "csoport_Tagok";
            this.csoport_Tagok.Size = new System.Drawing.Size(295, 61);
            this.csoport_Tagok.TabIndex = 8;
            this.csoport_Tagok.TabStop = false;
            this.csoport_Tagok.Text = "Kontaktok";
            // 
            // NyilvantartasAblak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 706);
            this.Controls.Add(this.menuVezerlo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NyilvantartasAblak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nyilvántartás";
            this.Load += new System.EventHandler(this.NyilvantartasAblak_Load);
            this.menuVezerlo.ResumeLayout(false);
            this.oldal_Ceg.ResumeLayout(false);
            this.oldal_Ceg.PerformLayout();
            this.csoport_Cegek.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl menuVezerlo;
        private System.Windows.Forms.TabPage oldal_Ceg;
        private System.Windows.Forms.Button torlesGomb;
        private System.Windows.Forms.ListView cegLista;
        private System.Windows.Forms.Button hozzaadasGomb;
        private System.Windows.Forms.ColumnHeader oszlop_cegNev;
        private System.Windows.Forms.ColumnHeader oszlop_fajlHelye;
        private System.Windows.Forms.Button frissitesGomb;
        private System.Windows.Forms.Button szerkesztesGomb;
        private System.Windows.Forms.TextBox tartalomDoboz;
        private System.Windows.Forms.ListView tagLista;
        private System.Windows.Forms.ColumnHeader oszlop_tagNeve;
        private System.Windows.Forms.ColumnHeader oszlop_tagCimke;
        private System.Windows.Forms.GroupBox csoport_Cegek;
        private System.Windows.Forms.GroupBox csoport_Tagok;
    }
}