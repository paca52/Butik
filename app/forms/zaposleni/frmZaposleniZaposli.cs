﻿using butik.util;
using SQLToolkitNS;
using System;
using System.Collections.Generic;
using System.Linq;

namespace butik.forms.zaposleni
{
    public partial class frmZaposleniZaposli : butik.forms.frmEmbeddedTemplate
    {
        public frmZaposleniZaposli()
        {
            InitializeComponent();
            HandleInputJmbg(tbJmbg);
            HandleInputOnlyDigits(tbBrojRadnihSati);
            HandleInputOnlyDigits(tbSatnica);
            HandleInputOnlyDigits(tbPremija);
            foreach (KeyValuePair<string, int> kvp in ZaposleniModel.tipZaposlenogMap)
            {
                cbTipZaposlenog.Items.Add(kvp.Key);
            }
            dtpDatumZaposlenja.CustomFormat = "yyyy-MM-dd";
        }

        public frmZaposleniZaposli(String tipZaposlenogNaziv)
        {
            InitializeComponent();

            HandleInputJmbg(tbJmbg);
            HandleInputOnlyDigits(tbBrojRadnihSati);
            HandleInputOnlyDigits(tbSatnica);
            HandleInputOnlyDigits(tbPremija);
            foreach (KeyValuePair<string, int> kvp in ZaposleniModel.tipZaposlenogMap)
            {
                cbTipZaposlenog.Items.Add(kvp.Key);
            }
            tbJmbg.Text = ZaposleniModel.jmbg;
            tbIme.Text = ZaposleniModel.ime;
            tbPrezime.Text = ZaposleniModel.prezime;
            cbTipZaposlenog.Text = tipZaposlenogNaziv;
            dtpDatumZaposlenja.Text = ZaposleniModel.datumZaposlenja;
            tbSatnica.Text = ZaposleniModel.satnica == -1 ? "" : ZaposleniModel.satnica.ToString();
            tbBrojRadnihSati.Text = ZaposleniModel.brojRadnihSati == -1 ? "" : ZaposleniModel.brojRadnihSati.ToString();
            tbPremija.Text = ZaposleniModel.premija == "null" ? "" : ZaposleniModel.premija;
            dtpDatumZaposlenja.CustomFormat = "yyyy-MM-dd";

            tbJmbg.Enabled = false;
            btnZaposliSubmit.Text = "Ažuriraj";
        }

        private void HandleInputJmbg(System.Windows.Forms.TextBox tbJmbg)
        {
            tbJmbg.TextChanged += (sender, e) =>
            {
                int selectionStart = tbJmbg.SelectionStart;

                if (tbJmbg.Text.Any(c => char.IsDigit(c)))
                {
                    lblWarningCifre.Visible = false;
                }

                if (tbJmbg.Text.Any(c => !char.IsDigit(c)))
                {
                    tbJmbg.Text = tbJmbg.Text.Substring(0, tbJmbg.Text.Length - 1);
                    lblWarningCifre.Text = "Dozvoljeni karakteri su samo cifre.";
                    lblWarningCifre.Visible = true;
                }

                tbJmbg.SelectionStart = selectionStart;
            };
        }

        private void HandleInputOnlyDigits(System.Windows.Forms.TextBox tb)
        {
            tb.TextChanged += (sender, e) =>
            {
                int selectionStart = tb.SelectionStart;
                if (tb.Text.Any(c => !char.IsDigit(c)))
                {
                    tb.Text = tb.Text.Substring(0, tb.Text.Length - 1);
                }
                tb.SelectionStart = selectionStart;
            };
        }

        private void btnZaposliSubmit_Click(object sender, EventArgs e)
        {
            ZaposleniModel.jmbg = tbJmbg.Text;
            ZaposleniModel.ime = tbIme.Text;
            ZaposleniModel.prezime = tbPrezime.Text;
            ZaposleniModel.tip_zaposlenog = cbTipZaposlenog.Text == "" ? -1 : ZaposleniModel.tipZaposlenogMap[cbTipZaposlenog.Text];
            ZaposleniModel.datumZaposlenja = dtpDatumZaposlenja.Text;
            ZaposleniModel.satnica = tbSatnica.Text == "" ? -1 : Convert.ToInt32(tbSatnica.Text);
            ZaposleniModel.brojRadnihSati = tbBrojRadnihSati.Text == "" ? -1 : Convert.ToInt32(tbBrojRadnihSati.Text);
            ZaposleniModel.premija = tbPremija.Text == "" ? "null" : tbPremija.Text;
            ZaposleniModel.brojSlobodnihDana = 20;
            ZaposleniModel.username = ZaposleniModel.ime + ZaposleniModel.prezime + cbTipZaposlenog.Text;
            ZaposleniModel.password = cbTipZaposlenog.Text;

            String error = "";

            if (!ZaposleniModel.validateInput(ref error))
            {
                MessageUtil.ShowError(error);
                return;
            }

            String sql = "";
            if (btnZaposliSubmit.Text == "Zaposli")
            {
                sql = sql + "INSERT INTO dbo.table_zaposleni (jmbg,ime,prezime,broj_radnih_sati,satnica,datum_zaposlenja,broj_slobodnih_dana,username,password,tip_zaposlenog,premija) " +
                "VALUES (" +
                "'" + ZaposleniModel.jmbg + "', " +
                "'" + ZaposleniModel.ime + "', " +
                "'" + ZaposleniModel.prezime + "', " +
                "" + ZaposleniModel.brojRadnihSati + ", " +
                "" + ZaposleniModel.satnica + ", " +
                "'" + ZaposleniModel.datumZaposlenja + "', " +
                "" + ZaposleniModel.brojSlobodnihDana + ", " +
                "'" + ZaposleniModel.username + "', " +
                "'" + ZaposleniModel.password + "', " +
                "" + ZaposleniModel.tip_zaposlenog + ", ";

                if (ZaposleniModel.premija == "null") { sql += "null);"; }
                else { sql = sql + "'" + ZaposleniModel.premija + "');"; }
            }
            else
            {
                sql = sql + "UPDATE dbo.table_zaposleni SET " +
                    "ime = '" + ZaposleniModel.ime + "', " +
                    "prezime = '" + ZaposleniModel.prezime + "', " +
                    "broj_radnih_sati = " + ZaposleniModel.brojRadnihSati + ", " +
                    "satnica = " + ZaposleniModel.satnica + ", " +
                    "datum_zaposlenja = '" + ZaposleniModel.datumZaposlenja + "', " +
                    "username = '" + ZaposleniModel.username + "', " +
                    "password = '" + ZaposleniModel.password + "', " +
                    "tip_zaposlenog = " + ZaposleniModel.tip_zaposlenog + ", " +
                    "premija = ";

                if (ZaposleniModel.premija == "null") { sql += "null "; }
                else { sql = sql + "'" + ZaposleniModel.premija + "' "; }

                sql = sql + "WHERE jmbg = '" + ZaposleniModel.jmbg + "';";
            }

            if (!SQLToolkit.NonSelectQuery(sql, ref error))
            {
                MessageUtil.ShowError("Error: " + error);
                return;
            }
            PanelHandler.RemoveTopForm();
            PanelHandler.RemoveTopForm();
            PanelHandler.AddForm(new frmZaposleniIndex());
            PanelHandler.ShowTopForm();
        }

        private void btnZaposliExit_Click(object sender, EventArgs e)
        {
            PanelHandler.RemoveTopForm();
        }
    }
}
