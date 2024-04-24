using butik.forms;
using butik.forms.login;
using butik.forms.zaposleni;
using butik.util;
using SQLToolkitNS;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace butik
{
    public partial class frmMain : frmTemplate
    {
        private String name = String.Empty;

        public frmMain(String name)
        {
            InitializeComponent();
            this.name = name;
            lblWelcome.Text = lblWelcome.Text + "\n" + name;
        }

        private void btnZaposleni_Click(object sender, EventArgs e)
        {
            PanelHandler.AddForm(new frmZaposleniIndex());
            PanelHandler.ShowTopForm();
        }
    }
}
