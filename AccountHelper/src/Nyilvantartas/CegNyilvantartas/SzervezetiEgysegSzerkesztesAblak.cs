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

        public SzervezetiEgysegSzerkesztesAblak()
        {
            InitializeComponent();
        }

        private void MentesGomb_Click(object sender, EventArgs e)
        {

        }

        private void MegseGomb_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void SzervezetiEgysegSzerkesztesAblak_Load(object sender, EventArgs e)
        {
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
    }
}
