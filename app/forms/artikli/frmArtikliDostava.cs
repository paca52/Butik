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

        public Boolean UpdateList(ref ArtiklModel model)
        {
            Boolean is_in_list = false;
            foreach (var item in list)
            {
                if (item.Id == model.Id)
                {
                    item.Dostavljena_kolicina += model.Dostavljena_kolicina;
                    is_in_list = true;
                }
            }

            if (is_in_list == false)
            {
                list.Add(model);
            }

            dgwItems.DataSource = null;
            dgwItems.DataSource = list;
            dgwItems.Refresh();
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
            foreach (var item in list)
            {
                if (item.Id == id)
                {
                    list.Remove(item);
                }
            }
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
    }
}
