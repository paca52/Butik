﻿using butik.forms;
using butik.forms.artikli;
using butik.forms.zaposleni;
using butik.util;
using SQLToolkitNS;
using System;
using System.Data.SqlClient;

namespace butik
{
    public partial class frmMain : frmTemplate
    {
        private String name = String.Empty;

        public frmMain(String name, long tip_zaposlenog)
        {
            InitializeComponent();
            this.name = name;
            lblWelcome.Text = lblWelcome.Text + "\n" + name;

            String err = String.Empty;
            String sql =
                "SELECT id, dashboard, zaposleni, racuni, artikli " +
            "FROM table_tip_zaposlenog " +
                "WHERE id= " + tip_zaposlenog;

            if (!SQLToolkit.SelectQuery(
                sql,
                (ref SqlDataReader dr) =>
                {
                    btnDashboard.Enabled = dr.GetBoolean(1);
                    btnZaposleni.Enabled = dr.GetBoolean(2);
                    btnRacuni.Enabled = dr.GetBoolean(3);
                    btnArtikli.Enabled = dr.GetBoolean(4);
                },
                ref err
            ))
            {
                MessageUtil.ShowError(err);
            }
        }

        private void btnZaposleni_Click(object sender, EventArgs e)
        {
            // showForm(new frmZaposleniIndex(this));
            PanelHandler.EmptyFormStack();
            PanelHandler.AddForm(new frmZaposleniIndex());
            PanelHandler.ShowTopForm();
        }

        private void btnArtikli_Click(object sender, EventArgs e)
        {
            PanelHandler.EmptyFormStack();
            PanelHandler.AddForm(new frmArtikliIndex());
            PanelHandler.ShowTopForm();
        }

        private void btnRacuni_Click(object sender, EventArgs e)
        {
            PanelHandler.EmptyFormStack();
            PanelHandler.AddForm(new frmProdajaIndex());
            PanelHandler.ShowTopForm();
        }
    }
}
