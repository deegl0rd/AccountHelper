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
    public partial class UpdateAblak : Form
    {
        public UpdateAblak()
        {
            InitializeComponent();
        }

        private void UpdateAblak_Load(object sender, EventArgs e)
        {
            jelenlegiVerzioDoboz.Text = Application.ProductVersion;
            legujabbVerzioDoboz.Text = AutoUpdater.GetGitRepoVersion();
        }

        private void OkGomb_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GitLinkGomb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/deegl0rd/AccountHelper");
        }
    }
}
