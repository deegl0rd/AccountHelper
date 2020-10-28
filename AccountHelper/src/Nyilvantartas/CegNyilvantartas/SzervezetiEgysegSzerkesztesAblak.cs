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
    public partial class SzervezetiEgysegSzerkesztesAblak : Form
    {
        public static bool code = false;

        private Ceg ceg;

        public static string kivalasztottCegUtvonala;

        public static string szerv_nev, szerv_ID;

        private SzervezetiEgyseg letrehozott, szerkesztett;

        private void Nullaz()
        {
            cegNeve_Doboz.Text = "";
            munkaRendSablon_valaszto.SelectedIndex = 0;
            mkKezdete_ora_SzamValaszto.Text = "";
            mkKezdete_perc_SzamValaszto.Text = "";
            mkVege_ora_SzamValaszto.Text = "";
            mkVege_perc_SzamValaszto.Text = "";
            napiMunkaIdo_SzamValaszto.Value = 8;
            pipa_munkakoziSzunetNemResze.Checked = false;
            pipa_autoNyilvanTartas.Checked = false;

            pipa_szunet1.Checked = false;
            mkSzunet1_tol_SzamValaszto.Text = "";
            mkSzunet1_ig_SzamValaszto.Text = "";
            mkSzunet1_perc_SzamValaszto.Value = 30;

            pipa_szunet2.Checked = false;
            mkSzunet2_tol_SzamValaszto.Text = "";
            mkSzunet2_ig_SzamValaszto.Text = "";
            mkSzunet2_perc_SzamValaszto.Value = 30;

            pipa_szunet3.Checked = false;
            mkSzunet3_tol_SzamValaszto.Text = "";
            mkSzunet3_ig_SzamValaszto.Text = "";
            mkSzunet3_perc_SzamValaszto.Value = 30;

            pipa_szunet4.Checked = false;
            mkSzunet4_tol_SzamValaszto.Text = "";
            mkSzunet4_ig_SzamValaszto.Text = "";
            mkSzunet4_perc_SzamValaszto.Value = 30;
        }

        private bool HaUres()
        {
            if (string.IsNullOrEmpty(cegNeve_Doboz.Text) ||
                string.IsNullOrEmpty(mkKezdete_ora_SzamValaszto.Text) ||
                string.IsNullOrEmpty(mkKezdete_perc_SzamValaszto.Text) ||
                string.IsNullOrEmpty(mkVege_ora_SzamValaszto.Text) ||
                string.IsNullOrEmpty(mkVege_perc_SzamValaszto.Text))
            {
                if (munkaRendSablon_valaszto.SelectedItem.ToString() == "kötetlen")
                {
                    return false;
                }
                MessageBox.Show(null, "Fontos mező ki lett hagyva!", "Hiányzó mezők", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void Letrehoz()
        {
            if (HaUres()) return;

            letrehozott = new SzervezetiEgyseg
            {
                Neve = cegNeve_Doboz.Text,
                Sablon = munkaRendSablon_valaszto.SelectedItem.ToString(),
                MkidoKezd = mkKezdete_ora_SzamValaszto.Text + ":" + mkKezdete_perc_SzamValaszto.Text,
                MkidoVege = mkVege_ora_SzamValaszto.Text + ":" + mkVege_perc_SzamValaszto.Text,
                NapimkIdo = (int)napiMunkaIdo_SzamValaszto.Value,
                MkSzunetNemResze = pipa_munkakoziSzunetNemResze.Checked,
                AutoNyilvantartas = pipa_autoNyilvanTartas.Checked,
            };

            letrehozott.MkSzunetek = new List<string[]>();

            if (pipa_szunet1.Checked) letrehozott.MkSzunetek.Add(
                new string[] { mkSzunet1_tol_SzamValaszto.Text, mkSzunet1_ig_SzamValaszto.Text, mkSzunet1_perc_SzamValaszto.Value.ToString() });
            if (pipa_szunet2.Checked) letrehozott.MkSzunetek.Add(
                new string[] { mkSzunet2_tol_SzamValaszto.Text, mkSzunet2_ig_SzamValaszto.Text, mkSzunet2_perc_SzamValaszto.Value.ToString() });
            if (pipa_szunet3.Checked) letrehozott.MkSzunetek.Add(
                new string[] { mkSzunet3_tol_SzamValaszto.Text, mkSzunet3_ig_SzamValaszto.Text, mkSzunet3_perc_SzamValaszto.Value.ToString() });
            if (pipa_szunet4.Checked) letrehozott.MkSzunetek.Add(
                new string[] { mkSzunet4_tol_SzamValaszto.Text, mkSzunet4_ig_SzamValaszto.Text, mkSzunet4_perc_SzamValaszto.Value.ToString() });

            letrehozott.Letrehoz(ceg);
        }

        private void Valtoztat()
        {
            SzervezetiEgyseg valtoztatas = new SzervezetiEgyseg()
            {
                Neve = cegNeve_Doboz.Text,
                Sablon = munkaRendSablon_valaszto.SelectedItem.ToString(),
                MkidoKezd = mkKezdete_ora_SzamValaszto.Text + ":" + mkKezdete_perc_SzamValaszto.Text,
                MkidoVege = mkVege_ora_SzamValaszto.Text + ":" + mkVege_perc_SzamValaszto.Text,
                NapimkIdo = (int)napiMunkaIdo_SzamValaszto.Value,
                MkSzunetNemResze = pipa_munkakoziSzunetNemResze.Checked,
                AutoNyilvantartas = pipa_autoNyilvanTartas.Checked,
            };

            valtoztatas.MkSzunetek = new List<string[]>();

            if (pipa_szunet1.Checked) valtoztatas.MkSzunetek.Add(
                new string[] { mkSzunet1_tol_SzamValaszto.Text, mkSzunet1_ig_SzamValaszto.Text, mkSzunet1_perc_SzamValaszto.Value.ToString() });
            if (pipa_szunet2.Checked) valtoztatas.MkSzunetek.Add(
                new string[] { mkSzunet2_tol_SzamValaszto.Text, mkSzunet2_ig_SzamValaszto.Text, mkSzunet2_perc_SzamValaszto.Value.ToString() });
            if (pipa_szunet3.Checked) valtoztatas.MkSzunetek.Add(
                new string[] { mkSzunet3_tol_SzamValaszto.Text, mkSzunet3_ig_SzamValaszto.Text, mkSzunet3_perc_SzamValaszto.Value.ToString() });
            if (pipa_szunet4.Checked) valtoztatas.MkSzunetek.Add(
                new string[] { mkSzunet4_tol_SzamValaszto.Text, mkSzunet4_ig_SzamValaszto.Text, mkSzunet4_perc_SzamValaszto.Value.ToString() });

            SzervezetiEgyseg.Valtoztat(ceg, szerv_nev, szerv_ID, valtoztatas);
        }

        public SzervezetiEgysegSzerkesztesAblak()
        {
            InitializeComponent();
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

            Hide();
            NyilvantartasAblak.formInstance.Frissites(true);
        }

        private void MegseGomb_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void SzervezetiEgysegSzerkesztesAblak_Load(object sender, EventArgs e)
        {
            Nullaz();

            ceg = new Ceg(kivalasztottCegUtvonala);
            ceg.SzervezetiEgysegBetoltes();

            switch (code)
            {
                //Létrehozás
                case false:
                    {
                        Text = szervezetiEgysegSzerkesztesAblakSzoveg.Text = "Szervezeti egység létrehozása";
                        break;
                    }

                //Változtatás
                case true:
                    {
                        Text = szervezetiEgysegSzerkesztesAblakSzoveg.Text = "Szervezeti egység módosítása";

                        szerkesztett = ceg.SzervezetiEgysegek.Find(item => item.Neve == szerv_nev && item.ID == szerv_ID);

                        cegNeve_Doboz.Text = szerkesztett.Neve;
                        munkaRendSablon_valaszto.SelectedItem = szerkesztett.Sablon;
                        mkKezdete_ora_SzamValaszto.Text = szerkesztett.MkidoKezd.Split(':')[0];
                        mkKezdete_perc_SzamValaszto.Text = szerkesztett.MkidoKezd.Split(':')[1];
                        mkVege_ora_SzamValaszto.Text = szerkesztett.MkidoVege.Split(':')[0];
                        mkVege_perc_SzamValaszto.Text = szerkesztett.MkidoVege.Split(':')[1];
                        napiMunkaIdo_SzamValaszto.Value = szerkesztett.NapimkIdo;
                        pipa_munkakoziSzunetNemResze.Checked = szerkesztett.MkSzunetNemResze;
                        pipa_autoNyilvanTartas.Checked = szerkesztett.AutoNyilvantartas;

                        Console.WriteLine(szerkesztett.Neve + szerkesztett.ID + szerkesztett.MkSzunetek[0][0]);
                        switch (szerkesztett.SzunetekSzama)
                        {
                            case 1:
                                {
                                    pipa_szunet1.Checked = true;
                                    mkSzunet1_tol_SzamValaszto.Text = szerkesztett.MkSzunetek[0][0];
                                    mkSzunet1_ig_SzamValaszto.Text = szerkesztett.MkSzunetek[0][1];
                                    mkSzunet1_perc_SzamValaszto.Value = int.Parse(szerkesztett.MkSzunetek[0][2]);
                                    break;
                                }
                            case 2:
                                {
                                    pipa_szunet2.Checked = true;
                                    mkSzunet2_tol_SzamValaszto.Text = szerkesztett.MkSzunetek[1][0];
                                    mkSzunet2_ig_SzamValaszto.Text = szerkesztett.MkSzunetek[1][1];
                                    mkSzunet2_perc_SzamValaszto.Value = int.Parse(szerkesztett.MkSzunetek[1][2]);
                                    goto case 1;
                                }
                            case 3:
                                {
                                    pipa_szunet3.Checked = true;
                                    mkSzunet3_tol_SzamValaszto.Text = szerkesztett.MkSzunetek[2][0];
                                    mkSzunet3_ig_SzamValaszto.Text = szerkesztett.MkSzunetek[2][1];
                                    mkSzunet3_perc_SzamValaszto.Value = int.Parse(szerkesztett.MkSzunetek[2][2]);
                                    goto case 2;
                                }
                            case 4:
                                {
                                    pipa_szunet4.Checked = true;
                                    mkSzunet4_tol_SzamValaszto.Text = szerkesztett.MkSzunetek[3][0];
                                    mkSzunet4_ig_SzamValaszto.Text = szerkesztett.MkSzunetek[3][1];
                                    mkSzunet4_perc_SzamValaszto.Value = int.Parse(szerkesztett.MkSzunetek[3][2]);
                                    goto case 3;
                                }
                        }

                        break;
                    }
            }
        }

        private void MunkaRendSablon_valaszto_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (munkaRendSablon_valaszto.SelectedItem.ToString())
            {
                case "általános":
                    {
                        kotelezoElemek.Visible = true;
                        break;
                    }
                case "kötetlen":
                    {
                        kotelezoElemek.Visible = false;
                        break;
                    }
                case "munkaidőkeret":
                    {
                        kotelezoElemek.Visible = true;
                        break;
                    }
            }
        }
    }
}
