using butik.models;
using butik.util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace butik.forms.artikli
{
    public partial class frmArtikliDostava : butik.forms.frmEmbeddedTemplate
    {
        private List<ArtiklModel> list = new List<ArtiklModel>();
        public Boolean UpdateList(long id, int Dostavljena_kolicina)
        {

            int i = list.FindIndex(item => item.Id == id);

            if(i == -1)
            {
                MessageBox.Show("Greška pri Ažuriranju!");
                return false;
            }

            list[i].Dostavljena_kolicina = Dostavljena_kolicina;

            RefreshList();
            return true;
        }

        public Boolean AddToList(ref ArtiklModel model)
        {
            long id = model.Id;

            int i = list.FindIndex(item => item.Id == id);

            if (i != -1)
                list[i].Dostavljena_kolicina += model.Dostavljena_kolicina;
            else
                list.Add(model);

            RefreshList();
            return true;
        }

        protected void RefreshList()
        {
            dgwItems.DataSource = null;
            dgwItems.DataSource = list;
            dgwItems.Refresh();
        }

        protected Boolean DeleteFromList(long id)
        {
            int i = list.FindIndex(model => model.Id == id);

            if (i == -1) return false;

            list.RemoveAt(i);
            return true;
        }

        public frmArtikliDostava()
        {
            InitializeComponent();
            list.Clear();
            dgwItems.DataSource = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PanelHandler.AddForm(new frmArtikliDodaj(this));
            PanelHandler.ShowTopForm();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            String err = String.Empty;

            DostavaModel dostava = new DostavaModel();
            if (!dostava.NovaDostava())
            {
                MessageBox.Show("Greska pri pravljenju dostave!");
            }

            foreach (var model in list)
            {
                model.AzurirajKolicinu();
            }

            DostavaArtikliModel akcija = new DostavaArtikliModel(dostava.Id, list);
            if (!akcija.Sacuvaj())
            {
                MessageBox.Show("Greska pri cuvanju dostave!!!");
                return;
            }


            this.Close();
            PanelHandler.RemoveTopForm();
            PanelHandler.AddForm(new frmArtikliIndex());
            PanelHandler.ShowTopForm();
        }

        private void dgwItems_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            long id = Convert.ToInt64(e.Row.Cells[0].Value);
            DeleteFromList(id);
        }

        private void dgwItems_SelectionChanged(object sender, EventArgs e)
        {
            // MessageBox.Show($"PLUH!!!! {dgwItems.SelectedRows.Count}");
            if (dgwItems.SelectedRows.Count == 0)
            {
                btnRemove.Enabled = false;
                btnUpdate.Enabled = false;
            }
            else if (dgwItems.SelectedRows.Count == 1)
            {
                btnRemove.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else if (dgwItems.SelectedRows.Count > 1)
            {
                btnRemove.Enabled = true;
                btnUpdate.Enabled = false;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(
                "Da li ste sigurni da želite da obrišete odabrane artikle iz liste?",
                "",
                MessageBoxButtons.YesNo
            );

            if (res == DialogResult.No) return;

            foreach (DataGridViewRow row in dgwItems.SelectedRows)
            {
                long id = Convert.ToInt64(row.Cells[0].Value);
                DeleteFromList(id);
            }
            RefreshList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ArtiklModel model = new ArtiklModel(
                Convert.ToInt64(dgwItems.SelectedRows[0].Cells[0].Value),
                Convert.ToString(dgwItems.SelectedRows[0].Cells[1].Value),
                Convert.ToDecimal(dgwItems.SelectedRows[0].Cells[2].Value),
                Convert.ToInt32(dgwItems.SelectedRows[0].Cells[3].Value),
                Convert.ToInt32(dgwItems.SelectedRows[0].Cells[4].Value)
            );
            PanelHandler.AddForm(new frmArtikliAzuriraj(this, model));
            PanelHandler.ShowTopForm();
        }
    }
}
