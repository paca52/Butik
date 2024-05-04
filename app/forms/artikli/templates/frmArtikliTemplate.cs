using butik.models;
using butik.util;
using SQLToolkitNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
        }
    }
}
