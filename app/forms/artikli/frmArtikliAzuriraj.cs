using butik.models;
using butik.util;
using System;
using System.Windows.Forms;

namespace butik.forms.artikli
{
    public partial class frmArtikliAzuriraj : butik.forms.frmEmbeddedTemplate
    {
        frmArtikliDostava parent;
        ArtiklModel model;

        public frmArtikliAzuriraj(frmArtikliDostava parent, ArtiklModel model)
        {
            InitializeComponent();
            this.parent = parent;
            this.model = model;

            LockInputAndPutModel(model);
            tBoxDostavljenaKolicina.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!model.IsValid())
            {
                MessageUtil.ShowError("Parametri za ovaj artikl su pogrešni!");
                return;
            }

            if (!parent.UpdateList(model.Id, Convert.ToInt32(tBoxDostavljenaKolicina.Text)))
                MessageUtil.ShowError("Greška pri ažuriranju liste!");

            this.Close();
        }

        private void LockInputAndPutModel(ArtiklModel model)
        {
            cBoxId.Enabled = false;
            tBoxKolicina.Enabled = false;
            tBoxCena.Enabled = false;
            tBoxNaziv.Enabled = false;

            cBoxId.Text = model.Id.ToString();
            tBoxKolicina.Text = model.Kolicina.ToString();
            tBoxCena.Text = model.Cena.ToString();
            tBoxNaziv.Text = model.Naziv;
            tBoxDostavljenaKolicina.Text = model.Dostavljena_kolicina.ToString();
        }
    }
}
