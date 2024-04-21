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

namespace butik.forms
{
    public partial class frmEmbeddedTemplate : Form
    {
        public frmEmbeddedTemplate()
        {
            InitializeComponent();
        }

        protected void LoadTable(ref DataGridView dgw, String sql)
        {
            String err = String.Empty;
            DataSet ds = null;

            SQLToolkit.setConnStr("Data Source=DESKTOP-FKAKD51;Initial Catalog=db_butik;Integrated Security=True;TrustServerCertificate=True");

            if (SQLToolkit.SelectQuery(sql, ref ds, ref err))
            {
                dgw.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show(
                    "GREŠKA\n" + err, 
                    "GREŠKA", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                );
            }

        }

        private void frmEmbeddedTemplate_Load(object sender, EventArgs e)
        {

        }
    }
}
