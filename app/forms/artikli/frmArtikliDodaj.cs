using butik.models;
using SQLToolkitNS;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace butik.forms.artikli
{
    public partial class frmArtikliDodaj : butik.forms.frmEmbeddedTemplate
    {
        frmArtikliDostava parent;

        public frmArtikliDodaj(frmArtikliDostava parent)
        {
            InitializeComponent();
            this.parent = parent;
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
                MessageBox.Show("GREŠKA!\n" + err);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private long GetIdFromCombo()
        {
            if (cBoxId.Text.Length == 0) return -1;
            String id = cBoxId.Text.Split(new[] { " - " }, StringSplitOptions.None)[0];
            return Convert.ToInt64(id);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
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
            }
            else
            {
                artikl = new ArtiklModel(id);
                artikl.Dostavljena_kolicina = Convert.ToInt32(tBoxDostavljenaKolicina.Text);
            }

            if (!artikl.IsValid())
            {
                return;
            }

            if (artikl.Id == -1)
            {
                artikl.DodajUBazu();
                // artikl.PrintModel();
            }

            // artikl.AzurirajKolicinu(Convert.ToInt16(tBoxDostavljenaKolicina.Text));
            parent.AddToList(ref artikl);
            this.Close();
        }

        private void cBoxId_SelectedIndexChanged(object sender, EventArgs e)
        {
            long id = GetIdFromCombo();
            LockInputAndPutModel(id);
        }

        private void LockInputAndPutModel(long id)
        {
            tBoxKolicina.Enabled = false;
            tBoxCena.Enabled = false;
            tBoxNaziv.Enabled = false;

            ArtiklModel model = new ArtiklModel(id);

            tBoxKolicina.Text = model.Kolicina.ToString();
            tBoxCena.Text = model.Cena.ToString();
            tBoxNaziv.Text = model.Naziv;
        }

    }
}
