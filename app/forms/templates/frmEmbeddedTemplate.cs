using butik.util;
using SQLToolkitNS;
using System;
using System.Data;
using System.Drawing;
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
                MessageUtil.ShowError(err);
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

        private void frmEmbeddedTemplate_Load(object sender, EventArgs e)
        {
            this.Size = new Size(747, 531);
        }
    }
}
