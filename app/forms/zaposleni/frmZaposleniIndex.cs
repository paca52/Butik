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
                MessageBox.Show("Error: " + error);
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
            designTable();
        }

        private void designTable()
        {
            dgvZaposleni.BackgroundColor = Color.White;
            dgvZaposleni.BorderStyle = BorderStyle.None;
            dgvZaposleni.RowHeadersVisible = false;
            dgvZaposleni.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvZaposleni.AllowUserToAddRows = false;
            dgvZaposleni.AllowUserToDeleteRows = false;
            dgvZaposleni.AllowUserToResizeRows = false;

            dgvZaposleni.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 71, 79);
            dgvZaposleni.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvZaposleni.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            dgvZaposleni.RowsDefaultCellStyle.BackColor = Color.FromArgb(239, 239, 239);
            dgvZaposleni.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgvZaposleni.RowsDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Regular);

            dgvZaposleni.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(211, 211, 211);
            dgvZaposleni.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

            dgvZaposleni.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvZaposleni.DefaultCellStyle.Padding = new Padding(5, 3, 5, 3);

            dgvZaposleni.Columns["jmbg"].HeaderText = "Jmbg";
            dgvZaposleni.Columns["ime"].HeaderText = "Ime";
            dgvZaposleni.Columns["prezime"].HeaderText = "Prezime";
            dgvZaposleni.Columns["tip_zaposlenog"].HeaderText = "Tip zaposlenog";
            dgvZaposleni.Columns["datum_zaposlenja"].HeaderText = "Datum zaposlenja";
            dgvZaposleni.Columns["satnica"].HeaderText = "Satnica";
            dgvZaposleni.Columns["broj_radnih_sati"].HeaderText = "Broj radnih sati";
            dgvZaposleni.Columns["premija"].HeaderText = "Premija";
            dgvZaposleni.Columns["broj_slobodnih_dana"].HeaderText = "Broj slobodnih dana";

            dgvZaposleni.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvZaposleni.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvZaposleni.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            int preferredWidth = dgvZaposleni.Columns["jmbg"].GetPreferredWidth(DataGridViewAutoSizeColumnMode.AllCells, false);
            dgvZaposleni.Columns["jmbg"].MinimumWidth = preferredWidth;
            dgvZaposleni.Columns["jmbg"].Width = preferredWidth;
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
            designTable();
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
                MessageBox.Show("Error: " + error);
                return;
            }
            DialogResult result = MessageBox.Show("Da li želite da zaista otpustite ovog radnika?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (!SQLToolkit.NonSelectQuery(sql, ref error))
                {
                    MessageBox.Show("Error: " + error);
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
