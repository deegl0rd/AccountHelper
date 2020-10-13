using AccountHelper.Properties;
using System;
using System.Windows.Forms;

namespace AccountHelper.src
{
    public partial class HitelesitoAblak : Form
    {

        public HitelesitoAblak()
        {
            InitializeComponent();
        }

    //    private void Gomb_Click(object sender, EventArgs e)
    //    {
    //        Program.sql.Aktivalas(szovegDoboz.Text);

    //        if (Program.sql.Hitelesitve())
    //        {
    //            Settings.Default["licenszKulcs"] = szovegDoboz.Text;
    //            Settings.Default.Save();
    //            Application.Exit();
    //        }
    //    }

    //    private void HitelesitoAblak_Load(object sender, EventArgs e)
    //    {
    //        szovegDoboz.Text = Settings.Default["licenszKulcs"].ToString();
    //    }
    }
}
