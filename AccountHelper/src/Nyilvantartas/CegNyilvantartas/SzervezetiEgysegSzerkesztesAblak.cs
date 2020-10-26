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

        private SzervezetiEgyseg letrehozott;

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

            Hide();
            NyilvantartasAblak.formInstance.Frissites(true);
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
                        //Valtoztat();
                        break;
                    }
            }
        }

        private void MegseGomb_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void SzervezetiEgysegSzerkesztesAblak_Load(object sender, EventArgs e)
        {
            munkaRendSablon_valaszto.SelectedIndex = 0;
            ceg = new Ceg(kivalasztottCegUtvonala);

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
