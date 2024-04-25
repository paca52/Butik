using SQLToolkitNS;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace butik.models
{
    public class DostavaModel
    {
        private long id;

        public long Id { get { return id; } }

        public Boolean NovaDostava()
        {
            String err = String.Empty;
            String datum = DateTime.Today.ToString("yyyy-MM-dd");
            String sql =
                "INSERT INTO dbo.table_dostava (datum_dostave, dostavljac) " +
                "VALUES ('" + datum + "', 'NAZIV_DOSTAVLJACA');";

            if (!SQLToolkit.NonSelectQueryAndReturnId(sql, ref id, ref err))
            {
                MessageBox.Show(
                    "GREŠKA PRI KREIRANJU DOSTAVE U BAZI\n" + err,
                    "GREŠKA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
            return true;
        }

        public DostavaModel()
        {
            id = -1;
        }
    }
}
