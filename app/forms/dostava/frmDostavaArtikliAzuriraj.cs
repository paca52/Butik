using butik.models;
using butik.util;
using System;

namespace butik.forms.artikli
{
    public partial class frmDostavaArtikliAzuriraj : butik.forms.artikli.frmDostavaArtikliTemplate
    {
        ArtiklModel model;

        public frmDostavaArtikliAzuriraj(frmDostavaIndex parent, ArtiklModel model) : base(parent)
        {
            InitializeComponent();
            this.model = model;

            LockInputAndPutModel(model);
            tBoxDostavljenaKolicina.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInputFields() == false) return;

            if (!model.IsValid())
            {
                MessageUtil.ShowError("Parametri za ovaj artikl su pogrešni!");
                return;
            }

            if (!parent.UpdateList(model.Id, Convert.ToInt32(tBoxDostavljenaKolicina.Text)))
                MessageUtil.ShowError("Greška pri ažuriranju liste!");

            this.Close();
        }
    }
}
