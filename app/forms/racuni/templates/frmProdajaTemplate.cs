using butik.models;
using butik.util;
using SQLToolkitNS;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace butik.forms.artikli
{
    public partial class frmProdajaTemplate : butik.forms.frmEmbeddedTemplate
    {
        protected frmProdajaIndex parent;

        [Obsolete("Designer only", true)]
        public frmProdajaTemplate()
        {
            InitializeComponent();
        }

        public frmProdajaTemplate(frmProdajaIndex parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        protected Boolean PopulateIdCombo()
        {
            String err = String.Empty;

            if (!SQLToolkit.SelectQuery(
                "SELECT id_artikla, naziv FROM table_artikli",
                (ref SqlDataReader dr) =>
                {
                    cBoxId.Items.Add(dr.GetInt64(0).ToString() + " - " + dr.GetString(1));
                },
                ref err
            ))
            {
                MessageUtil.ShowError("GREŠKA!\n" + err);
                return false;
            }
            return true;
        }

        protected long GetIdFromCombo()
        {
            if (cBoxId.Text.Length == 0) return -1;
            String id = cBoxId.Text.Split(new[] { " - " }, StringSplitOptions.None)[0];
            return Convert.ToInt64(id);
        }

        protected void cBoxId_SelectedIndexChanged(object sender, EventArgs e)
        {
            long id = GetIdFromCombo();
            LockInputAndPutModel(id);
            tBoxProdataKolicina.Focus();
        }

        protected void LockInputAndPutModel(long id)
        {
            tBoxKolicina.Enabled = false;
            tBoxCena.Enabled = false;
            tBoxNaziv.Enabled = false;

            ArtiklModel model = new ArtiklModel(id);

            tBoxKolicina.Text = model.Kolicina.ToString();
            tBoxCena.Text = model.Cena.ToString();
            tBoxNaziv.Text = model.Naziv;
        }

        protected void LockInputAndPutModel(ArtiklModel model)
        {
            cBoxId.Enabled = false;
            tBoxKolicina.Enabled = false;
            tBoxCena.Enabled = false;
            tBoxNaziv.Enabled = false;

            cBoxId.Items.Add(model.Id.ToString());
            cBoxId.SelectedIndex = 0;
            tBoxKolicina.Text = model.Kolicina.ToString();
            tBoxCena.Text = model.Cena.ToString();
            tBoxNaziv.Text = model.Naziv;
            tBoxProdataKolicina.Text = model.Delta_kolicina.ToString();
        }

        protected void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tBoxProdataKolicina_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            Char key = e.KeyChar;
            if (Char.IsControl(key)) return;
            if (!Char.IsDigit(key))
            {
                e.Handled = true;
                return;
            }
            int prodata_kolicina = Convert.ToInt32(tBoxProdataKolicina.Text + key);
            int dostupna_kolicina = Convert.ToInt32(tBoxKolicina.Text);
            if (prodata_kolicina > dostupna_kolicina)
            {
                MessageBox.Show("Nije moguće prodati više od dostupne količine!");
                e.Handled = true;
                return;
            }
        }

        protected Boolean ValidateInputFields()
        {
            if (cBoxId.Text.Length == 0)
            {
                lblIdGreska.Text = "Odaberite ID artikla!";
                cBoxId.Focus();
                return false;
            }
            else
            {
                lblIdGreska.Text = "";
            }

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

            try
            {
                Convert.ToInt32(tBoxProdataKolicina.Text);
                lblDostavljenaKolicinaGreska.Text = "";
            }
            catch
            {
                lblDostavljenaKolicinaGreska.Text = "Nedozvoljena dostavljena količina!";
                tBoxProdataKolicina.Focus();
                return false;
            }

            return true;
        }

        private void frmDostavaArtikliTemplate_Load(object sender, EventArgs e)
        {
            lblCenaGreska.Text = "";
            lblDostavljenaKolicinaGreska.Text = "";
            lblNazivGreska.Text = "";
            lblIdGreska.Text = "";
        }
    }
}
