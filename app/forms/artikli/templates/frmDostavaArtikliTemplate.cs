using butik.models;
using butik.util;
using SQLToolkitNS;
using System;
using System.Data.SqlClient;

namespace butik.forms.artikli
{
    public partial class frmDostavaArtikliTemplate : butik.forms.frmEmbeddedTemplate
    {
        protected frmDostavaArtikli parent;

        [Obsolete("Designer only", true)]
        public frmDostavaArtikliTemplate()
        {
            InitializeComponent();
        }

        public frmDostavaArtikliTemplate(frmDostavaArtikli parent)
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
            tBoxDostavljenaKolicina.Focus();
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

            cBoxId.Text = model.Id.ToString();
            tBoxKolicina.Text = model.Kolicina.ToString();
            tBoxCena.Text = model.Cena.ToString();
            tBoxNaziv.Text = model.Naziv;
            tBoxDostavljenaKolicina.Text = model.Dostavljena_kolicina.ToString();
        }

        protected void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tBoxCena_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) e.Handled = true;
        }
    }
}
