using butik.forms.login;
using butik.util;
using SQLToolkitNS;
using System;
using System.Windows.Forms;

namespace butik.models
{
    internal class ProdajaModel
    {
        public ProdajaModel(Decimal ukupna_cena)
        {
            id = -1;
            this.jmbg_zaposlenog = frmLogin.jmbg;
            this.ukupna_cena = ukupna_cena;
        }

        private long id;

        private String jmbg_zaposlenog;

        private Decimal ukupna_cena = 0;

        private String datum;

        public long Id { get { return id; } set { id = value; } }

        public String Jmbg_zaposlenog { get { return jmbg_zaposlenog; } set { jmbg_zaposlenog = value; } }

        public Decimal Ukupna_cena { get { return ukupna_cena; } set { ukupna_cena = value; } }

        public String Datum { get { return datum; } set { datum = value; } }

        public Boolean NovaProdaja()
        {
            String err = String.Empty;
            datum = DateTime.Today.ToString("yyyy-MM-dd");
            String sql =
                "INSERT INTO dbo.table_racun_header (id_zaposleni, ukupna_cena, datum) " +
                "VALUES ('" + jmbg_zaposlenog + "', " + ukupna_cena.ToString().Replace(',', '.') + ", '" + datum + "');";
            
            if (!SQLToolkit.NonSelectQueryAndReturnId(sql, ref id, ref err))
            {
                MessageUtil.ShowError("GREŠKA PRI KREIRANJU GLAVE RAČUNA U BAZI\n" + err);
                return false;
            }
            return true;
        }
    }
}
