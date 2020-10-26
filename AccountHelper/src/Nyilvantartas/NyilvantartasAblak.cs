using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountHelper.src.Nyilvantartas
{
    public partial class NyilvantartasAblak : Form
    {
        public static NyilvantartasAblak formInstance;

        private Ceg kattintottCeg;
        public NyilvantartasAblak()
        {
            InitializeComponent();
            formInstance = this;
        }

        private string ReverseSlash(string input)
        {
            return input.Replace("\\", "/");
        }

        private void SzervEgysegListabaToltese()
        {
            ListViewItem szvItem;
            for (int i = 0; i < kattintottCeg.SzervezetiEgysegek.Count; i++)
            {
                szvItem = new ListViewItem(kattintottCeg.SzervezetiEgysegek[i].Neve)
                {
                    UseItemStyleForSubItems = false,
                    Tag = kattintottCeg.SzervezetiEgysegek[i].ID
                };
                szvItem.SubItems.Add(kattintottCeg.SzervezetiEgysegek[i].Sablon);
                szvItem.SubItems[1].ForeColor = Color.Gray;

                szervezetiEgysegLista.Items.Add(szvItem);
            }
        }

        public void Frissites(bool teljesen)
        {
            if (!teljesen)
            {
                tartalomDoboz.Text = File.ReadAllText(kattintottCeg.filepath);
                return;
            }

            tartalomDoboz.Text = "";
            cegLista.Items.Clear();
            szervezetiEgysegLista.Items.Clear();

            Ceg.Betoltes();

            ListViewItem item;
            foreach (Ceg c in Ceg.ceglista)
            {
                item = new ListViewItem(c.ceg_neve)
                {
                    UseItemStyleForSubItems = false,
                    Tag = ReverseSlash(c.filepath)
                };
                item.SubItems.Add(c.fajlNev);

                cegLista.Items.Add(item);
            }
        }

        private void NyilvantartasAblak_Load(object sender, EventArgs e)
        {
            Frissites(true);
        }

        private void CegTorlesGomb_Click(object sender, EventArgs e)
        {
            if (cegLista.SelectedItems.Count == 0) return;

            foreach (ListViewItem item in cegLista.SelectedItems)
            {
                File.Delete(item.Tag.ToString());
                item.Remove();
            }
            Frissites(true);
        }

        private void FrissitesGomb_Click(object sender, EventArgs e)
        {
            Frissites(true);
        }

        private void HozzaadasGomb_Click(object sender, EventArgs e)
        {
            CegSzerkesztesAblak.code = false;
            Program.CegSzerkesztesAblak.ShowDialog();
        }

        private void SzerkesztesGomb_Click(object sender, EventArgs e)
        {
            if (cegLista.SelectedItems.Count > 1 || cegLista.SelectedItems.Count == 0) return;

            CegSzerkesztesAblak.code = true;
            Program.CegSzerkesztesAblak.ShowDialog();
        }

        private void CegLista_MouseClick(object sender, MouseEventArgs e)
        {
            szervezetiEgysegLista.Items.Clear();
            if (!cegLista.FocusedItem.Bounds.Contains(e.Location)) return;
            if (cegLista.SelectedItems.Count > 1 || cegLista.SelectedItems.Count == 0) return;

            kattintottCeg = new Ceg(cegLista.FocusedItem.Tag.ToString());
            kattintottCeg.SzervezetiEgysegBetoltes();
            tartalomDoboz.Text = File.ReadAllText(kattintottCeg.filepath);

            CegSzerkesztesAblak.szerkesztettCegUtvonala = kattintottCeg.filepath;

            SzervEgysegListabaToltese();
        }

        private void Szerv_TorlesGomb_Click(object sender, EventArgs e)
        {
            if (szervezetiEgysegLista.SelectedItems.Count == 0) return;

            foreach (ListViewItem item in szervezetiEgysegLista.SelectedItems)
            {
                SzervezetiEgyseg.Torles(kattintottCeg, item.Text, item.Tag.ToString());
                item.Remove();
            }
            Frissites(false);
        }

        private void Szerv_HozzadasGomb_Click(object sender, EventArgs e)
        {
            if (cegLista.SelectedItems.Count > 1 || cegLista.SelectedItems.Count == 0) return;

            SzervezetiEgysegSzerkesztesAblak.code = false;
            foreach (ListViewItem item in cegLista.SelectedItems)
            {
                SzervezetiEgysegSzerkesztesAblak.kivalasztottCegUtvonala = item.Tag.ToString();
            }

            Program.SzervezetiEgysegSzerkesztesAblak.ShowDialog();
        }
    }
}
