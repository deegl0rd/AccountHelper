using AccountHelper.src.Beallitasok;
using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountHelper.src.Beallitasok
{
    public partial class BeallitasokAblak : Form
    {
        public BeallitasokAblak()
        {
            InitializeComponent();
        }

        private void BeallitasokAblak_Load(object sender, EventArgs e)
        {
            beallitasokLista.GetColumn(0).ImageGetter = new ImageGetterDelegate(Beallitas.ImageGetter);
            beallitasokLista.SetObjects(Beallitas.GetBeallitas());

            beallitasokLista.SelectedIndex = 0;
        }
    }
}
