using butik.util;
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
                "INSERT INTO dbo.table_dostava (datum_dostave) " +
                "VALUES ('" + datum + "');";

            if (!SQLToolkit.NonSelectQueryAndReturnId(sql, ref id, ref err))
            {
                MessageUtil.ShowError("GREŠKA PRI KREIRANJU DOSTAVE U BAZI\n" + err);
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
