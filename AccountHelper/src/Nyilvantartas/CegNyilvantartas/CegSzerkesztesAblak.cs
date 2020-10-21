using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace AccountHelper.src.Nyilvantartas
{
    public partial class CegSzerkesztesAblak : Form
    {
        public static bool code = false;

        private static Ceg letrehozottCeg, megnyitottCeg;

        public static string szerkesztett;

        private bool HaUres()
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
                return true;
            }
            return false;
        }

        public CegSzerkesztesAblak()
        {
            InitializeComponent();
        }

        private void SzerkesztesAblak_Load(object sender, EventArgs e)
        {
            switch (code)
            {
                //Létrehozás
                case false:
                    {
                        Text = cegSzerkesztoAblakSzoveg.Text = "Cég létrehozása";
                        

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

                //Szerkesztés
                case true:
                    {
                        Text = cegSzerkesztoAblakSzoveg.Text = "Cég adatainak szerkesztése";

                        megnyitottCeg = new Ceg(szerkesztett);

                        //Cég neve
                        cegNeve_Doboz.Text = megnyitottCeg.ceg_neve;

                        //Számlázási név
                        szamlazasiNev_doboz.Text = megnyitottCeg.szamlazasiNev;

                        //Cég adatok
                        cegVaros_doboz.Text = megnyitottCeg.varos;
                        cegIranyitoszam_doboz.Text = megnyitottCeg.iranyitoszam.ToString();
                        cegCim_doboz.Text = megnyitottCeg.cim;

                        //Levelezési adatok
                        levelezesiVaros_doboz.Text = megnyitottCeg.levelezesi_varos;
                        levelezesiCim_doboz.Text = megnyitottCeg.levelezesi_cim;
                        levelezesiIranyitoszam_doboz.Text = megnyitottCeg.levelezesi_iranyitoszam.ToString();

                        //Cégjegyzékszám
                        cegjegyzekszam_doboz1.Text = megnyitottCeg.cegjegyzekszam.Substring(0,2);
                        cegjegyzekszam_doboz2.Text = megnyitottCeg.cegjegyzekszam.Substring(2, 2);
                        cegjegyzekszam_doboz3.Text = megnyitottCeg.cegjegyzekszam.Substring(4, 6);

                        //Cég adószám
                        cegAdoszam_doboz1.Text = megnyitottCeg.cegAdoszam.Substring(0,8);
                        cegAdoszam_doboz2.Text = megnyitottCeg.cegAdoszam.Substring(8, 1);
                        cegAdoszam_doboz3.Text = megnyitottCeg.cegAdoszam.Substring(9, 2);

                        //Telefonszám
                        if (megnyitottCeg.cegTelefonszam.Substring(0, 2) == "06")
                        {
                            cegTelefonszam_doboz1.Text = megnyitottCeg.cegTelefonszam.Substring(2, 2);
                            cegTelefonszam_doboz2.Text = megnyitottCeg.cegTelefonszam.Substring(4, 7);
                        } else if (megnyitottCeg.cegTelefonszam.Substring(0, 2) == "36") {
                            cegTelefonszam_doboz1.Text = megnyitottCeg.cegTelefonszam.Substring(2, 2);
                            cegTelefonszam_doboz2.Text = megnyitottCeg.cegTelefonszam.Substring(4, 7);
                        } else if (megnyitottCeg.cegTelefonszam.Substring(0, 3) == "+36") {
                            cegTelefonszam_doboz1.Text = megnyitottCeg.cegTelefonszam.Substring(3, 2);
                            cegTelefonszam_doboz2.Text = megnyitottCeg.cegTelefonszam.Substring(5, 7);
                        }

                        //Weboldal
                        cegWeboldala_doboz.Text = megnyitottCeg.cegWeboldal;

                        break;
                    }
            }
        }

        private void Letrehoz()
        {
            letrehozottCeg = new Ceg(
                cegNeve_Doboz.Text,
                szamlazasiNev_doboz.Text,
                cegVaros_doboz.Text,
                int.Parse(cegIranyitoszam_doboz.Text),
                cegCim_doboz.Text,
                levelezesiVaros_doboz.Text,
                levelezesiCim_doboz.Text,
                int.Parse(levelezesiIranyitoszam_doboz.Text),
                cegjegyzekszam_doboz1.Text + cegjegyzekszam_doboz2.Text + cegjegyzekszam_doboz3.Text,
                cegAdoszam_doboz1.Text + cegjegyzekszam_doboz2.Text + cegjegyzekszam_doboz3.Text,
                "+36" + cegTelefonszam_doboz1.Text + cegTelefonszam_doboz2.Text,
                cegWeboldala_doboz.Text
                );


            if (HaUres()) return;

            letrehozottCeg.Letrehoz();

            Hide();
            NyilvantartasAblak.formInstance.Frissites();
        }

        private void Valtoztat()
        {
            if (HaUres()) return;

            megnyitottCeg.Valtoztat(
                cegNeve_Doboz.Text,
                szamlazasiNev_doboz.Text,
                cegVaros_doboz.Text,
                int.Parse(cegIranyitoszam_doboz.Text),
                cegCim_doboz.Text,
                levelezesiVaros_doboz.Text,
                levelezesiCim_doboz.Text,
                int.Parse(levelezesiIranyitoszam_doboz.Text),
                cegjegyzekszam_doboz1.Text + cegjegyzekszam_doboz2.Text + cegjegyzekszam_doboz3.Text,
                cegAdoszam_doboz1.Text + cegAdoszam_doboz2.Text + cegAdoszam_doboz3.Text,
                "+36" + cegTelefonszam_doboz1.Text + cegTelefonszam_doboz2.Text,
                cegWeboldala_doboz.Text
                );

            Hide();
            NyilvantartasAblak.formInstance.Frissites();
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
