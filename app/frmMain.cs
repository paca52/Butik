using butik.forms;
using butik.forms.dashboard;
using butik.forms.zaposleni;
using SQLToolkitNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace butik
{
    public partial class frmMain : frmTemplate
    {
        public frmMain()
        {
            SQLToolkit.setConnStr("Data Source=DESKTOP-0V4TF3H;Initial Catalog=db_butik;Integrated Security=True");
            InitializeComponent();
        }

        private void btnZaposleni_Click(object sender, EventArgs e)
        {
            showForm(new frmZaposleniIndex());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            showForm(new frmDashboard());
        }
    }
}
