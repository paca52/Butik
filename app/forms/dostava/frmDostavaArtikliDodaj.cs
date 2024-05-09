using butik.models;
using butik.util;
using System;

namespace butik.forms.artikli
{
    public partial class frmDostavaArtikliDodaj : butik.forms.artikli.frmDostavaArtikliTemplate
    {
        public frmDostavaArtikliDodaj(frmDostavaIndex parent) : base(parent)
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

            if (id == -1)
            {
                artikl = new ArtiklModel(
                    id,
                    tBoxNaziv.Text,
                    Convert.ToDecimal(tBoxCena.Text),
                    Convert.ToInt32(tBoxKolicina.Text),
                    Convert.ToInt32(tBoxDostavljenaKolicina.Text)
                );
                if (!artikl.DodajUBazu())
                {
                    MessageUtil.ShowError("Greška pri čuvanju artikla u bazi!");
                    return;
                }
            }
            else
            {
                artikl = new ArtiklModel(id);
                artikl.Delta_kolicina = Convert.ToInt32(tBoxDostavljenaKolicina.Text);
            }

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
