using SQLToolkitNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace butik.forms.zaposleni
{
    public partial class frmZaposleniIndex : butik.forms.frmEmbeddedTemplate
    {
        public frmZaposleniIndex()
        {
            InitializeComponent();
        }

        private void frmZaposleniIndex_Load(object sender, EventArgs e)
        {
            dgvZaposleni.Enabled = true;
            dgvZaposleni.Visible = true;
            if(!LoadTable(
                ref dgvZaposleni, 
                "SELECT jmbg, ime, prezime, kategorija, datum_zaposlenja, satnica, broj_radnih_sati, premija, broj_slobodnih_dana " +
                "FROM table_zaposleni"
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
            dgvZaposleni.Columns["kategorija"].HeaderText = "Kategorija";
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

        private void button2_Click(object sender, EventArgs e)
        {
            dgvZaposleni.Enabled = false;
            dgvZaposleni.Visible = false;
        }
    }
}
