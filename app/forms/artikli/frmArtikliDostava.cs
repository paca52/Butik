using butik.models;
using butik.util;
using SQLToolkitNS;
using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.Runtime.InteropServices;
>>>>>>> f886b6e2a1286236cdf80b7906b4dd5797f8e407
using System.Windows.Forms;

namespace butik.forms.artikli
{
    public partial class frmArtikliDostava : butik.forms.frmEmbeddedTemplate
    {
        private List<ArtiklModel> list = new List<ArtiklModel>();

        public Boolean UpdateList(ref ArtiklModel model)
        {
            list.Add(model);
            dgwItems.DataSource = null;
            dgwItems.DataSource = list;
            dgwItems.Refresh();
            return true;
        }

        public frmArtikliDostava()
        {
            InitializeComponent();
            list.Clear();
<<<<<<< HEAD
=======
            // dgwItems.DataSource = list;
>>>>>>> f886b6e2a1286236cdf80b7906b4dd5797f8e407
            dgwItems.DataSource = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PanelHandler.AddForm(new frmArtikliDodaj(this));
            PanelHandler.ShowTopForm();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            String err = String.Empty;

            DostavaModel dostava = new DostavaModel();
            dostava.NovaDostava();

            DostavaArtikliModel akcija = new DostavaArtikliModel(dostava.Id, list);
            akcija.Sacuvaj();

            
=======
            long id = -1;
            String err = String.Empty;
            String sql = "INSERT INTO dbo.table_dostava (datum_dostave, dostavljac) " +
                "VALUES ('2024-1-1', 'pluh!');";
            MessageBox.Show(sql);
            // NAPRAVI DOSTAVU
            if (!SQLToolkit.NonSelectQueryAndReturnId(
                sql,
                ref id,
                ref err
            ))
            {
                MessageBox.Show("Prso\n" + err);
            } else
            {
                MessageBox.Show("Dostava je dodata!");
            }
>>>>>>> f886b6e2a1286236cdf80b7906b4dd5797f8e407
        }
    }
}
