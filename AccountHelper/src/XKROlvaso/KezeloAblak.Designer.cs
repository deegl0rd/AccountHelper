namespace AccountHelper.src.XKROlvaso
{
    partial class KezeloAblak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KezeloAblak));
            this.fajlNyito = new System.Windows.Forms.OpenFileDialog();
            this.helyValaszto = new System.Windows.Forms.FolderBrowserDialog();
            this.kimenetiHely = new System.Windows.Forms.TextBox();
            this.Lista = new System.Windows.Forms.ListView();
            this.fejlec_nev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fejlec_datumMikortol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fejlec_datumMeddig = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fejlec_napok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fejlec_adoazonositojel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fejlec_tajszam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fejlec_tipus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jobbKlikkMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.masolasMenupont = new System.Windows.Forms.ToolStripMenuItem();
            this.nevMasolasaMenupont = new System.Windows.Forms.ToolStripMenuItem();
            this.mikortolMasolasaMenupont = new System.Windows.Forms.ToolStripMenuItem();
            this.meddigMasolasaMenupont = new System.Windows.Forms.ToolStripMenuItem();
            this.napokMasolasaMenupont = new System.Windows.Forms.ToolStripMenuItem();
            this.adoszamMasolasaMenupont = new System.Windows.Forms.ToolStripMenuItem();
            this.tajszamMasolasaMenupont = new System.Windows.Forms.ToolStripMenuItem();
            this.mezoMasolasaMenupont = new System.Windows.Forms.ToolStripMenuItem();
            this.torlesMenupont = new System.Windows.Forms.ToolStripMenuItem();
            this.mindentKijelolMenupont = new System.Windows.Forms.ToolStripMenuItem();
            this.excelKonvertalasMenupont = new System.Windows.Forms.ToolStripMenuItem();
            this.mindentExcelbeKonvertalasMenupont = new System.Windows.Forms.ToolStripMenuItem();
            this.excelKimenetiHelySzoveg = new System.Windows.Forms.Label();
            this.fajlBehuzasSzoveg = new System.Windows.Forms.Label();
            this.rendezesGomb = new System.Windows.Forms.Button();
            this.nevjegyGomb = new System.Windows.Forms.Button();
            this.kepDoboz = new System.Windows.Forms.PictureBox();
            this.excelKonvertalGomb = new System.Windows.Forms.Button();
            this.torlesGomb = new System.Windows.Forms.Button();
            this.fajlokGomb = new System.Windows.Forms.Button();
            this.kimenetGomb = new System.Windows.Forms.Button();
            this.jobbKlikkMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kepDoboz)).BeginInit();
            this.SuspendLayout();
            // 
            // fajlNyito
            // 
            this.fajlNyito.Filter = "Mindkettő (.xkr, .zip)|*.xkr;*.zip|XKR állomány fájlok (.xkr)|*.xkr|ZIP tömörítet" +
    "t fájlok (.zip)|*.zip";
            this.fajlNyito.Multiselect = true;
            this.fajlNyito.FileOk += new System.ComponentModel.CancelEventHandler(this.FajlNyito_FileOk);
            // 
            // kimenetiHely
            // 
            this.kimenetiHely.Font = new System.Drawing.Font("Ebrima", 9F);
            this.kimenetiHely.Location = new System.Drawing.Point(12, 30);
            this.kimenetiHely.Name = "kimenetiHely";
            this.kimenetiHely.ReadOnly = true;
            this.kimenetiHely.Size = new System.Drawing.Size(462, 24);
            this.kimenetiHely.TabIndex = 8;
            // 
            // Lista
            // 
            this.Lista.AllowDrop = true;
            this.Lista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fejlec_nev,
            this.fejlec_datumMikortol,
            this.fejlec_datumMeddig,
            this.fejlec_napok,
            this.fejlec_adoazonositojel,
            this.fejlec_tajszam,
            this.fejlec_tipus});
            this.Lista.Font = new System.Drawing.Font("Ebrima", 8F);
            this.Lista.FullRowSelect = true;
            this.Lista.GridLines = true;
            this.Lista.HideSelection = false;
            this.Lista.Location = new System.Drawing.Point(12, 174);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(626, 434);
            this.Lista.TabIndex = 16;
            this.Lista.UseCompatibleStateImageBehavior = false;
            this.Lista.View = System.Windows.Forms.View.Details;
            this.Lista.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Lista_ColumnClick);
            this.Lista.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.Lista_ColumnWidthChanged);
            this.Lista.DragDrop += new System.Windows.Forms.DragEventHandler(this.Lista_DragDrop);
            this.Lista.DragEnter += new System.Windows.Forms.DragEventHandler(this.Lista_DragEnter);
            this.Lista.DragLeave += new System.EventHandler(this.Lista_DragLeave);
            this.Lista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Lista_KeyDown);
            this.Lista.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Lista_MouseClick);
            // 
            // fejlec_nev
            // 
            this.fejlec_nev.Text = "Név";
            this.fejlec_nev.Width = 135;
            // 
            // fejlec_datumMikortol
            // 
            this.fejlec_datumMikortol.Text = "Mikortól";
            this.fejlec_datumMikortol.Width = 70;
            // 
            // fejlec_datumMeddig
            // 
            this.fejlec_datumMeddig.Text = "Meddig";
            this.fejlec_datumMeddig.Width = 70;
            // 
            // fejlec_napok
            // 
            this.fejlec_napok.Text = "Napok";
            this.fejlec_napok.Width = 45;
            // 
            // fejlec_adoazonositojel
            // 
            this.fejlec_adoazonositojel.Text = "Adóazonosító-jel";
            this.fejlec_adoazonositojel.Width = 100;
            // 
            // fejlec_tajszam
            // 
            this.fejlec_tajszam.Text = "TAJ-szám";
            this.fejlec_tajszam.Width = 85;
            // 
            // fejlec_tipus
            // 
            this.fejlec_tipus.Text = "Foglalkoztatás típusa";
            this.fejlec_tipus.Width = 115;
            // 
            // jobbKlikkMenu
            // 
            this.jobbKlikkMenu.Font = new System.Drawing.Font("Ebrima", 9F);
            this.jobbKlikkMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masolasMenupont,
            this.torlesMenupont,
            this.mindentKijelolMenupont,
            this.excelKonvertalasMenupont,
            this.mindentExcelbeKonvertalasMenupont});
            this.jobbKlikkMenu.Name = "jobbKlikkMenu";
            this.jobbKlikkMenu.Size = new System.Drawing.Size(316, 114);
            this.jobbKlikkMenu.Text = "Menü";
            // 
            // masolasMenupont
            // 
            this.masolasMenupont.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nevMasolasaMenupont,
            this.mikortolMasolasaMenupont,
            this.meddigMasolasaMenupont,
            this.napokMasolasaMenupont,
            this.adoszamMasolasaMenupont,
            this.tajszamMasolasaMenupont,
            this.mezoMasolasaMenupont});
            this.masolasMenupont.Name = "masolasMenupont";
            this.masolasMenupont.Size = new System.Drawing.Size(315, 22);
            this.masolasMenupont.Text = "Másolás";
            // 
            // nevMasolasaMenupont
            // 
            this.nevMasolasaMenupont.Name = "nevMasolasaMenupont";
            this.nevMasolasaMenupont.Size = new System.Drawing.Size(164, 22);
            this.nevMasolasaMenupont.Text = "Név";
            this.nevMasolasaMenupont.Click += new System.EventHandler(this.NevMasolasaMenupont_Click);
            // 
            // mikortolMasolasaMenupont
            // 
            this.mikortolMasolasaMenupont.Name = "mikortolMasolasaMenupont";
            this.mikortolMasolasaMenupont.Size = new System.Drawing.Size(164, 22);
            this.mikortolMasolasaMenupont.Text = "Mikortól";
            this.mikortolMasolasaMenupont.Click += new System.EventHandler(this.MikortolMasolasaMenupont_Click);
            // 
            // meddigMasolasaMenupont
            // 
            this.meddigMasolasaMenupont.Name = "meddigMasolasaMenupont";
            this.meddigMasolasaMenupont.Size = new System.Drawing.Size(164, 22);
            this.meddigMasolasaMenupont.Text = "Meddig";
            this.meddigMasolasaMenupont.Click += new System.EventHandler(this.MeddigMasolasaMenupont_Click);
            // 
            // napokMasolasaMenupont
            // 
            this.napokMasolasaMenupont.Name = "napokMasolasaMenupont";
            this.napokMasolasaMenupont.Size = new System.Drawing.Size(164, 22);
            this.napokMasolasaMenupont.Text = "Napok";
            this.napokMasolasaMenupont.Click += new System.EventHandler(this.NapokMasolasaMenupont_Click);
            // 
            // adoszamMasolasaMenupont
            // 
            this.adoszamMasolasaMenupont.Name = "adoszamMasolasaMenupont";
            this.adoszamMasolasaMenupont.Size = new System.Drawing.Size(164, 22);
            this.adoszamMasolasaMenupont.Text = "Adóazonosító-jel";
            this.adoszamMasolasaMenupont.Click += new System.EventHandler(this.AdoszamMasolasaMenupont_Click);
            // 
            // tajszamMasolasaMenupont
            // 
            this.tajszamMasolasaMenupont.Name = "tajszamMasolasaMenupont";
            this.tajszamMasolasaMenupont.Size = new System.Drawing.Size(164, 22);
            this.tajszamMasolasaMenupont.Text = "TAJ-szám";
            this.tajszamMasolasaMenupont.Click += new System.EventHandler(this.TajszamMasolasaMenupont_Click);
            // 
            // mezoMasolasaMenupont
            // 
            this.mezoMasolasaMenupont.Name = "mezoMasolasaMenupont";
            this.mezoMasolasaMenupont.Size = new System.Drawing.Size(164, 22);
            this.mezoMasolasaMenupont.Text = "Mező";
            this.mezoMasolasaMenupont.Click += new System.EventHandler(this.TipusMasolasaMenupont_Click);
            // 
            // torlesMenupont
            // 
            this.torlesMenupont.Name = "torlesMenupont";
            this.torlesMenupont.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.torlesMenupont.Size = new System.Drawing.Size(315, 22);
            this.torlesMenupont.Text = "Törlés";
            this.torlesMenupont.Click += new System.EventHandler(this.TorlesMenupont_Click);
            // 
            // mindentKijelolMenupont
            // 
            this.mindentKijelolMenupont.Name = "mindentKijelolMenupont";
            this.mindentKijelolMenupont.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mindentKijelolMenupont.Size = new System.Drawing.Size(315, 22);
            this.mindentKijelolMenupont.Text = "Minden kijelölése";
            this.mindentKijelolMenupont.Click += new System.EventHandler(this.MindenKijelolMenupont_Click);
            // 
            // excelKonvertalasMenupont
            // 
            this.excelKonvertalasMenupont.Name = "excelKonvertalasMenupont";
            this.excelKonvertalasMenupont.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.excelKonvertalasMenupont.Size = new System.Drawing.Size(315, 22);
            this.excelKonvertalasMenupont.Text = "Kiválasztott tételeket Excelbe konvertál";
            this.excelKonvertalasMenupont.Click += new System.EventHandler(this.ExcelKonvertalasMenupont_Click);
            // 
            // mindentExcelbeKonvertalasMenupont
            // 
            this.mindentExcelbeKonvertalasMenupont.Name = "mindentExcelbeKonvertalasMenupont";
            this.mindentExcelbeKonvertalasMenupont.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mindentExcelbeKonvertalasMenupont.Size = new System.Drawing.Size(315, 22);
            this.mindentExcelbeKonvertalasMenupont.Text = "Minden tételt Excelbe konvertál";
            this.mindentExcelbeKonvertalasMenupont.Click += new System.EventHandler(this.MindentExcelbeKonvertalasMenupont_Click);
            // 
            // excelKimenetiHelySzoveg
            // 
            this.excelKimenetiHelySzoveg.AutoSize = true;
            this.excelKimenetiHelySzoveg.Font = new System.Drawing.Font("Ebrima", 9F);
            this.excelKimenetiHelySzoveg.Location = new System.Drawing.Point(9, 9);
            this.excelKimenetiHelySzoveg.Name = "excelKimenetiHelySzoveg";
            this.excelKimenetiHelySzoveg.Size = new System.Drawing.Size(136, 15);
            this.excelKimenetiHelySzoveg.TabIndex = 20;
            this.excelKimenetiHelySzoveg.Text = "Excel-fájl kimeneti helye:";
            // 
            // fajlBehuzasSzoveg
            // 
            this.fajlBehuzasSzoveg.AllowDrop = true;
            this.fajlBehuzasSzoveg.BackColor = System.Drawing.Color.White;
            this.fajlBehuzasSzoveg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fajlBehuzasSzoveg.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fajlBehuzasSzoveg.ForeColor = System.Drawing.Color.Gray;
            this.fajlBehuzasSzoveg.Image = ((System.Drawing.Image)(resources.GetObject("fajlBehuzasSzoveg.Image")));
            this.fajlBehuzasSzoveg.Location = new System.Drawing.Point(12, 174);
            this.fajlBehuzasSzoveg.Name = "fajlBehuzasSzoveg";
            this.fajlBehuzasSzoveg.Size = new System.Drawing.Size(626, 434);
            this.fajlBehuzasSzoveg.TabIndex = 23;
            this.fajlBehuzasSzoveg.Text = "\r\n\r\n\r\nHúzza ide az XKR vagy ZIP fájlokat, vagy kattintson a Fájlok hozzáadása gom" +
    "bra";
            this.fajlBehuzasSzoveg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.fajlBehuzasSzoveg.DragDrop += new System.Windows.Forms.DragEventHandler(this.FajlBehuzasSzoveg_DragDrop);
            this.fajlBehuzasSzoveg.DragEnter += new System.Windows.Forms.DragEventHandler(this.FajlBehuzasSzoveg_DragEnter);
            this.fajlBehuzasSzoveg.DragLeave += new System.EventHandler(this.FajlBehuzasSzoveg_DragLeave);
            // 
            // rendezesGomb
            // 
            this.rendezesGomb.Font = new System.Drawing.Font("Ebrima", 8.5F);
            this.rendezesGomb.Image = global::AccountHelper.Properties.Resources.icon_sort;
            this.rendezesGomb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rendezesGomb.Location = new System.Drawing.Point(346, 108);
            this.rendezesGomb.Name = "rendezesGomb";
            this.rendezesGomb.Size = new System.Drawing.Size(128, 42);
            this.rendezesGomb.TabIndex = 22;
            this.rendezesGomb.Text = "Rendezés: Nincs";
            this.rendezesGomb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rendezesGomb.UseVisualStyleBackColor = true;
            this.rendezesGomb.Click += new System.EventHandler(this.RendezesGomb_Click);
            // 
            // nevjegyGomb
            // 
            this.nevjegyGomb.Font = new System.Drawing.Font("Ebrima", 10F);
            this.nevjegyGomb.Image = global::AccountHelper.Properties.Resources.icon_info;
            this.nevjegyGomb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nevjegyGomb.Location = new System.Drawing.Point(324, 60);
            this.nevjegyGomb.Name = "nevjegyGomb";
            this.nevjegyGomb.Size = new System.Drawing.Size(150, 42);
            this.nevjegyGomb.TabIndex = 21;
            this.nevjegyGomb.Text = "Névjegydoboz";
            this.nevjegyGomb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nevjegyGomb.UseVisualStyleBackColor = true;
            this.nevjegyGomb.Click += new System.EventHandler(this.NevjegyGomb_Click);
            // 
            // kepDoboz
            // 
            this.kepDoboz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kepDoboz.Image = global::AccountHelper.Properties.Resources.xkr_picture;
            this.kepDoboz.Location = new System.Drawing.Point(480, 12);
            this.kepDoboz.Name = "kepDoboz";
            this.kepDoboz.Size = new System.Drawing.Size(158, 156);
            this.kepDoboz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.kepDoboz.TabIndex = 19;
            this.kepDoboz.TabStop = false;
            // 
            // excelKonvertalGomb
            // 
            this.excelKonvertalGomb.Font = new System.Drawing.Font("Ebrima", 8F);
            this.excelKonvertalGomb.Image = global::AccountHelper.Properties.Resources.icon_excel;
            this.excelKonvertalGomb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.excelKonvertalGomb.Location = new System.Drawing.Point(12, 108);
            this.excelKonvertalGomb.Name = "excelKonvertalGomb";
            this.excelKonvertalGomb.Size = new System.Drawing.Size(210, 42);
            this.excelKonvertalGomb.TabIndex = 18;
            this.excelKonvertalGomb.Text = "Minden tétel Excelben kimutatása";
            this.excelKonvertalGomb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.excelKonvertalGomb.UseVisualStyleBackColor = true;
            this.excelKonvertalGomb.Click += new System.EventHandler(this.ExcelKonvertalGomb_Click);
            // 
            // torlesGomb
            // 
            this.torlesGomb.Font = new System.Drawing.Font("Ebrima", 9.5F);
            this.torlesGomb.Image = global::AccountHelper.Properties.Resources.icon_delete;
            this.torlesGomb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.torlesGomb.Location = new System.Drawing.Point(228, 108);
            this.torlesGomb.Name = "torlesGomb";
            this.torlesGomb.Size = new System.Drawing.Size(112, 42);
            this.torlesGomb.TabIndex = 14;
            this.torlesGomb.Text = "Lista űrítése";
            this.torlesGomb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.torlesGomb.UseVisualStyleBackColor = true;
            this.torlesGomb.Click += new System.EventHandler(this.TorlesGomb_Click);
            // 
            // fajlokGomb
            // 
            this.fajlokGomb.Font = new System.Drawing.Font("Ebrima", 10F);
            this.fajlokGomb.Image = global::AccountHelper.Properties.Resources.icon_fileOpen;
            this.fajlokGomb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fajlokGomb.Location = new System.Drawing.Point(168, 60);
            this.fajlokGomb.Name = "fajlokGomb";
            this.fajlokGomb.Size = new System.Drawing.Size(150, 42);
            this.fajlokGomb.TabIndex = 9;
            this.fajlokGomb.Text = "Fájlok hozzáadása";
            this.fajlokGomb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fajlokGomb.UseVisualStyleBackColor = true;
            this.fajlokGomb.Click += new System.EventHandler(this.FajlokGomb_Click);
            // 
            // kimenetGomb
            // 
            this.kimenetGomb.BackColor = System.Drawing.Color.Transparent;
            this.kimenetGomb.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kimenetGomb.Image = ((System.Drawing.Image)(resources.GetObject("kimenetGomb.Image")));
            this.kimenetGomb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kimenetGomb.Location = new System.Drawing.Point(12, 60);
            this.kimenetGomb.Name = "kimenetGomb";
            this.kimenetGomb.Size = new System.Drawing.Size(150, 42);
            this.kimenetGomb.TabIndex = 0;
            this.kimenetGomb.Text = "Kimeneti mappa...";
            this.kimenetGomb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kimenetGomb.UseVisualStyleBackColor = false;
            this.kimenetGomb.Click += new System.EventHandler(this.KimenetGomb_Click);
            // 
            // KezeloAblak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 620);
            this.Controls.Add(this.rendezesGomb);
            this.Controls.Add(this.nevjegyGomb);
            this.Controls.Add(this.excelKimenetiHelySzoveg);
            this.Controls.Add(this.kepDoboz);
            this.Controls.Add(this.excelKonvertalGomb);
            this.Controls.Add(this.torlesGomb);
            this.Controls.Add(this.fajlokGomb);
            this.Controls.Add(this.kimenetiHely);
            this.Controls.Add(this.kimenetGomb);
            this.Controls.Add(this.fajlBehuzasSzoveg);
            this.Controls.Add(this.Lista);
            this.Font = new System.Drawing.Font("Ebrima", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KezeloAblak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XKR Olvasó";
            this.Load += new System.EventHandler(this.KezeloAblak_Load);
            this.jobbKlikkMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kepDoboz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kimenetGomb;
        private System.Windows.Forms.OpenFileDialog fajlNyito;
        private System.Windows.Forms.FolderBrowserDialog helyValaszto;
        private System.Windows.Forms.TextBox kimenetiHely;
        private System.Windows.Forms.Button fajlokGomb;
        private System.Windows.Forms.Button torlesGomb;
        private System.Windows.Forms.ListView Lista;
        private System.Windows.Forms.ColumnHeader fejlec_adoazonositojel;
        private System.Windows.Forms.ColumnHeader fejlec_tipus;
        private System.Windows.Forms.ColumnHeader fejlec_datumMeddig;
        private System.Windows.Forms.ColumnHeader fejlec_tajszam;
        private System.Windows.Forms.ColumnHeader fejlec_napok;
        private System.Windows.Forms.ContextMenuStrip jobbKlikkMenu;
        private System.Windows.Forms.ToolStripMenuItem masolasMenupont;
        private System.Windows.Forms.ToolStripMenuItem nevMasolasaMenupont;
        private System.Windows.Forms.ToolStripMenuItem mikortolMasolasaMenupont;
        private System.Windows.Forms.ToolStripMenuItem meddigMasolasaMenupont;
        private System.Windows.Forms.ToolStripMenuItem napokMasolasaMenupont;
        private System.Windows.Forms.ToolStripMenuItem adoszamMasolasaMenupont;
        private System.Windows.Forms.ToolStripMenuItem tajszamMasolasaMenupont;
        private System.Windows.Forms.ToolStripMenuItem mezoMasolasaMenupont;
        private System.Windows.Forms.ToolStripMenuItem torlesMenupont;
        private System.Windows.Forms.ToolStripMenuItem excelKonvertalasMenupont;
        private System.Windows.Forms.Button excelKonvertalGomb;
        private System.Windows.Forms.PictureBox kepDoboz;
        private System.Windows.Forms.Label excelKimenetiHelySzoveg;
        private System.Windows.Forms.Button nevjegyGomb;
        private System.Windows.Forms.ToolStripMenuItem mindentExcelbeKonvertalasMenupont;
        private System.Windows.Forms.Button rendezesGomb;
        private System.Windows.Forms.ColumnHeader fejlec_nev;
        private System.Windows.Forms.ColumnHeader fejlec_datumMikortol;
        private System.Windows.Forms.Label fajlBehuzasSzoveg;
        private System.Windows.Forms.ToolStripMenuItem mindentKijelolMenupont;
    }
}