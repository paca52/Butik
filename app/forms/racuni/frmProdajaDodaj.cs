using butik.models;
using butik.util;
using System;

namespace butik.forms.artikli
{
    public partial class frmProdajaDodaj : butik.forms.artikli.frmProdajaTemplate
    {
        public frmProdajaDodaj(frmProdajaIndex parent) : base(parent)
        {
            InitializeComponent();
            this.parent = parent;
            PopulateIdCombo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInputFields() == false) return;

            long id = GetIdFromCombo();
            ArtiklModel artikl;

            artikl = new ArtiklModel(id);
            artikl.Delta_kolicina = Convert.ToInt32(tBoxProdataKolicina.Text);

            if (!artikl.IsValid())
            {
                MessageUtil.ShowError("Parametri za ovaj artikl su pogrešni!");
                return;
            }

            parent.AddToList(ref artikl);
            this.Close();
        }
    }
}
