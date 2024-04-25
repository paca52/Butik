using butik.models;
using SQLToolkitNS;
using System;
<<<<<<< HEAD
using System.Data.SqlClient;
=======
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.InteropServices.WindowsRuntime;
>>>>>>> f886b6e2a1286236cdf80b7906b4dd5797f8e407
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
        }

        private void frmArtikliDodaj_Load(object sender, EventArgs e)
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
<<<<<<< HEAD
            ArtiklModel artikl;
            
            if (id == -1)
            {
                artikl = new ArtiklModel(
                    id, 
                    tBoxNaziv.Text,
                    Convert.ToDecimal(tBoxCena.Text),
                    Convert.ToInt32(tBoxKolicina.Text)
                );
            }
            else
            {
                artikl = new ArtiklModel(id);
            }

=======
            
            ArtiklModel artikl = new ArtiklModel(
                id,
                tBoxNaziv.Text,
                Convert.ToDecimal(tBoxCena.Text),
                Convert.ToInt32(tBoxKolicina.Text)
            );
>>>>>>> f886b6e2a1286236cdf80b7906b4dd5797f8e407

            if (!artikl.IsValid())
            {
                return;
            }

<<<<<<< HEAD
            if (artikl.Id == -1)
=======
            if(id == -1)
>>>>>>> f886b6e2a1286236cdf80b7906b4dd5797f8e407
            {
                artikl.DodajUBazu();
                artikl.PrintModel();
            }

<<<<<<< HEAD
            artikl.AzurirajKolicinu(Convert.ToInt16(tBoxDostavljenaKolicina.Text));

=======
            
>>>>>>> f886b6e2a1286236cdf80b7906b4dd5797f8e407
            parent.UpdateList(ref artikl);
            this.Close();
        }

        private void cBoxId_SelectedIndexChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            // tBoxKolicina.Enabled = false;
=======
            tBoxKolicina.Enabled = false;
>>>>>>> f886b6e2a1286236cdf80b7906b4dd5797f8e407
            tBoxCena.Enabled = false;
            tBoxNaziv.Enabled = false;

            long id = GetIdFromCombo();
            ArtiklModel model = new ArtiklModel(id);

            model.PrintModel();

            tBoxKolicina.Text = model.Kolicina.ToString();
            tBoxCena.Text = model.Cena.ToString();
            tBoxNaziv.Text = model.Naziv;
        }
    }
}
