using butik.models;
using SQLToolkitNS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.InteropServices.WindowsRuntime;
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
            
            ArtiklModel artikl = new ArtiklModel(
                id,
                tBoxNaziv.Text,
                Convert.ToDecimal(tBoxCena.Text),
                Convert.ToInt32(tBoxKolicina.Text)
            );

            if (!artikl.IsValid())
            {
                return;
            }

            if(id == -1)
            {
                artikl.DodajUBazu();
                artikl.PrintModel();
            }

            
            parent.UpdateList(ref artikl);
            this.Close();
        }

        private void cBoxId_SelectedIndexChanged(object sender, EventArgs e)
        {
            tBoxKolicina.Enabled = false;
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
