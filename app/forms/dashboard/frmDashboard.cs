using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SQLToolkitNS;
using butik.forms.dashboard;

namespace butik.forms.dashboard
{
    public partial class frmDashboard : frmEmbeddedTemplate
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void LoadChartData(string sql, Chart chart, String title, String xValue, String yValue)
        {
            DataSet ds = new DataSet();
            string err = String.Empty;
            SQLToolkit.SelectQuery(sql, ref ds, ref err);

            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show("Error loading data: " + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable firstTable = ds.Tables[0];

            chart.DataSource = firstTable;

            // Create series
            Series series = new Series();
            series.XValueMember = xValue;
            series.YValueMembers = yValue;
            series.ChartType = SeriesChartType.Column;

            chart.Series.Clear(); // Clear existing series to avoid duplication
            chart.Series.Add(series);

            // Customize chart appearance
            chart.Titles.Clear(); // Clear existing titles to avoid duplication
            chart.Titles.Add(title);
            chart.ChartAreas[0].AxisX.Interval = 1;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            queryForm t = new queryForm();
            t.ShowDialog();

            String num = queryForm.output;
            

                String sql = "SELECT TOP " + num + " a.naziv AS ProductName, SUM(rb.kolicina) " +
                    "AS TotalSold FROM " +
                    "table_racun_body rb JOIN table_artikli a ON rb.id_artikla " +
                    " = a.id_artikla GROUP BY " +
                    "a.naziv ORDER BY TotalSold DESC ;";
               LoadChartData(sql, chart1, "Najprodavaniji artikli", "ProductName", "Totalsold");
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            frmQueryRadnik t = new frmQueryRadnik();
            t.ShowDialog();
            String jmbg = frmQueryRadnik.jmbg;
            String dateFrom = frmQueryRadnik.datumOd;
            String dateTo = frmQueryRadnik.datumDo;
            
            String sql = "SELECT z.ime, z.prezime, z.broj_radnih_sati AS HoursWorked, SUM(rh.ukupna_cena) AS TotalSales " +
            "FROM table_zaposleni z " +
            "JOIN table_racun_header rh ON z.jmbg = rh.id_zaposleni " +
            "WHERE z.ime = @ime AND z.prezime = @prezime AND rh.datum BETWEEN @dateFrom AND @dateTo " +
            "GROUP BY z.ime, z.prezime " +
            "ORDER BY TotalSales DESC;";
            LoadChartData(sql, chart1, "Performanse radnika", "HoursWorked", "TotalSales");


        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmQueryDatumProdaje t = new frmQueryDatumProdaje();
            t.ShowDialog();
            String sql = "SELECT DATE(datum) AS Date, SUM(ukupna_cena) AS TotalSales" +
            "FROM table_racun_header WHERE datum BETWEEN '2024-01-01' AND '2024-04-24' GROUP BY" +
            "DATE(datum) ORDER BY Date";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
