using butik.util;
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

        protected Boolean LoadTable(ref DataGridView dgw, String sql)
        {
            String err = String.Empty;
            DataSet ds = null;

            if (SQLToolkit.SelectQuery(sql, ref ds, ref err))
            {
                dgw.DataSource = ds.Tables[0];
                return true;
            }
            else
            {
                MessageBox.Show(
                    "GREŠKA\n" + err, 
                    "GREŠKA", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                );
                return false;
            }

        }

        private void frmEmbeddedTemplate_FormClosed(object sender, FormClosedEventArgs e)
        {
            PanelHandler.RemoveTopForm();
        }

        protected void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
