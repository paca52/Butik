using butik.models;
using butik.util;
using SQLToolkitNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace butik.forms.artikli
{
    public partial class frmArtikliUpdate : butik.forms.artikli.templates.frmArtikliTemplate
    {
        long id;
        public frmArtikliUpdate(long id) : base(id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String err = String.Empty;
            String sql = "" +
                "UPDATE dbo.table_artikli " +
                "SET naziv = '" + tBoxNaziv.Text + "', cena = " + tBoxCena.Text + " " +
                "WHERE id_artikla = " + this.id;
            if(!SQLToolkit.NonSelectQuery(sql, ref err))
            {
                MessageUtil.ShowError("Greška pri ažuriranju artikla!\n" + err);
            }

            this.Close();
        }

        private void frmArtikliUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            PanelHandler.RemoveTopForm();
            PanelHandler.AddForm(new frmArtikliIndex());
            PanelHandler.ShowTopForm();
        }
    }
}
