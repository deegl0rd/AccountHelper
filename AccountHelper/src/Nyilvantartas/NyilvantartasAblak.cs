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

        public NyilvantartasAblak()
        {
            InitializeComponent();
            formInstance = this;
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
            tartalomDoboz.Text = "";
            cegLista.Items.Clear();
            Ceg.Betoltes();
            ListViewItem item;

            foreach (Ceg c in Ceg.lista)
            {
                item = new ListViewItem(c.ceg_neve)
                {
                    UseItemStyleForSubItems = false,
                    Tag = ReverseSlash(c.path)
                };
                item.SubItems.Add(c.fajlNev);

                cegLista.Items.Add(item);
            }
        }

        private void NyilvantartasAblak_Load(object sender, EventArgs e)
        {
            Frissites();
        }

        private void TorlesGomb_Click(object sender, EventArgs e)
        {
            if (cegLista.SelectedItems.Count == 0) return;

            foreach (ListViewItem item in cegLista.SelectedItems)
            {
                File.Delete(item.Tag.ToString());
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
                SzerkesztesAblak.szerkesztett = item.Tag.ToString();
            }
            Program.SzerkesztesAblak.ShowDialog();
        }

        private void CegLista_MouseClick(object sender, MouseEventArgs e)
        {
            if (cegLista.FocusedItem.Bounds.Contains(e.Location))
            {
                tartalomDoboz.Text = File.ReadAllText(cegLista.FocusedItem.Tag.ToString());
            }
        }
    }
}
