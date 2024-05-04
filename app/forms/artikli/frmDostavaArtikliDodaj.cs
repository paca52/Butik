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

namespace butik.forms.artikli
{
    public partial class frmDostavaArtikliDodaj : butik.forms.artikli.frmDostavaArtikliTemplate
    {
        public frmDostavaArtikliDodaj(frmDostavaArtikli parent) : base(parent)
        {
            InitializeComponent();
            this.parent = parent;
            PopulateIdCombo();
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
                if (!artikl.DodajUBazu())
                {
                    MessageUtil.ShowError("Greška pri čuvanju artikla u bazi!");
                    return;
                }
            }
            else
            {
                artikl = new ArtiklModel(id);
                artikl.Dostavljena_kolicina = Convert.ToInt32(tBoxDostavljenaKolicina.Text);
            }

            if (!artikl.IsValid())
            {
                MessageUtil.ShowError("Parametri za ovaj artikl su pogrešni!");
                return;
            }

            parent.AddToList(ref artikl);
            this.Close();
        }
    }
}
