using butik.models;
using butik.util;
using SQLToolkitNS;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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
            // dgwItems.DataSource = list;
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
        }
    }
}
