using butik.forms;
using butik.forms.login;
using butik.forms.zaposleni;
using butik.util;
using SQLToolkitNS;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
                MessageBox.Show(err);
            }
        }

        private void btnZaposleni_Click(object sender, EventArgs e)
        {
            // showForm(new frmZaposleniIndex(this));
            PanelHandler.AddForm(new frmZaposleniIndex());
            PanelHandler.ShowTopForm();
        }
    }
}
