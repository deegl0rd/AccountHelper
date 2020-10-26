using System.Windows.Forms;

namespace AccountHelper.src.Nyilvantartas
{
    partial class SzervezetiEgysegSzerkesztesAblak
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

        private void haNemSzam(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SzervezetiEgysegSzerkesztesAblak));
            this.cegNeve_Doboz = new System.Windows.Forms.TextBox();
            this.cegNeve_felirat = new System.Windows.Forms.Label();
            this.szervezetiEgysegSzerkesztesAblakSzoveg = new System.Windows.Forms.Label();
            this.csoport_beallitasok = new System.Windows.Forms.GroupBox();
            this.mkSzunet4_ig_SzamValaszto = new System.Windows.Forms.TextBox();
            this.mkSzunet4_tol_SzamValaszto = new System.Windows.Forms.TextBox();
            this.mkSzunet3_ig_SzamValaszto = new System.Windows.Forms.TextBox();
            this.mkSzunet3_tol_SzamValaszto = new System.Windows.Forms.TextBox();
            this.mkSzunet2_ig_SzamValaszto = new System.Windows.Forms.TextBox();
            this.mkSzunet2_tol_SzamValaszto = new System.Windows.Forms.TextBox();
            this.mkSzunet1_ig_SzamValaszto = new System.Windows.Forms.TextBox();
            this.mkSzunet1_tol_SzamValaszto = new System.Windows.Forms.TextBox();
            this.mkVege_perc_SzamValaszto = new System.Windows.Forms.TextBox();
            this.mkVege_ora_SzamValaszto = new System.Windows.Forms.TextBox();
            this.mkKezdete_perc_SzamValaszto = new System.Windows.Forms.TextBox();
            this.mkKezdete_ora_SzamValaszto = new System.Windows.Forms.TextBox();
            this.pipa_autoNyilvanTartas = new System.Windows.Forms.CheckBox();
            this.pipa_munkakoziSzunetNemResze = new System.Windows.Forms.CheckBox();
            this.autoNyilvanTartasSzoveg = new System.Windows.Forms.Label();
            this.mkSzunetNemReszeSzoveg = new System.Windows.Forms.Label();
            this.szoveg_ora = new System.Windows.Forms.Label();
            this.napiMunkaIdo_SzamValaszto = new System.Windows.Forms.NumericUpDown();
            this.napiMunkaIdoSzoveg = new System.Windows.Forms.Label();
            this.szoveg_perc4 = new System.Windows.Forms.Label();
            this.pipa_szunet4 = new System.Windows.Forms.CheckBox();
            this.mkSzunet4_perc_SzamValaszto = new System.Windows.Forms.NumericUpDown();
            this.szoveg_ig4 = new System.Windows.Forms.Label();
            this.szoveg_tol4 = new System.Windows.Forms.Label();
            this.szoveg_perc3 = new System.Windows.Forms.Label();
            this.pipa_szunet3 = new System.Windows.Forms.CheckBox();
            this.mkSzunet3_perc_SzamValaszto = new System.Windows.Forms.NumericUpDown();
            this.szoveg_ig3 = new System.Windows.Forms.Label();
            this.szoveg_tol3 = new System.Windows.Forms.Label();
            this.szoveg_perc2 = new System.Windows.Forms.Label();
            this.pipa_szunet2 = new System.Windows.Forms.CheckBox();
            this.mkSzunet2_perc_SzamValaszto = new System.Windows.Forms.NumericUpDown();
            this.szoveg_ig2 = new System.Windows.Forms.Label();
            this.szoveg_tol2 = new System.Windows.Forms.Label();
            this.szoveg_perc1 = new System.Windows.Forms.Label();
            this.pipa_szunet1 = new System.Windows.Forms.CheckBox();
            this.mkSzunet1_perc_SzamValaszto = new System.Windows.Forms.NumericUpDown();
            this.szoveg_ig1 = new System.Windows.Forms.Label();
            this.szoveg_tol1 = new System.Windows.Forms.Label();
            this.szoveg_kettospont2 = new System.Windows.Forms.Label();
            this.szoveg_kettospont1 = new System.Windows.Forms.Label();
            this.munkaRendSablon_valaszto = new System.Windows.Forms.ComboBox();
            this.mkSzunetekSzoveg = new System.Windows.Forms.Label();
            this.munkaIdoVegeSzoveg = new System.Windows.Forms.Label();
            this.munkaIdoKezdeteSzoveg = new System.Windows.Forms.Label();
            this.mkRendSablonSzoveg = new System.Windows.Forms.Label();
            this.kotelezoElemek = new System.Windows.Forms.Panel();
            this.megseGomb = new System.Windows.Forms.Button();
            this.mentesGomb = new System.Windows.Forms.Button();
            this.csoport_beallitasok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.napiMunkaIdo_SzamValaszto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mkSzunet4_perc_SzamValaszto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mkSzunet3_perc_SzamValaszto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mkSzunet2_perc_SzamValaszto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mkSzunet1_perc_SzamValaszto)).BeginInit();
            this.kotelezoElemek.SuspendLayout();
            this.SuspendLayout();
            // 
            // cegNeve_Doboz
            // 
            this.cegNeve_Doboz.Location = new System.Drawing.Point(196, 74);
            this.cegNeve_Doboz.MaxLength = 150;
            this.cegNeve_Doboz.Name = "cegNeve_Doboz";
            this.cegNeve_Doboz.Size = new System.Drawing.Size(210, 20);
            this.cegNeve_Doboz.TabIndex = 46;
            // 
            // cegNeve_felirat
            // 
            this.cegNeve_felirat.AutoSize = true;
            this.cegNeve_felirat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cegNeve_felirat.Location = new System.Drawing.Point(12, 75);
            this.cegNeve_felirat.Name = "cegNeve_felirat";
            this.cegNeve_felirat.Size = new System.Drawing.Size(178, 16);
            this.cegNeve_felirat.TabIndex = 45;
            this.cegNeve_felirat.Text = "Szervezeti egység neve:";
            // 
            // szervezetiEgysegSzerkesztesAblakSzoveg
            // 
            this.szervezetiEgysegSzerkesztesAblakSzoveg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szervezetiEgysegSzerkesztesAblakSzoveg.Location = new System.Drawing.Point(12, 9);
            this.szervezetiEgysegSzerkesztesAblakSzoveg.Name = "szervezetiEgysegSzerkesztesAblakSzoveg";
            this.szervezetiEgysegSzerkesztesAblakSzoveg.Size = new System.Drawing.Size(505, 24);
            this.szervezetiEgysegSzerkesztesAblakSzoveg.TabIndex = 42;
            this.szervezetiEgysegSzerkesztesAblakSzoveg.Text = "<Szervezeti egység szerkesztés ablak funkció>";
            this.szervezetiEgysegSzerkesztesAblakSzoveg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // csoport_beallitasok
            // 
            this.csoport_beallitasok.BackColor = System.Drawing.Color.White;
            this.csoport_beallitasok.Controls.Add(this.munkaRendSablon_valaszto);
            this.csoport_beallitasok.Controls.Add(this.mkRendSablonSzoveg);
            this.csoport_beallitasok.Controls.Add(this.kotelezoElemek);
            this.csoport_beallitasok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.csoport_beallitasok.Location = new System.Drawing.Point(12, 100);
            this.csoport_beallitasok.Name = "csoport_beallitasok";
            this.csoport_beallitasok.Size = new System.Drawing.Size(492, 417);
            this.csoport_beallitasok.TabIndex = 47;
            this.csoport_beallitasok.TabStop = false;
            this.csoport_beallitasok.Text = "Beállítások";
            // 
            // mkSzunet4_ig_SzamValaszto
            // 
            this.mkSzunet4_ig_SzamValaszto.Location = new System.Drawing.Point(283, 174);
            this.mkSzunet4_ig_SzamValaszto.MaxLength = 2;
            this.mkSzunet4_ig_SzamValaszto.Name = "mkSzunet4_ig_SzamValaszto";
            this.mkSzunet4_ig_SzamValaszto.Size = new System.Drawing.Size(48, 24);
            this.mkSzunet4_ig_SzamValaszto.TabIndex = 68;
            // 
            // mkSzunet4_tol_SzamValaszto
            // 
            this.mkSzunet4_tol_SzamValaszto.Location = new System.Drawing.Point(194, 174);
            this.mkSzunet4_tol_SzamValaszto.MaxLength = 2;
            this.mkSzunet4_tol_SzamValaszto.Name = "mkSzunet4_tol_SzamValaszto";
            this.mkSzunet4_tol_SzamValaszto.Size = new System.Drawing.Size(48, 24);
            this.mkSzunet4_tol_SzamValaszto.TabIndex = 67;
            // 
            // mkSzunet3_ig_SzamValaszto
            // 
            this.mkSzunet3_ig_SzamValaszto.Location = new System.Drawing.Point(283, 145);
            this.mkSzunet3_ig_SzamValaszto.MaxLength = 2;
            this.mkSzunet3_ig_SzamValaszto.Name = "mkSzunet3_ig_SzamValaszto";
            this.mkSzunet3_ig_SzamValaszto.Size = new System.Drawing.Size(48, 24);
            this.mkSzunet3_ig_SzamValaszto.TabIndex = 66;
            // 
            // mkSzunet3_tol_SzamValaszto
            // 
            this.mkSzunet3_tol_SzamValaszto.Location = new System.Drawing.Point(194, 145);
            this.mkSzunet3_tol_SzamValaszto.MaxLength = 2;
            this.mkSzunet3_tol_SzamValaszto.Name = "mkSzunet3_tol_SzamValaszto";
            this.mkSzunet3_tol_SzamValaszto.Size = new System.Drawing.Size(48, 24);
            this.mkSzunet3_tol_SzamValaszto.TabIndex = 65;
            // 
            // mkSzunet2_ig_SzamValaszto
            // 
            this.mkSzunet2_ig_SzamValaszto.Location = new System.Drawing.Point(283, 115);
            this.mkSzunet2_ig_SzamValaszto.MaxLength = 2;
            this.mkSzunet2_ig_SzamValaszto.Name = "mkSzunet2_ig_SzamValaszto";
            this.mkSzunet2_ig_SzamValaszto.Size = new System.Drawing.Size(48, 24);
            this.mkSzunet2_ig_SzamValaszto.TabIndex = 64;
            // 
            // mkSzunet2_tol_SzamValaszto
            // 
            this.mkSzunet2_tol_SzamValaszto.Location = new System.Drawing.Point(194, 115);
            this.mkSzunet2_tol_SzamValaszto.MaxLength = 2;
            this.mkSzunet2_tol_SzamValaszto.Name = "mkSzunet2_tol_SzamValaszto";
            this.mkSzunet2_tol_SzamValaszto.Size = new System.Drawing.Size(48, 24);
            this.mkSzunet2_tol_SzamValaszto.TabIndex = 63;
            // 
            // mkSzunet1_ig_SzamValaszto
            // 
            this.mkSzunet1_ig_SzamValaszto.Location = new System.Drawing.Point(283, 85);
            this.mkSzunet1_ig_SzamValaszto.MaxLength = 2;
            this.mkSzunet1_ig_SzamValaszto.Name = "mkSzunet1_ig_SzamValaszto";
            this.mkSzunet1_ig_SzamValaszto.Size = new System.Drawing.Size(48, 24);
            this.mkSzunet1_ig_SzamValaszto.TabIndex = 62;
            // 
            // mkSzunet1_tol_SzamValaszto
            // 
            this.mkSzunet1_tol_SzamValaszto.Location = new System.Drawing.Point(194, 85);
            this.mkSzunet1_tol_SzamValaszto.MaxLength = 2;
            this.mkSzunet1_tol_SzamValaszto.Name = "mkSzunet1_tol_SzamValaszto";
            this.mkSzunet1_tol_SzamValaszto.Size = new System.Drawing.Size(48, 24);
            this.mkSzunet1_tol_SzamValaszto.TabIndex = 61;
            // 
            // mkVege_perc_SzamValaszto
            // 
            this.mkVege_perc_SzamValaszto.Location = new System.Drawing.Point(237, 45);
            this.mkVege_perc_SzamValaszto.MaxLength = 2;
            this.mkVege_perc_SzamValaszto.Name = "mkVege_perc_SzamValaszto";
            this.mkVege_perc_SzamValaszto.Size = new System.Drawing.Size(48, 24);
            this.mkVege_perc_SzamValaszto.TabIndex = 60;
            // 
            // mkVege_ora_SzamValaszto
            // 
            this.mkVege_ora_SzamValaszto.Location = new System.Drawing.Point(164, 45);
            this.mkVege_ora_SzamValaszto.MaxLength = 2;
            this.mkVege_ora_SzamValaszto.Name = "mkVege_ora_SzamValaszto";
            this.mkVege_ora_SzamValaszto.Size = new System.Drawing.Size(48, 24);
            this.mkVege_ora_SzamValaszto.TabIndex = 59;
            // 
            // mkKezdete_perc_SzamValaszto
            // 
            this.mkKezdete_perc_SzamValaszto.Location = new System.Drawing.Point(237, 6);
            this.mkKezdete_perc_SzamValaszto.MaxLength = 2;
            this.mkKezdete_perc_SzamValaszto.Name = "mkKezdete_perc_SzamValaszto";
            this.mkKezdete_perc_SzamValaszto.Size = new System.Drawing.Size(48, 24);
            this.mkKezdete_perc_SzamValaszto.TabIndex = 58;
            // 
            // mkKezdete_ora_SzamValaszto
            // 
            this.mkKezdete_ora_SzamValaszto.Location = new System.Drawing.Point(164, 6);
            this.mkKezdete_ora_SzamValaszto.MaxLength = 2;
            this.mkKezdete_ora_SzamValaszto.Name = "mkKezdete_ora_SzamValaszto";
            this.mkKezdete_ora_SzamValaszto.Size = new System.Drawing.Size(48, 24);
            this.mkKezdete_ora_SzamValaszto.TabIndex = 57;
            // 
            // pipa_autoNyilvanTartas
            // 
            this.pipa_autoNyilvanTartas.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pipa_autoNyilvanTartas.Location = new System.Drawing.Point(291, 303);
            this.pipa_autoNyilvanTartas.Name = "pipa_autoNyilvanTartas";
            this.pipa_autoNyilvanTartas.Size = new System.Drawing.Size(24, 24);
            this.pipa_autoNyilvanTartas.TabIndex = 56;
            this.pipa_autoNyilvanTartas.UseVisualStyleBackColor = true;
            // 
            // pipa_munkakoziSzunetNemResze
            // 
            this.pipa_munkakoziSzunetNemResze.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pipa_munkakoziSzunetNemResze.Location = new System.Drawing.Point(291, 273);
            this.pipa_munkakoziSzunetNemResze.Name = "pipa_munkakoziSzunetNemResze";
            this.pipa_munkakoziSzunetNemResze.Size = new System.Drawing.Size(24, 24);
            this.pipa_munkakoziSzunetNemResze.TabIndex = 55;
            this.pipa_munkakoziSzunetNemResze.UseVisualStyleBackColor = true;
            // 
            // autoNyilvanTartasSzoveg
            // 
            this.autoNyilvanTartasSzoveg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.autoNyilvanTartasSzoveg.Location = new System.Drawing.Point(3, 307);
            this.autoNyilvanTartasSzoveg.Name = "autoNyilvanTartasSzoveg";
            this.autoNyilvanTartasSzoveg.Size = new System.Drawing.Size(282, 20);
            this.autoNyilvanTartasSzoveg.TabIndex = 54;
            this.autoNyilvanTartasSzoveg.Text = "Automatikus nyilvántartás vezetés:";
            // 
            // mkSzunetNemReszeSzoveg
            // 
            this.mkSzunetNemReszeSzoveg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mkSzunetNemReszeSzoveg.Location = new System.Drawing.Point(3, 277);
            this.mkSzunetNemReszeSzoveg.Name = "mkSzunetNemReszeSzoveg";
            this.mkSzunetNemReszeSzoveg.Size = new System.Drawing.Size(282, 20);
            this.mkSzunetNemReszeSzoveg.TabIndex = 53;
            this.mkSzunetNemReszeSzoveg.Text = "Munkaközi szünet nem része a munkaidőnek:\r\n";
            // 
            // szoveg_ora
            // 
            this.szoveg_ora.AutoSize = true;
            this.szoveg_ora.Location = new System.Drawing.Point(249, 232);
            this.szoveg_ora.Name = "szoveg_ora";
            this.szoveg_ora.Size = new System.Drawing.Size(30, 18);
            this.szoveg_ora.TabIndex = 52;
            this.szoveg_ora.Text = "óra";
            // 
            // napiMunkaIdo_SzamValaszto
            // 
            this.napiMunkaIdo_SzamValaszto.Location = new System.Drawing.Point(194, 228);
            this.napiMunkaIdo_SzamValaszto.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.napiMunkaIdo_SzamValaszto.Name = "napiMunkaIdo_SzamValaszto";
            this.napiMunkaIdo_SzamValaszto.Size = new System.Drawing.Size(48, 24);
            this.napiMunkaIdo_SzamValaszto.TabIndex = 51;
            this.napiMunkaIdo_SzamValaszto.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // napiMunkaIdoSzoveg
            // 
            this.napiMunkaIdoSzoveg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.napiMunkaIdoSzoveg.Location = new System.Drawing.Point(3, 232);
            this.napiMunkaIdoSzoveg.Name = "napiMunkaIdoSzoveg";
            this.napiMunkaIdoSzoveg.Size = new System.Drawing.Size(185, 20);
            this.napiMunkaIdoSzoveg.TabIndex = 50;
            this.napiMunkaIdoSzoveg.Text = "Megáll. napi munkaidő:";
            // 
            // szoveg_perc4
            // 
            this.szoveg_perc4.AutoSize = true;
            this.szoveg_perc4.Location = new System.Drawing.Point(418, 178);
            this.szoveg_perc4.Name = "szoveg_perc4";
            this.szoveg_perc4.Size = new System.Drawing.Size(37, 18);
            this.szoveg_perc4.TabIndex = 49;
            this.szoveg_perc4.Text = "perc";
            // 
            // pipa_szunet4
            // 
            this.pipa_szunet4.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pipa_szunet4.Location = new System.Drawing.Point(164, 175);
            this.pipa_szunet4.Name = "pipa_szunet4";
            this.pipa_szunet4.Size = new System.Drawing.Size(24, 24);
            this.pipa_szunet4.TabIndex = 48;
            this.pipa_szunet4.UseVisualStyleBackColor = true;
            // 
            // mkSzunet4_perc_SzamValaszto
            // 
            this.mkSzunet4_perc_SzamValaszto.Location = new System.Drawing.Point(364, 175);
            this.mkSzunet4_perc_SzamValaszto.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.mkSzunet4_perc_SzamValaszto.Name = "mkSzunet4_perc_SzamValaszto";
            this.mkSzunet4_perc_SzamValaszto.Size = new System.Drawing.Size(48, 24);
            this.mkSzunet4_perc_SzamValaszto.TabIndex = 47;
            this.mkSzunet4_perc_SzamValaszto.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // szoveg_ig4
            // 
            this.szoveg_ig4.AutoSize = true;
            this.szoveg_ig4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szoveg_ig4.Location = new System.Drawing.Point(337, 176);
            this.szoveg_ig4.Name = "szoveg_ig4";
            this.szoveg_ig4.Size = new System.Drawing.Size(25, 20);
            this.szoveg_ig4.TabIndex = 46;
            this.szoveg_ig4.Text = "-ig";
            // 
            // szoveg_tol4
            // 
            this.szoveg_tol4.AutoSize = true;
            this.szoveg_tol4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szoveg_tol4.Location = new System.Drawing.Point(248, 176);
            this.szoveg_tol4.Name = "szoveg_tol4";
            this.szoveg_tol4.Size = new System.Drawing.Size(29, 20);
            this.szoveg_tol4.TabIndex = 45;
            this.szoveg_tol4.Text = "-től";
            // 
            // szoveg_perc3
            // 
            this.szoveg_perc3.AutoSize = true;
            this.szoveg_perc3.Location = new System.Drawing.Point(418, 148);
            this.szoveg_perc3.Name = "szoveg_perc3";
            this.szoveg_perc3.Size = new System.Drawing.Size(37, 18);
            this.szoveg_perc3.TabIndex = 42;
            this.szoveg_perc3.Text = "perc";
            // 
            // pipa_szunet3
            // 
            this.pipa_szunet3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pipa_szunet3.Location = new System.Drawing.Point(164, 145);
            this.pipa_szunet3.Name = "pipa_szunet3";
            this.pipa_szunet3.Size = new System.Drawing.Size(24, 24);
            this.pipa_szunet3.TabIndex = 41;
            this.pipa_szunet3.UseVisualStyleBackColor = true;
            // 
            // mkSzunet3_perc_SzamValaszto
            // 
            this.mkSzunet3_perc_SzamValaszto.Location = new System.Drawing.Point(364, 145);
            this.mkSzunet3_perc_SzamValaszto.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.mkSzunet3_perc_SzamValaszto.Name = "mkSzunet3_perc_SzamValaszto";
            this.mkSzunet3_perc_SzamValaszto.Size = new System.Drawing.Size(48, 24);
            this.mkSzunet3_perc_SzamValaszto.TabIndex = 40;
            this.mkSzunet3_perc_SzamValaszto.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // szoveg_ig3
            // 
            this.szoveg_ig3.AutoSize = true;
            this.szoveg_ig3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szoveg_ig3.Location = new System.Drawing.Point(337, 146);
            this.szoveg_ig3.Name = "szoveg_ig3";
            this.szoveg_ig3.Size = new System.Drawing.Size(25, 20);
            this.szoveg_ig3.TabIndex = 39;
            this.szoveg_ig3.Text = "-ig";
            // 
            // szoveg_tol3
            // 
            this.szoveg_tol3.AutoSize = true;
            this.szoveg_tol3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szoveg_tol3.Location = new System.Drawing.Point(248, 146);
            this.szoveg_tol3.Name = "szoveg_tol3";
            this.szoveg_tol3.Size = new System.Drawing.Size(29, 20);
            this.szoveg_tol3.TabIndex = 38;
            this.szoveg_tol3.Text = "-től";
            // 
            // szoveg_perc2
            // 
            this.szoveg_perc2.AutoSize = true;
            this.szoveg_perc2.Location = new System.Drawing.Point(418, 118);
            this.szoveg_perc2.Name = "szoveg_perc2";
            this.szoveg_perc2.Size = new System.Drawing.Size(37, 18);
            this.szoveg_perc2.TabIndex = 35;
            this.szoveg_perc2.Text = "perc";
            // 
            // pipa_szunet2
            // 
            this.pipa_szunet2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pipa_szunet2.Location = new System.Drawing.Point(164, 115);
            this.pipa_szunet2.Name = "pipa_szunet2";
            this.pipa_szunet2.Size = new System.Drawing.Size(24, 24);
            this.pipa_szunet2.TabIndex = 34;
            this.pipa_szunet2.UseVisualStyleBackColor = true;
            // 
            // mkSzunet2_perc_SzamValaszto
            // 
            this.mkSzunet2_perc_SzamValaszto.Location = new System.Drawing.Point(364, 115);
            this.mkSzunet2_perc_SzamValaszto.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.mkSzunet2_perc_SzamValaszto.Name = "mkSzunet2_perc_SzamValaszto";
            this.mkSzunet2_perc_SzamValaszto.Size = new System.Drawing.Size(48, 24);
            this.mkSzunet2_perc_SzamValaszto.TabIndex = 33;
            this.mkSzunet2_perc_SzamValaszto.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // szoveg_ig2
            // 
            this.szoveg_ig2.AutoSize = true;
            this.szoveg_ig2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szoveg_ig2.Location = new System.Drawing.Point(337, 116);
            this.szoveg_ig2.Name = "szoveg_ig2";
            this.szoveg_ig2.Size = new System.Drawing.Size(25, 20);
            this.szoveg_ig2.TabIndex = 32;
            this.szoveg_ig2.Text = "-ig";
            // 
            // szoveg_tol2
            // 
            this.szoveg_tol2.AutoSize = true;
            this.szoveg_tol2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szoveg_tol2.Location = new System.Drawing.Point(248, 116);
            this.szoveg_tol2.Name = "szoveg_tol2";
            this.szoveg_tol2.Size = new System.Drawing.Size(29, 20);
            this.szoveg_tol2.TabIndex = 31;
            this.szoveg_tol2.Text = "-től";
            // 
            // szoveg_perc1
            // 
            this.szoveg_perc1.AutoSize = true;
            this.szoveg_perc1.Location = new System.Drawing.Point(418, 88);
            this.szoveg_perc1.Name = "szoveg_perc1";
            this.szoveg_perc1.Size = new System.Drawing.Size(37, 18);
            this.szoveg_perc1.TabIndex = 28;
            this.szoveg_perc1.Text = "perc";
            // 
            // pipa_szunet1
            // 
            this.pipa_szunet1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pipa_szunet1.Location = new System.Drawing.Point(164, 85);
            this.pipa_szunet1.Name = "pipa_szunet1";
            this.pipa_szunet1.Size = new System.Drawing.Size(24, 24);
            this.pipa_szunet1.TabIndex = 27;
            this.pipa_szunet1.UseVisualStyleBackColor = true;
            // 
            // mkSzunet1_perc_SzamValaszto
            // 
            this.mkSzunet1_perc_SzamValaszto.Location = new System.Drawing.Point(364, 85);
            this.mkSzunet1_perc_SzamValaszto.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.mkSzunet1_perc_SzamValaszto.Name = "mkSzunet1_perc_SzamValaszto";
            this.mkSzunet1_perc_SzamValaszto.Size = new System.Drawing.Size(48, 24);
            this.mkSzunet1_perc_SzamValaszto.TabIndex = 26;
            this.mkSzunet1_perc_SzamValaszto.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // szoveg_ig1
            // 
            this.szoveg_ig1.AutoSize = true;
            this.szoveg_ig1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szoveg_ig1.Location = new System.Drawing.Point(337, 86);
            this.szoveg_ig1.Name = "szoveg_ig1";
            this.szoveg_ig1.Size = new System.Drawing.Size(25, 20);
            this.szoveg_ig1.TabIndex = 25;
            this.szoveg_ig1.Text = "-ig";
            // 
            // szoveg_tol1
            // 
            this.szoveg_tol1.AutoSize = true;
            this.szoveg_tol1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szoveg_tol1.Location = new System.Drawing.Point(248, 86);
            this.szoveg_tol1.Name = "szoveg_tol1";
            this.szoveg_tol1.Size = new System.Drawing.Size(29, 20);
            this.szoveg_tol1.TabIndex = 24;
            this.szoveg_tol1.Text = "-től";
            // 
            // szoveg_kettospont2
            // 
            this.szoveg_kettospont2.AutoSize = true;
            this.szoveg_kettospont2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szoveg_kettospont2.Location = new System.Drawing.Point(218, 47);
            this.szoveg_kettospont2.Name = "szoveg_kettospont2";
            this.szoveg_kettospont2.Size = new System.Drawing.Size(13, 20);
            this.szoveg_kettospont2.TabIndex = 21;
            this.szoveg_kettospont2.Text = ":";
            // 
            // szoveg_kettospont1
            // 
            this.szoveg_kettospont1.AutoSize = true;
            this.szoveg_kettospont1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szoveg_kettospont1.Location = new System.Drawing.Point(218, 8);
            this.szoveg_kettospont1.Name = "szoveg_kettospont1";
            this.szoveg_kettospont1.Size = new System.Drawing.Size(13, 20);
            this.szoveg_kettospont1.TabIndex = 18;
            this.szoveg_kettospont1.Text = ":";
            // 
            // munkaRendSablon_valaszto
            // 
            this.munkaRendSablon_valaszto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.munkaRendSablon_valaszto.FormattingEnabled = true;
            this.munkaRendSablon_valaszto.Items.AddRange(new object[] {
            "általános",
            "kötetlen",
            "munkaidőkeret"});
            this.munkaRendSablon_valaszto.Location = new System.Drawing.Point(183, 36);
            this.munkaRendSablon_valaszto.Name = "munkaRendSablon_valaszto";
            this.munkaRendSablon_valaszto.Size = new System.Drawing.Size(137, 26);
            this.munkaRendSablon_valaszto.TabIndex = 15;
            this.munkaRendSablon_valaszto.SelectedValueChanged += new System.EventHandler(this.MunkaRendSablon_valaszto_SelectedValueChanged);
            // 
            // mkSzunetekSzoveg
            // 
            this.mkSzunetekSzoveg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mkSzunetekSzoveg.Location = new System.Drawing.Point(3, 89);
            this.mkSzunetekSzoveg.Name = "mkSzunetekSzoveg";
            this.mkSzunetekSzoveg.Size = new System.Drawing.Size(155, 36);
            this.mkSzunetekSzoveg.TabIndex = 13;
            this.mkSzunetekSzoveg.Text = "Munkaközi szünetek:";
            // 
            // munkaIdoVegeSzoveg
            // 
            this.munkaIdoVegeSzoveg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.munkaIdoVegeSzoveg.Location = new System.Drawing.Point(3, 50);
            this.munkaIdoVegeSzoveg.Name = "munkaIdoVegeSzoveg";
            this.munkaIdoVegeSzoveg.Size = new System.Drawing.Size(155, 26);
            this.munkaIdoVegeSzoveg.TabIndex = 10;
            this.munkaIdoVegeSzoveg.Text = "Munkaidő vége:";
            // 
            // munkaIdoKezdeteSzoveg
            // 
            this.munkaIdoKezdeteSzoveg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.munkaIdoKezdeteSzoveg.Location = new System.Drawing.Point(3, 11);
            this.munkaIdoKezdeteSzoveg.Name = "munkaIdoKezdeteSzoveg";
            this.munkaIdoKezdeteSzoveg.Size = new System.Drawing.Size(155, 26);
            this.munkaIdoKezdeteSzoveg.TabIndex = 7;
            this.munkaIdoKezdeteSzoveg.Text = "Munkaidő kezdete:";
            // 
            // mkRendSablonSzoveg
            // 
            this.mkRendSablonSzoveg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mkRendSablonSzoveg.Location = new System.Drawing.Point(22, 41);
            this.mkRendSablonSzoveg.Name = "mkRendSablonSzoveg";
            this.mkRendSablonSzoveg.Size = new System.Drawing.Size(155, 24);
            this.mkRendSablonSzoveg.TabIndex = 4;
            this.mkRendSablonSzoveg.Text = "Munkarend sablon:";
            // 
            // kotelezoElemek
            // 
            this.kotelezoElemek.Controls.Add(this.mkSzunet4_ig_SzamValaszto);
            this.kotelezoElemek.Controls.Add(this.munkaIdoKezdeteSzoveg);
            this.kotelezoElemek.Controls.Add(this.mkSzunet4_tol_SzamValaszto);
            this.kotelezoElemek.Controls.Add(this.munkaIdoVegeSzoveg);
            this.kotelezoElemek.Controls.Add(this.mkSzunet3_ig_SzamValaszto);
            this.kotelezoElemek.Controls.Add(this.mkSzunetekSzoveg);
            this.kotelezoElemek.Controls.Add(this.mkSzunet3_tol_SzamValaszto);
            this.kotelezoElemek.Controls.Add(this.szoveg_kettospont1);
            this.kotelezoElemek.Controls.Add(this.mkSzunet2_ig_SzamValaszto);
            this.kotelezoElemek.Controls.Add(this.szoveg_kettospont2);
            this.kotelezoElemek.Controls.Add(this.mkSzunet2_tol_SzamValaszto);
            this.kotelezoElemek.Controls.Add(this.szoveg_tol1);
            this.kotelezoElemek.Controls.Add(this.mkSzunet1_ig_SzamValaszto);
            this.kotelezoElemek.Controls.Add(this.szoveg_ig1);
            this.kotelezoElemek.Controls.Add(this.mkSzunet1_tol_SzamValaszto);
            this.kotelezoElemek.Controls.Add(this.mkSzunet1_perc_SzamValaszto);
            this.kotelezoElemek.Controls.Add(this.mkVege_perc_SzamValaszto);
            this.kotelezoElemek.Controls.Add(this.pipa_szunet1);
            this.kotelezoElemek.Controls.Add(this.mkVege_ora_SzamValaszto);
            this.kotelezoElemek.Controls.Add(this.szoveg_perc1);
            this.kotelezoElemek.Controls.Add(this.mkKezdete_perc_SzamValaszto);
            this.kotelezoElemek.Controls.Add(this.szoveg_tol2);
            this.kotelezoElemek.Controls.Add(this.mkKezdete_ora_SzamValaszto);
            this.kotelezoElemek.Controls.Add(this.szoveg_ig2);
            this.kotelezoElemek.Controls.Add(this.pipa_autoNyilvanTartas);
            this.kotelezoElemek.Controls.Add(this.mkSzunet2_perc_SzamValaszto);
            this.kotelezoElemek.Controls.Add(this.pipa_munkakoziSzunetNemResze);
            this.kotelezoElemek.Controls.Add(this.pipa_szunet2);
            this.kotelezoElemek.Controls.Add(this.autoNyilvanTartasSzoveg);
            this.kotelezoElemek.Controls.Add(this.szoveg_perc2);
            this.kotelezoElemek.Controls.Add(this.mkSzunetNemReszeSzoveg);
            this.kotelezoElemek.Controls.Add(this.szoveg_tol3);
            this.kotelezoElemek.Controls.Add(this.szoveg_ora);
            this.kotelezoElemek.Controls.Add(this.szoveg_ig3);
            this.kotelezoElemek.Controls.Add(this.napiMunkaIdo_SzamValaszto);
            this.kotelezoElemek.Controls.Add(this.mkSzunet3_perc_SzamValaszto);
            this.kotelezoElemek.Controls.Add(this.napiMunkaIdoSzoveg);
            this.kotelezoElemek.Controls.Add(this.pipa_szunet3);
            this.kotelezoElemek.Controls.Add(this.szoveg_perc4);
            this.kotelezoElemek.Controls.Add(this.szoveg_perc3);
            this.kotelezoElemek.Controls.Add(this.pipa_szunet4);
            this.kotelezoElemek.Controls.Add(this.szoveg_tol4);
            this.kotelezoElemek.Controls.Add(this.mkSzunet4_perc_SzamValaszto);
            this.kotelezoElemek.Controls.Add(this.szoveg_ig4);
            this.kotelezoElemek.Location = new System.Drawing.Point(19, 68);
            this.kotelezoElemek.Name = "kotelezoElemek";
            this.kotelezoElemek.Size = new System.Drawing.Size(461, 343);
            this.kotelezoElemek.TabIndex = 69;
            this.kotelezoElemek.Visible = false;
            // 
            // megseGomb
            // 
            this.megseGomb.BackColor = System.Drawing.Color.Transparent;
            this.megseGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.megseGomb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.megseGomb.Location = new System.Drawing.Point(119, 523);
            this.megseGomb.Name = "megseGomb";
            this.megseGomb.Size = new System.Drawing.Size(63, 29);
            this.megseGomb.TabIndex = 70;
            this.megseGomb.Text = "Mégse";
            this.megseGomb.UseVisualStyleBackColor = false;
            this.megseGomb.Click += new System.EventHandler(this.MegseGomb_Click);
            // 
            // mentesGomb
            // 
            this.mentesGomb.BackColor = System.Drawing.Color.DodgerBlue;
            this.mentesGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mentesGomb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mentesGomb.Location = new System.Drawing.Point(12, 523);
            this.mentesGomb.Name = "mentesGomb";
            this.mentesGomb.Size = new System.Drawing.Size(101, 29);
            this.mentesGomb.TabIndex = 69;
            this.mentesGomb.Text = "Mentés";
            this.mentesGomb.UseVisualStyleBackColor = false;
            this.mentesGomb.Click += new System.EventHandler(this.MentesGomb_Click);
            // 
            // SzervezetiEgysegSzerkesztesAblak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(516, 564);
            this.Controls.Add(this.megseGomb);
            this.Controls.Add(this.mentesGomb);
            this.Controls.Add(this.szervezetiEgysegSzerkesztesAblakSzoveg);
            this.Controls.Add(this.csoport_beallitasok);
            this.Controls.Add(this.cegNeve_Doboz);
            this.Controls.Add(this.cegNeve_felirat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SzervezetiEgysegSzerkesztesAblak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "<Szervezeti egység szerkesztés ablak funkció>";
            this.Load += new System.EventHandler(this.SzervezetiEgysegSzerkesztesAblak_Load);
            this.csoport_beallitasok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.napiMunkaIdo_SzamValaszto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mkSzunet4_perc_SzamValaszto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mkSzunet3_perc_SzamValaszto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mkSzunet2_perc_SzamValaszto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mkSzunet1_perc_SzamValaszto)).EndInit();
            this.kotelezoElemek.ResumeLayout(false);
            this.kotelezoElemek.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cegNeve_Doboz;
        private System.Windows.Forms.Label cegNeve_felirat;
        private System.Windows.Forms.Label szervezetiEgysegSzerkesztesAblakSzoveg;
        private System.Windows.Forms.GroupBox csoport_beallitasok;
        private System.Windows.Forms.Label szoveg_ig1;
        private System.Windows.Forms.Label szoveg_tol1;
        private System.Windows.Forms.Label szoveg_kettospont2;
        private System.Windows.Forms.Label szoveg_kettospont1;
        private System.Windows.Forms.ComboBox munkaRendSablon_valaszto;
        private System.Windows.Forms.Label mkSzunetekSzoveg;
        private System.Windows.Forms.Label munkaIdoVegeSzoveg;
        private System.Windows.Forms.Label munkaIdoKezdeteSzoveg;
        private System.Windows.Forms.Label mkRendSablonSzoveg;
        private System.Windows.Forms.NumericUpDown mkSzunet1_perc_SzamValaszto;
        private System.Windows.Forms.Label szoveg_perc4;
        private System.Windows.Forms.CheckBox pipa_szunet4;
        private System.Windows.Forms.NumericUpDown mkSzunet4_perc_SzamValaszto;
        private System.Windows.Forms.Label szoveg_ig4;
        private System.Windows.Forms.Label szoveg_tol4;
        private System.Windows.Forms.Label szoveg_perc3;
        private System.Windows.Forms.CheckBox pipa_szunet3;
        private System.Windows.Forms.NumericUpDown mkSzunet3_perc_SzamValaszto;
        private System.Windows.Forms.Label szoveg_ig3;
        private System.Windows.Forms.Label szoveg_tol3;
        private System.Windows.Forms.Label szoveg_perc2;
        private System.Windows.Forms.CheckBox pipa_szunet2;
        private System.Windows.Forms.NumericUpDown mkSzunet2_perc_SzamValaszto;
        private System.Windows.Forms.Label szoveg_ig2;
        private System.Windows.Forms.Label szoveg_tol2;
        private System.Windows.Forms.Label szoveg_perc1;
        private System.Windows.Forms.CheckBox pipa_szunet1;
        private System.Windows.Forms.Label szoveg_ora;
        private System.Windows.Forms.NumericUpDown napiMunkaIdo_SzamValaszto;
        private System.Windows.Forms.Label napiMunkaIdoSzoveg;
        private System.Windows.Forms.CheckBox pipa_autoNyilvanTartas;
        private System.Windows.Forms.CheckBox pipa_munkakoziSzunetNemResze;
        private System.Windows.Forms.Label autoNyilvanTartasSzoveg;
        private System.Windows.Forms.Label mkSzunetNemReszeSzoveg;
        private System.Windows.Forms.Button megseGomb;
        private System.Windows.Forms.Button mentesGomb;
        private TextBox mkVege_perc_SzamValaszto;
        private TextBox mkVege_ora_SzamValaszto;
        private TextBox mkKezdete_perc_SzamValaszto;
        private TextBox mkKezdete_ora_SzamValaszto;
        private TextBox mkSzunet4_ig_SzamValaszto;
        private TextBox mkSzunet4_tol_SzamValaszto;
        private TextBox mkSzunet3_ig_SzamValaszto;
        private TextBox mkSzunet3_tol_SzamValaszto;
        private TextBox mkSzunet2_ig_SzamValaszto;
        private TextBox mkSzunet2_tol_SzamValaszto;
        private TextBox mkSzunet1_ig_SzamValaszto;
        private TextBox mkSzunet1_tol_SzamValaszto;
        private Panel kotelezoElemek;
    }
}