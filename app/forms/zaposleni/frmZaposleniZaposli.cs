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

namespace butik.forms.zaposleni
{
    public partial class frmZaposleniZaposli : butik.forms.frmEmbeddedTemplate
    {
        public frmZaposleniZaposli()
        {
            InitializeComponent();
            HandleInputRealTime(tbJmbg);
            string sql = "SELECT id, naziv FROM table_tip_zaposlenog";
            string error = "";
            if (!SQLToolkit.SelectQuery(sql, PopulateComboBox, ref error))
            {
                MessageBox.Show("Error: " + error);
            }

        }

        private void PopulateComboBox(ref SqlDataReader reader)
        {
            cbTipZaposlenog.Items.Add(reader["naziv"].ToString());
        }

        private void HandleInputRealTime(System.Windows.Forms.TextBox tbJmbg)
        {
            tbJmbg.TextChanged += (sender, e) =>
            {
                int selectionStart = tbJmbg.SelectionStart; // Save the cursor position

                // if user entered the digit
                if (tbJmbg.Text.Any(c => char.IsDigit(c)))
                {
                    // Non-digit character detected, remove the last entered character
                    // Optionally, provide feedback to the user
                    lblWarningCifre.Visible = false;
                }

                // Check if the entered text contains any non-digit characters
                if (tbJmbg.Text.Any(c => !char.IsDigit(c)))
                {
                    // Non-digit character detected, remove the last entered character
                    tbJmbg.Text = tbJmbg.Text.Substring(0, tbJmbg.Text.Length - 1);
                    // Optionally, provide feedback to the user
                    lblWarningCifre.Text = "Dozvoljeni karakteri su samo cifre.";
                    lblWarningCifre.Visible = true;
                }

                // Limit the length of the text to 13 characters
                if (tbJmbg.Text.Length >= 13)
                {
                    // If the length exceeds 13 characters, truncate the text to 13 characters
                    tbJmbg.Text = tbJmbg.Text.Substring(0, 13);
                    lblWarningCifre.Visible = false;
                }

                // Restore the cursor position
                tbJmbg.SelectionStart = selectionStart;
            };
        }

        private void btnZaposliSubmit_Click(object sender, EventArgs e)
        {
            ZaposleniModel.jmbg = tbJmbg.Text;
            ZaposleniModel.ime = tbIme.Text;
            ZaposleniModel.prezime = tbPrezime.Text;
            ZaposleniModel.tip_zaposlenog = cbTipZaposlenog.Text;
            ZaposleniModel.datumZaposlenja = dtpDatumZaposlenja.Text;
            ZaposleniModel.satnica = Convert.ToInt32(tbSatnica.Text);
            ZaposleniModel.brojRadnihSati = Convert.ToInt32(tbBrojRadnihSati.Text);
            ZaposleniModel.premija = tbPremija.Text == "" ? "null" : tbPremija.Text;
            ZaposleniModel.brojSlobodnihDana = 20;
            

            if(ZaposleniModel.jmbg.Length < 13)
            {
                MessageBox.Show(
                    "Jmbg polje mora imati 13 karaktera!",
                    "GREŠKA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            String sql = "INSERT INTO table_zaposleni VALUES (" +
                ZaposleniModel.jmbg + "," +
                ZaposleniModel.jmbg + "," +
                ZaposleniModel.jmbg + "," +
                ZaposleniModel.jmbg + "," +
                ZaposleniModel.jmbg + "," +
                ZaposleniModel.jmbg + "," +
                ZaposleniModel.jmbg + "," +
                ZaposleniModel.jmbg + "," +
                ZaposleniModel.jmbg + "," +
                ZaposleniModel.jmbg + "," +
                ZaposleniModel.jmbg + ",";

        }
    }
}
