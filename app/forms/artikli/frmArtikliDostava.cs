using butik.models;
using butik.util;
using SQLToolkitNS;
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
            list.Add(model);
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
            dostava.NovaDostava();

            DostavaArtikliModel akcija = new DostavaArtikliModel(dostava.Id, list);
            akcija.Sacuvaj();
        }
    }
}
