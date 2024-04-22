using butik.forms;
using butik.forms.login;
using butik.forms.zaposleni;
using SQLToolkitNS;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace butik
{
    public partial class frmMain : frmTemplate
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnZaposleni_Click(object sender, EventArgs e)
        {
            showForm(new frmZaposleniIndex());
        }
    }
}
