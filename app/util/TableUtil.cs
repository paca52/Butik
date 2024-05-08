using System.Drawing;
using System.Windows.Forms;

namespace butik.util
{
    internal static class TableUtil
    {
        public static void Design(ref DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 71, 79);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            dgv.RowsDefaultCellStyle.BackColor = Color.FromArgb(239, 239, 239);
            dgv.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgv.RowsDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Regular);

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(211, 211, 211);
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.Padding = new Padding(5, 3, 5, 3);



            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.HeaderText = TableUtil.Rename(column.Name);
            }

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


        }

        private static string Rename(string name)
        {
            if (name == "kolicina") return "Količina";
            if (name == "Delta_kolicina") return "Prodata Količina";
            string s = "";
            for (int i = 0; i < name.Length; i++)
            {
                if (i == 0 || name[i - 1] == '_')
                {
                    s += char.ToUpper(name[i]);
                }
                else if (name[i] == '_')
                {
                    s += " ";
                }
                else
                {
                    s += name[i];
                }
            }
            return s;
        }

    }
}
