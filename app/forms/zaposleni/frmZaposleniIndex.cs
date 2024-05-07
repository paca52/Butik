using butik.forms.login;
using butik.util;
using SQLToolkitNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace butik.forms.zaposleni
{
    public partial class frmZaposleniIndex : butik.forms.frmEmbeddedTemplate
    {
        DataGridViewRow selectedRow;
        public frmZaposleniIndex()
        {
            InitializeComponent();
            dgvZaposleni.CellClick += dgvZaposleni_CellClick;
            this.Click += frmZaposleniIndex_Click;

            string sql = "SELECT id, naziv FROM table_tip_zaposlenog";
            string error = "";
            if (!SQLToolkit.SelectQuery(sql, PopulateDictionary, ref error))
            {
                MessageUtil.ShowError("Error: " + error);
            }
        }
        private void PopulateDictionary(ref SqlDataReader reader)
        {
            int id = Convert.ToInt32(reader["id"]);
            string naziv = reader["naziv"].ToString();
            if (!ZaposleniModel.tipZaposlenogMap.ContainsKey(naziv))
            {
                ZaposleniModel.tipZaposlenogMap.Add(naziv, id);
            }
        }

        private void frmZaposleniIndex_Load(object sender, EventArgs e)
        {
            btnAzuriraj.Enabled = false;
            btnAzuriraj.BackColor = SystemColors.ControlDark;
            btnOtpusti.Enabled = false;
            btnOtpusti.BackColor = SystemColors.ControlDark;
            if (!LoadTable(
                ref dgvZaposleni, 
                "SELECT jmbg, ime, prezime, naziv AS tip_zaposlenog, datum_zaposlenja, satnica, broj_radnih_sati, premija, broj_slobodnih_dana " +
                "FROM table_zaposleni " +
                "INNER JOIN table_tip_zaposlenog ON table_zaposleni.tip_zaposlenog = table_tip_zaposlenog.id"
            ))
            {
                return;
            }
            TableUtil.Design(ref dgvZaposleni);
        }

        private void frmZaposleniIndex_Click(object sender, EventArgs e)
        {
            dgvZaposleni.ClearSelection();
            btnAzuriraj.Enabled = false;
            btnAzuriraj.BackColor = SystemColors.ControlDark;
            btnOtpusti.Enabled = false;
            btnOtpusti.BackColor = SystemColors.ControlDark;
        }

        private void dgvZaposleni_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvZaposleni.Rows.Count)
            {
                selectedRow = dgvZaposleni.Rows[e.RowIndex];

                btnAzuriraj.Enabled = true;
                btnAzuriraj.BackColor = Color.FromArgb(40, 46, 54);
                btnOtpusti.Enabled = true;
                btnOtpusti.BackColor = Color.FromArgb(40, 46, 54);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvZaposleni.Enabled = true;
            dgvZaposleni.Visible = true;
            LoadTable(ref dgvZaposleni, "SELECT jmbg,ime,prezime,kategorija,datum_zaposlenja,satnica,broj_radnih_sati,premija,broj_slobodnih_dana FROM table_zaposleni");
            TableUtil.Design(ref dgvZaposleni);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZaposli_Click(object sender, EventArgs e)
        {
            PanelHandler.AddForm(new frmZaposleniZaposli());
            PanelHandler.ShowTopForm();
        }

        private void btnOtpusti_Click(object sender, EventArgs e)
        {
            ZaposleniModel.jmbg = Convert.ToString(selectedRow.Cells["jmbg"].Value);
            ZaposleniModel.ime = Convert.ToString(selectedRow.Cells["ime"].Value);
            ZaposleniModel.prezime = Convert.ToString(selectedRow.Cells["prezime"].Value);
            ZaposleniModel.tip_zaposlenog = ZaposleniModel.tipZaposlenogMap[Convert.ToString(selectedRow.Cells["tip_zaposlenog"].Value)];
            ZaposleniModel.datumZaposlenja = Convert.ToString(selectedRow.Cells["datum_zaposlenja"].Value);
            ZaposleniModel.satnica = Convert.ToInt32(selectedRow.Cells["satnica"].Value);
            ZaposleniModel.brojRadnihSati = Convert.ToInt32(selectedRow.Cells["broj_radnih_sati"].Value);
            ZaposleniModel.premija = selectedRow.Cells["premija"].Value != DBNull.Value ? Convert.ToString(selectedRow.Cells["premija"].Value) : "";
            ZaposleniModel.brojSlobodnihDana = Convert.ToInt32(selectedRow.Cells["broj_slobodnih_dana"].Value);

            String sql = "USE db_butik; IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE CONSTRAINT_NAME = 'FK_table_tip_zaposlenog_table_zaposleni') BEGIN ALTER TABLE table_tip_zaposlenog DROP CONSTRAINT FK_table_tip_zaposlenog_table_zaposleni; END; IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE CONSTRAINT_NAME = 'FK_table_racun_header_table_zaposleni') BEGIN ALTER TABLE table_racun_header DROP CONSTRAINT FK_table_racun_header_table_zaposleni; END; " +
                "DELETE FROM table_zaposleni WHERE jmbg = '" + ZaposleniModel.jmbg + "'; ";

            String error = "";

            if (!SQLToolkit.NonSelectQuery(sql, ref error))
            {
                MessageUtil.ShowError("Error: " + error);
                return;
            }
            DialogResult result = MessageUtil.DeleteBox("Da li želite da zaista otpustite ovog radnika?");

            if (result == DialogResult.Yes)
            {
                if (!SQLToolkit.NonSelectQuery(sql, ref error))
                {
                    MessageUtil.ShowError("Error: " + error);
                    return;
                }
                PanelHandler.RemoveTopForm();
                PanelHandler.AddForm(new frmZaposleniIndex());
                PanelHandler.ShowTopForm();
            }
            

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            ZaposleniModel.jmbg = Convert.ToString(selectedRow.Cells["jmbg"].Value);
            ZaposleniModel.ime = Convert.ToString(selectedRow.Cells["ime"].Value);
            ZaposleniModel.prezime = Convert.ToString(selectedRow.Cells["prezime"].Value);
            ZaposleniModel.tip_zaposlenog = ZaposleniModel.tipZaposlenogMap[Convert.ToString(selectedRow.Cells["tip_zaposlenog"].Value)];
            ZaposleniModel.datumZaposlenja = Convert.ToString(selectedRow.Cells["datum_zaposlenja"].Value);
            ZaposleniModel.satnica = Convert.ToInt32(selectedRow.Cells["satnica"].Value);
            ZaposleniModel.brojRadnihSati = Convert.ToInt32(selectedRow.Cells["broj_radnih_sati"].Value);
            ZaposleniModel.premija = selectedRow.Cells["premija"].Value != DBNull.Value ? Convert.ToString(selectedRow.Cells["premija"].Value) : "";
            ZaposleniModel.brojSlobodnihDana = Convert.ToInt32(selectedRow.Cells["broj_slobodnih_dana"].Value);

            PanelHandler.AddForm(new frmZaposleniZaposli(Convert.ToString(selectedRow.Cells["tip_zaposlenog"].Value)));
            PanelHandler.ShowTopForm();
        }
    }
}
