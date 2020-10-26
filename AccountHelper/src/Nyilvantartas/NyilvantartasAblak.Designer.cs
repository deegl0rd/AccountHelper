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
            this.csoport_SzervezetiEgyseg = new System.Windows.Forms.GroupBox();
            this.szerv_hozzadasGomb = new System.Windows.Forms.Button();
            this.szerv_torlesGomb = new System.Windows.Forms.Button();
            this.csoport_Cegek = new System.Windows.Forms.GroupBox();
            this.ceg_szerkesztesGomb = new System.Windows.Forms.Button();
            this.ceg_torlesGomb = new System.Windows.Forms.Button();
            this.ceg_hozzaadasGomb = new System.Windows.Forms.Button();
            this.frissitesGomb = new System.Windows.Forms.Button();
            this.szervezetiEgysegLista = new System.Windows.Forms.ListView();
            this.oszlop_szvNeve = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oszlop_szvSablon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tartalomDoboz = new System.Windows.Forms.TextBox();
            this.cegLista = new System.Windows.Forms.ListView();
            this.oszlop_cegNev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oszlop_fajlHelye = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuVezerlo.SuspendLayout();
            this.oldal_Ceg.SuspendLayout();
            this.csoport_SzervezetiEgyseg.SuspendLayout();
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
            this.oldal_Ceg.Controls.Add(this.csoport_SzervezetiEgyseg);
            this.oldal_Ceg.Controls.Add(this.csoport_Cegek);
            this.oldal_Ceg.Controls.Add(this.frissitesGomb);
            this.oldal_Ceg.Controls.Add(this.szervezetiEgysegLista);
            this.oldal_Ceg.Controls.Add(this.tartalomDoboz);
            this.oldal_Ceg.Controls.Add(this.cegLista);
            this.oldal_Ceg.Location = new System.Drawing.Point(4, 22);
            this.oldal_Ceg.Name = "oldal_Ceg";
            this.oldal_Ceg.Padding = new System.Windows.Forms.Padding(3);
            this.oldal_Ceg.Size = new System.Drawing.Size(788, 680);
            this.oldal_Ceg.TabIndex = 0;
            this.oldal_Ceg.Text = "Cégek nyilvántartása";
            this.oldal_Ceg.UseVisualStyleBackColor = true;
            // 
            // csoport_SzervezetiEgyseg
            // 
            this.csoport_SzervezetiEgyseg.Controls.Add(this.szerv_hozzadasGomb);
            this.csoport_SzervezetiEgyseg.Controls.Add(this.szerv_torlesGomb);
            this.csoport_SzervezetiEgyseg.Location = new System.Drawing.Point(490, 6);
            this.csoport_SzervezetiEgyseg.Name = "csoport_SzervezetiEgyseg";
            this.csoport_SzervezetiEgyseg.Size = new System.Drawing.Size(295, 61);
            this.csoport_SzervezetiEgyseg.TabIndex = 8;
            this.csoport_SzervezetiEgyseg.TabStop = false;
            this.csoport_SzervezetiEgyseg.Text = "Szervezeti egységek";
            // 
            // szerv_hozzadasGomb
            // 
            this.szerv_hozzadasGomb.BackColor = System.Drawing.Color.Transparent;
            this.szerv_hozzadasGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szerv_hozzadasGomb.Image = ((System.Drawing.Image)(resources.GetObject("szerv_hozzadasGomb.Image")));
            this.szerv_hozzadasGomb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.szerv_hozzadasGomb.Location = new System.Drawing.Point(6, 16);
            this.szerv_hozzadasGomb.Name = "szerv_hozzadasGomb";
            this.szerv_hozzadasGomb.Size = new System.Drawing.Size(125, 39);
            this.szerv_hozzadasGomb.TabIndex = 5;
            this.szerv_hozzadasGomb.Text = "Hozzáadás    ";
            this.szerv_hozzadasGomb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.szerv_hozzadasGomb.UseVisualStyleBackColor = false;
            this.szerv_hozzadasGomb.Click += new System.EventHandler(this.Szerv_HozzadasGomb_Click);
            // 
            // szerv_torlesGomb
            // 
            this.szerv_torlesGomb.BackColor = System.Drawing.Color.Transparent;
            this.szerv_torlesGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szerv_torlesGomb.Image = global::AccountHelper.Properties.Resources.icon_delete_alt;
            this.szerv_torlesGomb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.szerv_torlesGomb.Location = new System.Drawing.Point(137, 16);
            this.szerv_torlesGomb.Name = "szerv_torlesGomb";
            this.szerv_torlesGomb.Size = new System.Drawing.Size(100, 39);
            this.szerv_torlesGomb.TabIndex = 5;
            this.szerv_torlesGomb.Text = "Törlés      ";
            this.szerv_torlesGomb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.szerv_torlesGomb.UseVisualStyleBackColor = false;
            this.szerv_torlesGomb.Click += new System.EventHandler(this.Szerv_TorlesGomb_Click);
            // 
            // csoport_Cegek
            // 
            this.csoport_Cegek.Controls.Add(this.ceg_szerkesztesGomb);
            this.csoport_Cegek.Controls.Add(this.ceg_torlesGomb);
            this.csoport_Cegek.Controls.Add(this.ceg_hozzaadasGomb);
            this.csoport_Cegek.Location = new System.Drawing.Point(3, 6);
            this.csoport_Cegek.Name = "csoport_Cegek";
            this.csoport_Cegek.Size = new System.Drawing.Size(372, 61);
            this.csoport_Cegek.TabIndex = 7;
            this.csoport_Cegek.TabStop = false;
            this.csoport_Cegek.Text = "Cégek";
            // 
            // ceg_szerkesztesGomb
            // 
            this.ceg_szerkesztesGomb.BackColor = System.Drawing.Color.Transparent;
            this.ceg_szerkesztesGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ceg_szerkesztesGomb.Image = global::AccountHelper.Properties.Resources.icon_edit;
            this.ceg_szerkesztesGomb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ceg_szerkesztesGomb.Location = new System.Drawing.Point(243, 16);
            this.ceg_szerkesztesGomb.Name = "ceg_szerkesztesGomb";
            this.ceg_szerkesztesGomb.Size = new System.Drawing.Size(123, 39);
            this.ceg_szerkesztesGomb.TabIndex = 4;
            this.ceg_szerkesztesGomb.Text = "Szerkesztés  ";
            this.ceg_szerkesztesGomb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ceg_szerkesztesGomb.UseVisualStyleBackColor = false;
            this.ceg_szerkesztesGomb.Click += new System.EventHandler(this.SzerkesztesGomb_Click);
            // 
            // ceg_torlesGomb
            // 
            this.ceg_torlesGomb.BackColor = System.Drawing.Color.Transparent;
            this.ceg_torlesGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ceg_torlesGomb.Image = global::AccountHelper.Properties.Resources.icon_delete_alt;
            this.ceg_torlesGomb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ceg_torlesGomb.Location = new System.Drawing.Point(137, 16);
            this.ceg_torlesGomb.Name = "ceg_torlesGomb";
            this.ceg_torlesGomb.Size = new System.Drawing.Size(100, 39);
            this.ceg_torlesGomb.TabIndex = 1;
            this.ceg_torlesGomb.Text = "Törlés      ";
            this.ceg_torlesGomb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ceg_torlesGomb.UseVisualStyleBackColor = false;
            this.ceg_torlesGomb.Click += new System.EventHandler(this.CegTorlesGomb_Click);
            // 
            // ceg_hozzaadasGomb
            // 
            this.ceg_hozzaadasGomb.BackColor = System.Drawing.Color.Transparent;
            this.ceg_hozzaadasGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ceg_hozzaadasGomb.Image = ((System.Drawing.Image)(resources.GetObject("ceg_hozzaadasGomb.Image")));
            this.ceg_hozzaadasGomb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ceg_hozzaadasGomb.Location = new System.Drawing.Point(6, 16);
            this.ceg_hozzaadasGomb.Name = "ceg_hozzaadasGomb";
            this.ceg_hozzaadasGomb.Size = new System.Drawing.Size(125, 39);
            this.ceg_hozzaadasGomb.TabIndex = 2;
            this.ceg_hozzaadasGomb.Text = "Hozzáadás    ";
            this.ceg_hozzaadasGomb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ceg_hozzaadasGomb.UseVisualStyleBackColor = false;
            this.ceg_hozzaadasGomb.Click += new System.EventHandler(this.HozzaadasGomb_Click);
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
            // szervezetiEgysegLista
            // 
            this.szervezetiEgysegLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.oszlop_szvNeve,
            this.oszlop_szvSablon});
            this.szervezetiEgysegLista.FullRowSelect = true;
            this.szervezetiEgysegLista.GridLines = true;
            this.szervezetiEgysegLista.HideSelection = false;
            this.szervezetiEgysegLista.Location = new System.Drawing.Point(490, 73);
            this.szervezetiEgysegLista.Name = "szervezetiEgysegLista";
            this.szervezetiEgysegLista.Size = new System.Drawing.Size(295, 604);
            this.szervezetiEgysegLista.TabIndex = 6;
            this.szervezetiEgysegLista.UseCompatibleStateImageBehavior = false;
            this.szervezetiEgysegLista.View = System.Windows.Forms.View.Details;
            // 
            // oszlop_szvNeve
            // 
            this.oszlop_szvNeve.Text = "Név";
            this.oszlop_szvNeve.Width = 175;
            // 
            // oszlop_szvSablon
            // 
            this.oszlop_szvSablon.Text = "Sablon";
            this.oszlop_szvSablon.Width = 115;
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
            this.csoport_SzervezetiEgyseg.ResumeLayout(false);
            this.csoport_Cegek.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl menuVezerlo;
        private System.Windows.Forms.TabPage oldal_Ceg;
        private System.Windows.Forms.Button ceg_torlesGomb;
        private System.Windows.Forms.ListView cegLista;
        private System.Windows.Forms.Button ceg_hozzaadasGomb;
        private System.Windows.Forms.ColumnHeader oszlop_cegNev;
        private System.Windows.Forms.ColumnHeader oszlop_fajlHelye;
        private System.Windows.Forms.Button frissitesGomb;
        private System.Windows.Forms.Button ceg_szerkesztesGomb;
        private System.Windows.Forms.TextBox tartalomDoboz;
        private System.Windows.Forms.ListView szervezetiEgysegLista;
        private System.Windows.Forms.ColumnHeader oszlop_szvNeve;
        private System.Windows.Forms.ColumnHeader oszlop_szvSablon;
        private System.Windows.Forms.GroupBox csoport_Cegek;
        private System.Windows.Forms.GroupBox csoport_SzervezetiEgyseg;
        private System.Windows.Forms.Button szerv_hozzadasGomb;
        private System.Windows.Forms.Button szerv_torlesGomb;
    }
}