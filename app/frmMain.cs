using butik.forms;
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
            SQLToolkit.setConnStr(global::butik.Properties.Settings.Default.connStr);
            InitializeComponent();
        }

        private void btnZaposleni_Click(object sender, EventArgs e)
        {
            showForm(new frmZaposleniIndex());
        }
    }
}
