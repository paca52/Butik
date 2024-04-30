using butik.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace butik.forms.artikli
{
    public partial class frmArtikliIndex : butik.forms.frmEmbeddedTemplate
    {
        public frmArtikliIndex()
        {
            InitializeComponent();
        }

        private void frmArtikliIndex_Load(object sender, EventArgs e)
        {
            LoadTable(ref dgwArtikli, "SELECT * FROM table_artikli");
        }

        private void btnDostava_Click(object sender, EventArgs e)
        {
            PanelHandler.AddForm(new frmArtikliDostava());
            PanelHandler.ShowTopForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
