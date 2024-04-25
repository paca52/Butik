using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Linq;
using SQLToolkitNS;
using System.Data.SqlClient;
using butik.util;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Collections;

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

            tbJmbg.Text = ZaposleniModel.jmbg;
            tbIme.Text = ZaposleniModel.ime;
            tbPrezime.Text = ZaposleniModel.prezime;
            cbTipZaposlenog.Text = tipZaposlenogNaziv;
            dtpDatumZaposlenja.Text = ZaposleniModel.datumZaposlenja;
            tbSatnica.Text = ZaposleniModel.satnica == -1 ? "" : ZaposleniModel.satnica.ToString();
            tbBrojRadnihSati.Text = ZaposleniModel.brojRadnihSati == -1 ? "" : ZaposleniModel.brojRadnihSati.ToString();
            tbPremija.Text = ZaposleniModel.premija == "null" ? "" : ZaposleniModel.premija;

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
                MessageBox.Show(
                    error,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            
            String sql = "INSERT INTO dbo.table_zaposleni (jmbg,ime,prezime,broj_radnih_sati,satnica,datum_zaposlenja,broj_slobodnih_dana,username,password,tip_zaposlenog,premija) " +
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

            if(ZaposleniModel.premija == "null") { sql += "null);"; }
            else { sql = sql + "'" + ZaposleniModel.premija + "');"; }

            if(!SQLToolkit.NonSelectQuery(sql, ref error))
            {
                MessageBox.Show("Error: " + error);
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
