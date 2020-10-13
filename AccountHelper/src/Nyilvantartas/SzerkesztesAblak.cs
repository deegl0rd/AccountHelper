using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountHelper.src.Nyilvantartas
{
    public partial class SzerkesztesAblak : Form
    {
        public static bool code = false;

        public static string szerkesztett;

        public SzerkesztesAblak()
        {
            InitializeComponent();
        }

        private void SzerkesztesAblak_Load(object sender, EventArgs e)
        {
            switch (code)
            {
                case false:
                    {
                        cegSzerkesztoAblakSzoveg.Text = "Cég létrehozása";

                        cegNeve_Doboz.Text = "";
                        szamlazasiNev_doboz.Text = "";
                        cegVaros_doboz.Text = "";
                        cegIranyitoszam_doboz.Text = "";
                        cegCim_doboz.Text = "";
                        levelezesiVaros_doboz.Text = "";
                        levelezesiCim_doboz.Text = "";
                        levelezesiIranyitoszam_doboz.Text = "";
                        cegjegyzekszam_doboz1.Text = "";
                        cegjegyzekszam_doboz2.Text = "";
                        cegjegyzekszam_doboz3.Text = "";
                        cegAdoszam_doboz1.Text = "";
                        cegAdoszam_doboz2.Text = "";
                        cegAdoszam_doboz3.Text = "";
                        cegTelefonszam_doboz1.Text = "";
                        cegTelefonszam_doboz2.Text = "";
                        cegWeboldala_doboz.Text = "";

                        break;
                    }

                case true:
                    {
                        cegSzerkesztoAblakSzoveg.Text = "Cég adatainak szerkesztése";

                        Ceg c = new Ceg(szerkesztett);

                        cegNeve_Doboz.Text = c.ceg_neve;
                        szamlazasiNev_doboz.Text = c.szamlazasiNev;
                        cegVaros_doboz.Text = c.varos;
                        cegIranyitoszam_doboz.Text = c.iranyitoszam.ToString();
                        cegCim_doboz.Text = c.cim;
                        levelezesiVaros_doboz.Text = c.levelezesi_varos;
                        levelezesiCim_doboz.Text = c.levelezesi_cim;
                        levelezesiIranyitoszam_doboz.Text = c.levelezesi_iranyitoszam.ToString();
                        cegjegyzekszam_doboz1.Text = c.cegjegyzekszam.Substring(0,2);
                        cegjegyzekszam_doboz2.Text = c.cegjegyzekszam.Substring(2, 2);
                        cegjegyzekszam_doboz3.Text = c.cegjegyzekszam.Substring(4, 6);
                        cegAdoszam_doboz1.Text = c.cegAdoszam.Substring(0,7);
                        cegAdoszam_doboz2.Text = c.cegAdoszam.Substring(7, 1);
                        cegAdoszam_doboz3.Text = c.cegAdoszam.Substring(8, 2);
                        cegTelefonszam_doboz1.Text = c.cegTelefonszam.Substring(0,2);
                        cegTelefonszam_doboz2.Text = c.cegTelefonszam.Substring(2, 9);
                        cegWeboldala_doboz.Text = c.cegWeboldal;

                        break;
                    }
            }
        }

        private void Letrehoz()
        {
            if (string.IsNullOrEmpty(cegNeve_Doboz.Text) ||
                string.IsNullOrEmpty(szamlazasiNev_doboz.Text) ||
                string.IsNullOrEmpty(cegVaros_doboz.Text) ||
                string.IsNullOrEmpty(cegIranyitoszam_doboz.Text) ||
                string.IsNullOrEmpty(cegCim_doboz.Text) ||
                string.IsNullOrEmpty(levelezesiVaros_doboz.Text) ||
                string.IsNullOrEmpty(levelezesiCim_doboz.Text) ||
                string.IsNullOrEmpty(levelezesiIranyitoszam_doboz.Text) ||
                string.IsNullOrEmpty(cegjegyzekszam_doboz1.Text) || string.IsNullOrEmpty(cegjegyzekszam_doboz2.Text) || string.IsNullOrEmpty(cegjegyzekszam_doboz3.Text) ||
                string.IsNullOrEmpty(cegAdoszam_doboz1.Text) || string.IsNullOrEmpty(cegAdoszam_doboz2.Text) || string.IsNullOrEmpty(cegAdoszam_doboz3.Text) ||
                string.IsNullOrEmpty(cegTelefonszam_doboz1.Text) || string.IsNullOrEmpty(cegTelefonszam_doboz2.Text))
            {
                MessageBox.Show(null, "Fontos mező ki lett hagyva!", "Hiányzó mezők", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Ceg c = new Ceg(
                cegNeve_Doboz.Text,
                szamlazasiNev_doboz.Text,
                cegVaros_doboz.Text,
                int.Parse(cegIranyitoszam_doboz.Text),
                cegCim_doboz.Text,
                levelezesiVaros_doboz.Text,
                levelezesiCim_doboz.Text,
                int.Parse(levelezesiIranyitoszam_doboz.Text),
                cegjegyzekszam_doboz1.Text + "-" + cegjegyzekszam_doboz2.Text + "-" + cegjegyzekszam_doboz3.Text,
                cegAdoszam_doboz1.Text + "-" + cegjegyzekszam_doboz2.Text + "-" + cegjegyzekszam_doboz3.Text,
                "+36" + cegTelefonszam_doboz1.Text + cegTelefonszam_doboz2.Text,
                cegWeboldala_doboz.Text
                );

            c.Letrehoz();
        }

        private void Valtoztat()
        {

        }

        private void MegseGomb_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void MentesGomb_Click(object sender, EventArgs e)
        {
            switch (code)
            {
                case false:
                    {
                        Letrehoz();
                        break;
                    }

                case true:
                    {
                        Valtoztat();
                        break;
                    }
            }
        }
    }
}
