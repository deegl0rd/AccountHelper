using System;
using System.Windows.Forms;

namespace AccountHelper.src
{
    public partial class NevjegyPanel : Form
    {
        public NevjegyPanel()
        {
            InitializeComponent();
        }

        private void NevjegyPanel_Load(object sender, EventArgs e)
        {
            NevjegyPanelCim.Text = Application.ProductName;
            NevjegyPanelVerSzam.Text = "verzió: " + Application.ProductVersion;
            NevjegyPanelCeg.Text = Application.CompanyName + " - Copyright © 2020";
            NevjegyPanelSzovegDoboz.Text = "A TERMÉK JELENLEG HIVATALOS LICENSSZEL NEM RENDELKEZIK!";
        }
    }
}