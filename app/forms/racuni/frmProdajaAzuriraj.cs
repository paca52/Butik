using butik.models;
using butik.util;
using System;

namespace butik.forms.artikli
{
    public partial class frmProdajaAzuriraj : butik.forms.artikli.frmProdajaTemplate
    {
        ArtiklModel model;

        public frmProdajaAzuriraj(frmProdajaIndex parent, ArtiklModel model) : base(parent)
        {
            InitializeComponent();
            this.model = model;

            LockInputAndPutModel(model);
            tBoxProdataKolicina.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInputFields() == false) return;

            if (!model.IsValid())
            {
                MessageUtil.ShowError("Parametri za ovaj artikl su pogrešni!");
                return;
            }

            if (!parent.UpdateList(model.Id, Convert.ToInt32(tBoxProdataKolicina.Text)))
                MessageUtil.ShowError("Greška pri ažuriranju liste!");

            this.Close();
        }
    }
}
