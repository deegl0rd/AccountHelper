using AccountHelper.Properties;
using AccountHelper.src.Nyilvantartas;
using AccountHelper.src.XKROlvaso;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountHelper.src
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
        }

        private void NyilvántartásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.NyilvantartasAblak.ShowDialog();
        }

        private void XKROlvasóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.KezeloAblak.ShowDialog();
        }


        private void BeállításokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.BeallitasokAblak.ShowDialog();
        }

        private void KilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Idozito_Tick(object sender, EventArgs e)
        {
            Ceg.Betoltes();
            IdoSav.Text = DateTime.Now.ToString();
            CegekSav.Text = Ceg.lista.Count.ToString() + " db cég betöltve";
            VerzioszamSav.Text = "Verzió: " +  Application.ProductVersion;
            VerzioszamSav.Alignment = ToolStripItemAlignment.Right;
        }

        private void StartupForm_Load(object sender, EventArgs e)
        {
            Idozito.Start();
        }
        private void StartupForm_Shown(object sender, EventArgs e)
        {
            if (!AutoUpdater.IsNewestVersion())
            {
                if (Settings.Default["checkForUpdate"].Equals(true))
                {
                    new UpdateAblak().ShowDialog();
                }
            }
        }


        private void VerzioszamSav_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/deegl0rd/AccountHelper");
        }
    }
}
