using butik.models;
using butik.util;
using System;

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
            if (!LoadTable(ref dgwArtikli, "SELECT * FROM table_artikli"))
                MessageUtil.ShowError("Greška pri učitavanju tabele!");
            TableUtil.Design(ref dgwArtikli);
            // dgwArtikli.C
        }

        private void btnDostava_Click(object sender, EventArgs e)
        {
            PanelHandler.AddForm(new frmDostavaIndex());
            PanelHandler.ShowTopForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            long id = Convert.ToInt64(dgwArtikli.SelectedRows[0].Cells[0].Value);
            PanelHandler.AddForm(new frmArtikliUpdate(id));
            PanelHandler.ShowTopForm();
        }

        private void dgwArtikli_SelectionChanged(object sender, EventArgs e)
        {

            if (dgwArtikli.SelectedRows.Count == 1)
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }
    }
}
