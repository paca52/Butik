using butik.models;
using butik.util;
using System;

namespace butik.forms.Racuni
{
    public partial class frmRacuniIndex : butik.forms.frmEmbeddedTemplate
    {
        public frmRacuniIndex()
        {
            InitializeComponent();
        }

        private void frmRacuniIndex_Load(object sender, EventArgs e)
        {
            if (!LoadTable(ref dgwRacuni, "SELECT * FROM table_Racuni"))
                MessageUtil.ShowError("Greška pri učitavanju tabele!");
            TableUtil.Design(ref dgwRacuni);
            // dgwRacuni.C
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            PanelHandler.AddForm(new frmProdajaRacuni());
            PanelHandler.ShowTopForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            long id = Convert.ToInt64(dgwRacuni.SelectedRows[0].Cells[0].Value);
            PanelHandler.AddForm(new frmRacuniUpdate(id));
            PanelHandler.ShowTopForm();
        }

        private void dgwRacuni_SelectionChanged(object sender, EventArgs e)
        {

            if (dgwRacuni.SelectedRows.Count == 1)
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
