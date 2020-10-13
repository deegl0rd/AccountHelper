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
        public NyilvantartasAblak()
        {
            InitializeComponent();
        }

        private string ReverseSlash(string input)
        {
            return input.Replace("\\", "/");
        }

        private void MegseGomb_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public void Frissites()
        {
            cegLista.Items.Clear();
            Ceg.Betoltes();
            ListViewItem item;
            foreach (Ceg c in Ceg.lista)
            {
                item = new ListViewItem(c.ceg_neve)
                {
                    UseItemStyleForSubItems = false,
                };
                item.SubItems.Add(ReverseSlash(c.path));

                cegLista.Items.Add(item);
            }
        }

        private void NyilvantartasAblak_Load(object sender, EventArgs e)
        {
            FrissitesGomb_Click(null, e);
        }

        private void TorlesGomb_Click(object sender, EventArgs e)
        {
            if (cegLista.SelectedItems.Count == 0) return;

            foreach (ListViewItem item in cegLista.SelectedItems)
            {
                File.Delete(item.SubItems[1].Text);
                item.Remove();
            }
            Frissites();
        }

        private void FrissitesGomb_Click(object sender, EventArgs e)
        {
            Frissites();
        }

        private void HozzaadasGomb_Click(object sender, EventArgs e)
        {
            SzerkesztesAblak.code = false;
            Program.SzerkesztesAblak.ShowDialog();
        }

        private void SzerkesztesGomb_Click(object sender, EventArgs e)
        {
            if (cegLista.SelectedItems.Count > 1 || cegLista.SelectedItems.Count == 0) return;

            SzerkesztesAblak.code = true;
            foreach (ListViewItem item in cegLista.SelectedItems)
            {
                SzerkesztesAblak.szerkesztett = item.SubItems[1].Text;
            }
            Program.SzerkesztesAblak.ShowDialog();
        }
    }
}
