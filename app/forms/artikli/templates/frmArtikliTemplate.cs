using butik.models;
using butik.util;
using System;

namespace butik.forms.artikli.templates
{
    public partial class frmArtikliTemplate : butik.forms.frmEmbeddedTemplate
    {
        ArtiklModel model;
        [Obsolete("Designer only", true)]
        public frmArtikliTemplate()
        {
            InitializeComponent();
        }
        public frmArtikliTemplate(long id)
        {
            InitializeComponent();
            this.model = new ArtiklModel(id);
            LockInputAndPutModel(model);
        }

        protected void LockInputAndPutModel(ArtiklModel model)
        {
            cBoxId.Enabled = false;
            tBoxKolicina.Enabled = false;
            tBoxCena.Enabled = true;
            tBoxNaziv.Enabled = true;

            cBoxId.Text = model.Id.ToString();
            tBoxKolicina.Text = model.Kolicina.ToString();
            tBoxCena.Text = model.Cena.ToString();
            tBoxNaziv.Text = model.Naziv;
        }

        protected void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            PanelHandler.EmptyFormStack();
            PanelHandler.AddForm(new frmArtikliIndex());
            PanelHandler.ShowTopForm();
        }

        private void tBoxCena_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            Char key = e.KeyChar;
            if (Char.IsDigit(key) || Char.IsControl(key)) return;
            if (key == '.' && tBoxCena.Text.Contains(".") == false) return;
            e.Handled = true;
        }
        protected Boolean ValidateInputFields()
        {
            if (tBoxNaziv.Text.Length == 0)
            {
                lblNazivGreska.Text = "Polje za naziv ne sme biti prazno!";
                tBoxNaziv.Focus();
                return false;
            }
            else
            {
                lblNazivGreska.Text = "";
            }

            try
            {
                Convert.ToDecimal(tBoxCena.Text);
                lblCenaGreska.Text = "";
            }
            catch
            {
                lblCenaGreska.Text = "Nedozvoljena cena!";
                tBoxCena.Focus();
                return false;
            }

            return true;
        }

        private void frmArtikliTemplate_Load(object sender, EventArgs e)
        {
            lblCenaGreska.Text = "";
            lblNazivGreska.Text = "";
        }
    }
}
