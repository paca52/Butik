using System;
using System.Windows.Forms;

namespace butik.forms
{
    public partial class frmTemplate : Form
    {
        public frmTemplate()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
        protected void showForm(Form frm)
        {
            frm.TopLevel = false;
            frm.AutoScroll = true;
            pnlScreen.Controls.Add(frm);
            frm.Show();
        }
        */
    }
}
