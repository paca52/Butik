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

namespace butik.forms.dashboard
{
    public partial class queryForm : frmEmbeddedTemplate
    {
        public static String output = "";
        
        public queryForm()
        {

            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            output = textBox1.Text;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
