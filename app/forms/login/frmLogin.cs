using butik.forms.zaposleni;
using butik.util;
using SQLToolkitNS;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace butik.forms.login
{
    public partial class frmLogin : Form
    {
        String name = String.Empty;
        long tip_zaposlenog = -1;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Boolean LogIn(String username, String password)
        {
            String err = String.Empty;
            String sql =
                "SELECT ime, username, password, tip_zaposlenog " +
                "FROM table_zaposleni " +
                "WHERE username='" + username + "' AND password='" + password + "'";

            Boolean loggedIn = false;

            if (!SQLToolkit.SelectQuery(
                sql,
                (ref SqlDataReader dr) =>
                {
                    this.name = dr.GetString(0);
                    this.tip_zaposlenog = dr.GetInt64(3);
                    loggedIn = true;
                },
                ref err
            ))
            {
                MessageBox.Show(err);
                return false;
            }

            return loggedIn;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = tBoxUsername.Text;
            String password = tBoxPassword.Text;

            if (username.Length == 0 || password.Length == 0) { return; }

            if (LogIn(username, password))
            {
                this.Hide();
                frmMain frm = new frmMain(this.name, this.tip_zaposlenog);
                PanelHandler.SetParentForm(frm);

                frm.ShowDialog();
                frm.Close();

                PanelHandler.SetParentForm(null);
                Application.Exit();
            }
            else
            {
                MessageBox.Show(
                    "Pogresan login. Pokušajte ponovo!",
                    "GREŠKA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
