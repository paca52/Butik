using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace butik.forms.dashboard
{
    public partial class frmQueryRadnik : frmEmbeddedTemplate
    {
        public static String datumDo = "";
        public static String datumOd = "";
        public static String jmbg = "";
        public frmQueryRadnik()
        {
            InitializeComponent();
        }

        private void frmQueryRadnik_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            datumOd = dateTimePicker1.Value.ToString();
            datumDo = dateTimePicker2.Value.ToString();
            jmbg = textBox1.Text;
            this.Close();
        }
    }
}
