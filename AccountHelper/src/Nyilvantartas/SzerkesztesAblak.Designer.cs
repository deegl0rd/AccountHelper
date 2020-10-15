using System;
using System.Windows.Forms;

namespace AccountHelper.src.Nyilvantartas
{
    partial class SzerkesztesAblak
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
            } else
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SzerkesztesAblak));
            this.MegseGomb = new System.Windows.Forms.Button();
            this.mentesGomb = new System.Windows.Forms.Button();
            this.vonal5 = new System.Windows.Forms.Label();
            this.cegTelefonszam_doboz2 = new System.Windows.Forms.TextBox();
            this.cegTelefonszam_doboz1 = new System.Windows.Forms.TextBox();
            this.cegAdoszam_doboz3 = new System.Windows.Forms.TextBox();
            this.cegAdoszam_doboz2 = new System.Windows.Forms.TextBox();
            this.cegAdoszam_doboz1 = new System.Windows.Forms.TextBox();
            this.cegjegyzekszam_doboz3 = new System.Windows.Forms.TextBox();
            this.cegjegyzekszam_doboz2 = new System.Windows.Forms.TextBox();
            this.cegjegyzekszam_doboz1 = new System.Windows.Forms.TextBox();
            this.telefonszamKezdo_felirat = new System.Windows.Forms.Label();
            this.cegTelefonszama_felirat = new System.Windows.Forms.Label();
            this.vonal4 = new System.Windows.Forms.Label();
            this.vonal3 = new System.Windows.Forms.Label();
            this.vonal2 = new System.Windows.Forms.Label();
            this.vonal1 = new System.Windows.Forms.Label();
            this.cegAdoszam_felirat = new System.Windows.Forms.Label();
            this.cegjegyzekszam_felirat = new System.Windows.Forms.Label();
            this.cegNeve_Doboz = new System.Windows.Forms.TextBox();
            this.CegCimeCsoport = new System.Windows.Forms.GroupBox();
            this.cegCim_doboz = new System.Windows.Forms.TextBox();
            this.cegCim_felirat = new System.Windows.Forms.Label();
            this.cegIranyitoszam_doboz = new System.Windows.Forms.TextBox();
            this.cegIranyitoszam_felirat = new System.Windows.Forms.Label();
            this.cegVaros_doboz = new System.Windows.Forms.TextBox();
            this.cegVaros_felirat = new System.Windows.Forms.Label();
            this.szamlazasiNev_doboz = new System.Windows.Forms.TextBox();
            this.szamlazasiNev_felirat = new System.Windows.Forms.Label();
            this.cegNeve_felirat = new System.Windows.Forms.Label();
            this.LevelezesiCimCsoport = new System.Windows.Forms.GroupBox();
            this.levelezesiCim_doboz = new System.Windows.Forms.TextBox();
            this.levelezesiCim_felirat = new System.Windows.Forms.Label();
            this.levelezesiIranyitoszam_doboz = new System.Windows.Forms.TextBox();
            this.levelezesiIranyitoszam_felirat = new System.Windows.Forms.Label();
            this.levelezesiVaros_doboz = new System.Windows.Forms.TextBox();
            this.levelezesiVaros_felirat = new System.Windows.Forms.Label();
            this.cegSzerkesztoAblakSzoveg = new System.Windows.Forms.Label();
            this.cegWeboldala_felirat = new System.Windows.Forms.Label();
            this.cegWeboldala_doboz = new System.Windows.Forms.TextBox();
            this.CegCimeCsoport.SuspendLayout();
            this.LevelezesiCimCsoport.SuspendLayout();
            this.SuspendLayout();
            // 
            // MegseGomb
            // 
            this.MegseGomb.BackColor = System.Drawing.Color.Transparent;
            this.MegseGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MegseGomb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MegseGomb.Location = new System.Drawing.Point(118, 653);
            this.MegseGomb.Name = "MegseGomb";
            this.MegseGomb.Size = new System.Drawing.Size(63, 29);
            this.MegseGomb.TabIndex = 68;
            this.MegseGomb.Text = "Mégse";
            this.MegseGomb.UseVisualStyleBackColor = false;
            this.MegseGomb.Click += new System.EventHandler(this.MegseGomb_Click);
            // 
            // mentesGomb
            // 
            this.mentesGomb.BackColor = System.Drawing.Color.DodgerBlue;
            this.mentesGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mentesGomb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mentesGomb.Location = new System.Drawing.Point(12, 653);
            this.mentesGomb.Name = "mentesGomb";
            this.mentesGomb.Size = new System.Drawing.Size(101, 29);
            this.mentesGomb.TabIndex = 67;
            this.mentesGomb.Text = "Mentés";
            this.mentesGomb.UseVisualStyleBackColor = false;
            this.mentesGomb.Click += new System.EventHandler(this.MentesGomb_Click);
            // 
            // vonal5
            // 
            this.vonal5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vonal5.Location = new System.Drawing.Point(314, 586);
            this.vonal5.Name = "vonal5";
            this.vonal5.Size = new System.Drawing.Size(26, 20);
            this.vonal5.TabIndex = 66;
            this.vonal5.Text = "-";
            this.vonal5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cegTelefonszam_doboz2
            // 
            this.cegTelefonszam_doboz2.Location = new System.Drawing.Point(346, 587);
            this.cegTelefonszam_doboz2.MaxLength = 7;
            this.cegTelefonszam_doboz2.Name = "cegTelefonszam_doboz2";
            this.cegTelefonszam_doboz2.Size = new System.Drawing.Size(87, 20);
            this.cegTelefonszam_doboz2.TabIndex = 65;
            this.cegTelefonszam_doboz2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.haNemSzam);
            // 
            // cegTelefonszam_doboz1
            // 
            this.cegTelefonszam_doboz1.Location = new System.Drawing.Point(265, 585);
            this.cegTelefonszam_doboz1.MaxLength = 2;
            this.cegTelefonszam_doboz1.Name = "cegTelefonszam_doboz1";
            this.cegTelefonszam_doboz1.Size = new System.Drawing.Size(43, 20);
            this.cegTelefonszam_doboz1.TabIndex = 64;
            this.cegTelefonszam_doboz1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.haNemSzam);
            // 
            // cegAdoszam_doboz3
            // 
            this.cegAdoszam_doboz3.Location = new System.Drawing.Point(411, 542);
            this.cegAdoszam_doboz3.MaxLength = 2;
            this.cegAdoszam_doboz3.Name = "cegAdoszam_doboz3";
            this.cegAdoszam_doboz3.Size = new System.Drawing.Size(42, 20);
            this.cegAdoszam_doboz3.TabIndex = 60;
            this.cegAdoszam_doboz3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.haNemSzam);
            // 
            // cegAdoszam_doboz2
            // 
            this.cegAdoszam_doboz2.Location = new System.Drawing.Point(346, 542);
            this.cegAdoszam_doboz2.MaxLength = 1;
            this.cegAdoszam_doboz2.Name = "cegAdoszam_doboz2";
            this.cegAdoszam_doboz2.Size = new System.Drawing.Size(27, 20);
            this.cegAdoszam_doboz2.TabIndex = 57;
            this.cegAdoszam_doboz2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.haNemSzam);
            // 
            // cegAdoszam_doboz1
            // 
            this.cegAdoszam_doboz1.Location = new System.Drawing.Point(219, 542);
            this.cegAdoszam_doboz1.MaxLength = 8;
            this.cegAdoszam_doboz1.Name = "cegAdoszam_doboz1";
            this.cegAdoszam_doboz1.Size = new System.Drawing.Size(89, 20);
            this.cegAdoszam_doboz1.TabIndex = 56;
            this.cegAdoszam_doboz1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.haNemSzam);
            // 
            // cegjegyzekszam_doboz3
            // 
            this.cegjegyzekszam_doboz3.Location = new System.Drawing.Point(373, 507);
            this.cegjegyzekszam_doboz3.MaxLength = 6;
            this.cegjegyzekszam_doboz3.Name = "cegjegyzekszam_doboz3";
            this.cegjegyzekszam_doboz3.Size = new System.Drawing.Size(72, 20);
            this.cegjegyzekszam_doboz3.TabIndex = 55;
            this.cegjegyzekszam_doboz3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.haNemSzam);
            // 
            // cegjegyzekszam_doboz2
            // 
            this.cegjegyzekszam_doboz2.Location = new System.Drawing.Point(297, 507);
            this.cegjegyzekszam_doboz2.MaxLength = 2;
            this.cegjegyzekszam_doboz2.Name = "cegjegyzekszam_doboz2";
            this.cegjegyzekszam_doboz2.Size = new System.Drawing.Size(39, 20);
            this.cegjegyzekszam_doboz2.TabIndex = 52;
            this.cegjegyzekszam_doboz2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.haNemSzam);
            // 
            // cegjegyzekszam_doboz1
            // 
            this.cegjegyzekszam_doboz1.Location = new System.Drawing.Point(220, 506);
            this.cegjegyzekszam_doboz1.MaxLength = 2;
            this.cegjegyzekszam_doboz1.Name = "cegjegyzekszam_doboz1";
            this.cegjegyzekszam_doboz1.Size = new System.Drawing.Size(39, 20);
            this.cegjegyzekszam_doboz1.TabIndex = 51;
            this.cegjegyzekszam_doboz1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.haNemSzam);
            // 
            // telefonszamKezdo_felirat
            // 
            this.telefonszamKezdo_felirat.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.telefonszamKezdo_felirat.Location = new System.Drawing.Point(216, 585);
            this.telefonszamKezdo_felirat.Name = "telefonszamKezdo_felirat";
            this.telefonszamKezdo_felirat.Size = new System.Drawing.Size(43, 20);
            this.telefonszamKezdo_felirat.TabIndex = 63;
            this.telefonszamKezdo_felirat.Text = "+36 - ";
            this.telefonszamKezdo_felirat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cegTelefonszama_felirat
            // 
            this.cegTelefonszama_felirat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cegTelefonszama_felirat.Location = new System.Drawing.Point(16, 583);
            this.cegTelefonszama_felirat.Name = "cegTelefonszama_felirat";
            this.cegTelefonszama_felirat.Size = new System.Drawing.Size(140, 28);
            this.cegTelefonszama_felirat.TabIndex = 61;
            this.cegTelefonszama_felirat.Text = "Cég telefonszáma:";
            // 
            // vonal4
            // 
            this.vonal4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vonal4.Location = new System.Drawing.Point(379, 542);
            this.vonal4.Name = "vonal4";
            this.vonal4.Size = new System.Drawing.Size(26, 20);
            this.vonal4.TabIndex = 59;
            this.vonal4.Text = "-";
            this.vonal4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vonal3
            // 
            this.vonal3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vonal3.Location = new System.Drawing.Point(314, 542);
            this.vonal3.Name = "vonal3";
            this.vonal3.Size = new System.Drawing.Size(26, 20);
            this.vonal3.TabIndex = 58;
            this.vonal3.Text = "-";
            this.vonal3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vonal2
            // 
            this.vonal2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vonal2.Location = new System.Drawing.Point(341, 507);
            this.vonal2.Name = "vonal2";
            this.vonal2.Size = new System.Drawing.Size(26, 20);
            this.vonal2.TabIndex = 54;
            this.vonal2.Text = "-";
            this.vonal2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vonal1
            // 
            this.vonal1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vonal1.Location = new System.Drawing.Point(265, 506);
            this.vonal1.Name = "vonal1";
            this.vonal1.Size = new System.Drawing.Size(26, 20);
            this.vonal1.TabIndex = 53;
            this.vonal1.Text = "-";
            this.vonal1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cegAdoszam_felirat
            // 
            this.cegAdoszam_felirat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cegAdoszam_felirat.Location = new System.Drawing.Point(16, 543);
            this.cegAdoszam_felirat.Name = "cegAdoszam_felirat";
            this.cegAdoszam_felirat.Size = new System.Drawing.Size(119, 28);
            this.cegAdoszam_felirat.TabIndex = 49;
            this.cegAdoszam_felirat.Text = "Cég adószáma:";
            // 
            // cegjegyzekszam_felirat
            // 
            this.cegjegyzekszam_felirat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cegjegyzekszam_felirat.Location = new System.Drawing.Point(16, 505);
            this.cegjegyzekszam_felirat.Name = "cegjegyzekszam_felirat";
            this.cegjegyzekszam_felirat.Size = new System.Drawing.Size(130, 28);
            this.cegjegyzekszam_felirat.TabIndex = 46;
            this.cegjegyzekszam_felirat.Text = "Cégjegyzékszám:";
            // 
            // cegNeve_Doboz
            // 
            this.cegNeve_Doboz.Location = new System.Drawing.Point(145, 49);
            this.cegNeve_Doboz.MaxLength = 150;
            this.cegNeve_Doboz.Name = "cegNeve_Doboz";
            this.cegNeve_Doboz.Size = new System.Drawing.Size(210, 20);
            this.cegNeve_Doboz.TabIndex = 43;
            // 
            // CegCimeCsoport
            // 
            this.CegCimeCsoport.BackColor = System.Drawing.Color.White;
            this.CegCimeCsoport.Controls.Add(this.cegCim_doboz);
            this.CegCimeCsoport.Controls.Add(this.cegCim_felirat);
            this.CegCimeCsoport.Controls.Add(this.cegIranyitoszam_doboz);
            this.CegCimeCsoport.Controls.Add(this.cegIranyitoszam_felirat);
            this.CegCimeCsoport.Controls.Add(this.cegVaros_doboz);
            this.CegCimeCsoport.Controls.Add(this.cegVaros_felirat);
            this.CegCimeCsoport.Controls.Add(this.szamlazasiNev_doboz);
            this.CegCimeCsoport.Controls.Add(this.szamlazasiNev_felirat);
            this.CegCimeCsoport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CegCimeCsoport.Location = new System.Drawing.Point(12, 82);
            this.CegCimeCsoport.Name = "CegCimeCsoport";
            this.CegCimeCsoport.Size = new System.Drawing.Size(471, 223);
            this.CegCimeCsoport.TabIndex = 44;
            this.CegCimeCsoport.TabStop = false;
            this.CegCimeCsoport.Text = "Cég címe:";
            // 
            // cegCim_doboz
            // 
            this.cegCim_doboz.Location = new System.Drawing.Point(241, 154);
            this.cegCim_doboz.MaxLength = 300;
            this.cegCim_doboz.Multiline = true;
            this.cegCim_doboz.Name = "cegCim_doboz";
            this.cegCim_doboz.Size = new System.Drawing.Size(214, 53);
            this.cegCim_doboz.TabIndex = 14;
            // 
            // cegCim_felirat
            // 
            this.cegCim_felirat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cegCim_felirat.Location = new System.Drawing.Point(23, 159);
            this.cegCim_felirat.Name = "cegCim_felirat";
            this.cegCim_felirat.Size = new System.Drawing.Size(40, 36);
            this.cegCim_felirat.TabIndex = 13;
            this.cegCim_felirat.Text = "Cím:";
            // 
            // cegIranyitoszam_doboz
            // 
            this.cegIranyitoszam_doboz.Location = new System.Drawing.Point(241, 115);
            this.cegIranyitoszam_doboz.MaxLength = 4;
            this.cegIranyitoszam_doboz.Name = "cegIranyitoszam_doboz";
            this.cegIranyitoszam_doboz.Size = new System.Drawing.Size(55, 24);
            this.cegIranyitoszam_doboz.TabIndex = 11;
            this.cegIranyitoszam_doboz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.haNemSzam);
            // 
            // cegIranyitoszam_felirat
            // 
            this.cegIranyitoszam_felirat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cegIranyitoszam_felirat.Location = new System.Drawing.Point(23, 120);
            this.cegIranyitoszam_felirat.Name = "cegIranyitoszam_felirat";
            this.cegIranyitoszam_felirat.Size = new System.Drawing.Size(100, 36);
            this.cegIranyitoszam_felirat.TabIndex = 10;
            this.cegIranyitoszam_felirat.Text = "Irányítószám:";
            // 
            // cegVaros_doboz
            // 
            this.cegVaros_doboz.Location = new System.Drawing.Point(241, 76);
            this.cegVaros_doboz.MaxLength = 50;
            this.cegVaros_doboz.Name = "cegVaros_doboz";
            this.cegVaros_doboz.Size = new System.Drawing.Size(180, 24);
            this.cegVaros_doboz.TabIndex = 8;
            // 
            // cegVaros_felirat
            // 
            this.cegVaros_felirat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cegVaros_felirat.Location = new System.Drawing.Point(23, 81);
            this.cegVaros_felirat.Name = "cegVaros_felirat";
            this.cegVaros_felirat.Size = new System.Drawing.Size(60, 36);
            this.cegVaros_felirat.TabIndex = 7;
            this.cegVaros_felirat.Text = "Város:";
            // 
            // szamlazasiNev_doboz
            // 
            this.szamlazasiNev_doboz.Location = new System.Drawing.Point(241, 36);
            this.szamlazasiNev_doboz.MaxLength = 150;
            this.szamlazasiNev_doboz.Name = "szamlazasiNev_doboz";
            this.szamlazasiNev_doboz.Size = new System.Drawing.Size(180, 24);
            this.szamlazasiNev_doboz.TabIndex = 5;
            // 
            // szamlazasiNev_felirat
            // 
            this.szamlazasiNev_felirat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szamlazasiNev_felirat.Location = new System.Drawing.Point(23, 41);
            this.szamlazasiNev_felirat.Name = "szamlazasiNev_felirat";
            this.szamlazasiNev_felirat.Size = new System.Drawing.Size(121, 36);
            this.szamlazasiNev_felirat.TabIndex = 4;
            this.szamlazasiNev_felirat.Text = "Számlázási név:";
            // 
            // cegNeve_felirat
            // 
            this.cegNeve_felirat.AutoSize = true;
            this.cegNeve_felirat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cegNeve_felirat.Location = new System.Drawing.Point(16, 50);
            this.cegNeve_felirat.Name = "cegNeve_felirat";
            this.cegNeve_felirat.Size = new System.Drawing.Size(78, 16);
            this.cegNeve_felirat.TabIndex = 42;
            this.cegNeve_felirat.Text = "Cég neve:";
            // 
            // LevelezesiCimCsoport
            // 
            this.LevelezesiCimCsoport.BackColor = System.Drawing.Color.White;
            this.LevelezesiCimCsoport.Controls.Add(this.levelezesiCim_doboz);
            this.LevelezesiCimCsoport.Controls.Add(this.levelezesiCim_felirat);
            this.LevelezesiCimCsoport.Controls.Add(this.levelezesiIranyitoszam_doboz);
            this.LevelezesiCimCsoport.Controls.Add(this.levelezesiIranyitoszam_felirat);
            this.LevelezesiCimCsoport.Controls.Add(this.levelezesiVaros_doboz);
            this.LevelezesiCimCsoport.Controls.Add(this.levelezesiVaros_felirat);
            this.LevelezesiCimCsoport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LevelezesiCimCsoport.Location = new System.Drawing.Point(12, 311);
            this.LevelezesiCimCsoport.Name = "LevelezesiCimCsoport";
            this.LevelezesiCimCsoport.Size = new System.Drawing.Size(471, 179);
            this.LevelezesiCimCsoport.TabIndex = 45;
            this.LevelezesiCimCsoport.TabStop = false;
            this.LevelezesiCimCsoport.Text = "Levelezési cím:";
            // 
            // levelezesiCim_doboz
            // 
            this.levelezesiCim_doboz.Location = new System.Drawing.Point(241, 110);
            this.levelezesiCim_doboz.MaxLength = 300;
            this.levelezesiCim_doboz.Multiline = true;
            this.levelezesiCim_doboz.Name = "levelezesiCim_doboz";
            this.levelezesiCim_doboz.Size = new System.Drawing.Size(214, 53);
            this.levelezesiCim_doboz.TabIndex = 14;
            // 
            // levelezesiCim_felirat
            // 
            this.levelezesiCim_felirat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.levelezesiCim_felirat.Location = new System.Drawing.Point(23, 115);
            this.levelezesiCim_felirat.Name = "levelezesiCim_felirat";
            this.levelezesiCim_felirat.Size = new System.Drawing.Size(40, 36);
            this.levelezesiCim_felirat.TabIndex = 13;
            this.levelezesiCim_felirat.Text = "Cím:";
            // 
            // levelezesiIranyitoszam_doboz
            // 
            this.levelezesiIranyitoszam_doboz.Location = new System.Drawing.Point(241, 71);
            this.levelezesiIranyitoszam_doboz.MaxLength = 4;
            this.levelezesiIranyitoszam_doboz.Name = "levelezesiIranyitoszam_doboz";
            this.levelezesiIranyitoszam_doboz.Size = new System.Drawing.Size(55, 24);
            this.levelezesiIranyitoszam_doboz.TabIndex = 11;
            this.levelezesiIranyitoszam_doboz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.haNemSzam);
            // 
            // levelezesiIranyitoszam_felirat
            // 
            this.levelezesiIranyitoszam_felirat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.levelezesiIranyitoszam_felirat.Location = new System.Drawing.Point(23, 76);
            this.levelezesiIranyitoszam_felirat.Name = "levelezesiIranyitoszam_felirat";
            this.levelezesiIranyitoszam_felirat.Size = new System.Drawing.Size(100, 36);
            this.levelezesiIranyitoszam_felirat.TabIndex = 10;
            this.levelezesiIranyitoszam_felirat.Text = "Irányítószám:";
            // 
            // levelezesiVaros_doboz
            // 
            this.levelezesiVaros_doboz.Location = new System.Drawing.Point(241, 32);
            this.levelezesiVaros_doboz.MaxLength = 50;
            this.levelezesiVaros_doboz.Name = "levelezesiVaros_doboz";
            this.levelezesiVaros_doboz.Size = new System.Drawing.Size(180, 24);
            this.levelezesiVaros_doboz.TabIndex = 8;
            // 
            // levelezesiVaros_felirat
            // 
            this.levelezesiVaros_felirat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.levelezesiVaros_felirat.Location = new System.Drawing.Point(23, 37);
            this.levelezesiVaros_felirat.Name = "levelezesiVaros_felirat";
            this.levelezesiVaros_felirat.Size = new System.Drawing.Size(60, 36);
            this.levelezesiVaros_felirat.TabIndex = 7;
            this.levelezesiVaros_felirat.Text = "Város:";
            // 
            // cegSzerkesztoAblakSzoveg
            // 
            this.cegSzerkesztoAblakSzoveg.AutoSize = true;
            this.cegSzerkesztoAblakSzoveg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cegSzerkesztoAblakSzoveg.Location = new System.Drawing.Point(149, 9);
            this.cegSzerkesztoAblakSzoveg.Name = "cegSzerkesztoAblakSzoveg";
            this.cegSzerkesztoAblakSzoveg.Size = new System.Drawing.Size(200, 24);
            this.cegSzerkesztoAblakSzoveg.TabIndex = 41;
            this.cegSzerkesztoAblakSzoveg.Text = "<Cég ablak funkció>";
            // 
            // cegWeboldala_felirat
            // 
            this.cegWeboldala_felirat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cegWeboldala_felirat.Location = new System.Drawing.Point(16, 619);
            this.cegWeboldala_felirat.Name = "cegWeboldala_felirat";
            this.cegWeboldala_felirat.Size = new System.Drawing.Size(140, 28);
            this.cegWeboldala_felirat.TabIndex = 69;
            this.cegWeboldala_felirat.Text = "Cég weboldala:";
            // 
            // cegWeboldala_doboz
            // 
            this.cegWeboldala_doboz.Location = new System.Drawing.Point(219, 619);
            this.cegWeboldala_doboz.MaxLength = 150;
            this.cegWeboldala_doboz.Name = "cegWeboldala_doboz";
            this.cegWeboldala_doboz.Size = new System.Drawing.Size(234, 20);
            this.cegWeboldala_doboz.TabIndex = 70;
            // 
            // SzerkesztesAblak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(495, 694);
            this.Controls.Add(this.cegWeboldala_doboz);
            this.Controls.Add(this.cegWeboldala_felirat);
            this.Controls.Add(this.MegseGomb);
            this.Controls.Add(this.mentesGomb);
            this.Controls.Add(this.vonal5);
            this.Controls.Add(this.cegTelefonszam_doboz2);
            this.Controls.Add(this.cegTelefonszam_doboz1);
            this.Controls.Add(this.cegAdoszam_doboz3);
            this.Controls.Add(this.cegAdoszam_doboz2);
            this.Controls.Add(this.cegAdoszam_doboz1);
            this.Controls.Add(this.cegjegyzekszam_doboz3);
            this.Controls.Add(this.cegjegyzekszam_doboz2);
            this.Controls.Add(this.cegjegyzekszam_doboz1);
            this.Controls.Add(this.telefonszamKezdo_felirat);
            this.Controls.Add(this.cegTelefonszama_felirat);
            this.Controls.Add(this.vonal4);
            this.Controls.Add(this.vonal3);
            this.Controls.Add(this.vonal2);
            this.Controls.Add(this.vonal1);
            this.Controls.Add(this.cegAdoszam_felirat);
            this.Controls.Add(this.cegjegyzekszam_felirat);
            this.Controls.Add(this.cegNeve_Doboz);
            this.Controls.Add(this.CegCimeCsoport);
            this.Controls.Add(this.cegNeve_felirat);
            this.Controls.Add(this.LevelezesiCimCsoport);
            this.Controls.Add(this.cegSzerkesztoAblakSzoveg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SzerkesztesAblak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "<Cég ablak funkció>";
            this.Load += new System.EventHandler(this.SzerkesztesAblak_Load);
            this.CegCimeCsoport.ResumeLayout(false);
            this.CegCimeCsoport.PerformLayout();
            this.LevelezesiCimCsoport.ResumeLayout(false);
            this.LevelezesiCimCsoport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MegseGomb;
        private System.Windows.Forms.Button mentesGomb;
        private System.Windows.Forms.Label vonal5;
        private System.Windows.Forms.TextBox cegTelefonszam_doboz2;
        private System.Windows.Forms.TextBox cegTelefonszam_doboz1;
        private System.Windows.Forms.TextBox cegAdoszam_doboz3;
        private System.Windows.Forms.TextBox cegAdoszam_doboz2;
        private System.Windows.Forms.TextBox cegAdoszam_doboz1;
        private System.Windows.Forms.TextBox cegjegyzekszam_doboz3;
        private System.Windows.Forms.TextBox cegjegyzekszam_doboz2;
        private System.Windows.Forms.TextBox cegjegyzekszam_doboz1;
        private System.Windows.Forms.Label telefonszamKezdo_felirat;
        private System.Windows.Forms.Label cegTelefonszama_felirat;
        private System.Windows.Forms.Label vonal4;
        private System.Windows.Forms.Label vonal3;
        private System.Windows.Forms.Label vonal2;
        private System.Windows.Forms.Label vonal1;
        private System.Windows.Forms.Label cegAdoszam_felirat;
        private System.Windows.Forms.Label cegjegyzekszam_felirat;
        private System.Windows.Forms.TextBox cegNeve_Doboz;
        private System.Windows.Forms.GroupBox CegCimeCsoport;
        private System.Windows.Forms.TextBox cegCim_doboz;
        private System.Windows.Forms.Label cegCim_felirat;
        private System.Windows.Forms.TextBox cegIranyitoszam_doboz;
        private System.Windows.Forms.Label cegIranyitoszam_felirat;
        private System.Windows.Forms.TextBox cegVaros_doboz;
        private System.Windows.Forms.Label cegVaros_felirat;
        private System.Windows.Forms.TextBox szamlazasiNev_doboz;
        private System.Windows.Forms.Label szamlazasiNev_felirat;
        private System.Windows.Forms.Label cegNeve_felirat;
        private System.Windows.Forms.GroupBox LevelezesiCimCsoport;
        private System.Windows.Forms.TextBox levelezesiCim_doboz;
        private System.Windows.Forms.Label levelezesiCim_felirat;
        private System.Windows.Forms.TextBox levelezesiIranyitoszam_doboz;
        private System.Windows.Forms.Label levelezesiIranyitoszam_felirat;
        private System.Windows.Forms.TextBox levelezesiVaros_doboz;
        private System.Windows.Forms.Label levelezesiVaros_felirat;
        private System.Windows.Forms.Label cegSzerkesztoAblakSzoveg;
        private System.Windows.Forms.Label cegWeboldala_felirat;
        private System.Windows.Forms.TextBox cegWeboldala_doboz;
    }
}