using SQLToolkitNS;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace butik.models
{
    public class ArtiklModel
    {
        private long id { get; set; }
        private String naziv { get; set; }
        private Decimal cena { get; set; }
        private int kolicina { get; set; }

        private int dostavljena_kolicina;

        public ArtiklModel(long id, String naziv, Decimal cena, int kolicina)
        {
            this.id = id;
            this.naziv = naziv;
            this.cena = cena;
            this.kolicina = kolicina;
            this.dostavljena_kolicina = 0;
        }
        public ArtiklModel(long id, String naziv, Decimal cena, int kolicina, int dostavljena_kolicina)
        {
            this.id = id;
            this.naziv = naziv;
            this.cena = cena;
            this.kolicina = kolicina;
            this.dostavljena_kolicina = dostavljena_kolicina;
        }

        public ArtiklModel(long id)
        {
            this.id = id;
            String err = String.Empty;
            if (!SQLToolkit.SelectQuery(
                "SELECT naziv, cena, kolicina FROM table_artikli WHERE id_artikla = " + id,
                (ref SqlDataReader dr) =>
                {
                    this.naziv = dr.GetString(0);
                    this.cena = (Decimal)dr.GetDouble(1);
                    this.kolicina = dr.GetInt32(2);
                },
                ref err)
            )
            {
                MessageBox.Show(err);
            }
        }

        public ArtiklModel(String naziv, Decimal cena, int kolicina)
        {
            this.id = -1;
            this.naziv = naziv;
            this.cena = cena;
            this.kolicina = kolicina;
        }

        public long Id { get { return id; } set { id = value; } }

        public String Naziv { get { return naziv; } set { naziv = value; } }

        public Decimal Cena { get { return cena; } set { cena = value; } }

        public int Kolicina { get { return kolicina; } set { kolicina = value; } }

        public int Dostavljena_kolicina { get { return dostavljena_kolicina; } set { dostavljena_kolicina = value; } }

        public Boolean DodajUBazu()
        {
            String sql = "INSERT INTO dbo.table_artikli" +
                "(naziv, kolicina, cena) " +
                "VALUES " +
                "('" + this.naziv + "', " + this.kolicina + ", " + this.cena + ");";

            String err = String.Empty;
            long id = -1;
            if (!SQLToolkit.NonSelectQueryAndReturnId(sql, ref id, ref err))
            {
                MessageBox.Show(err);
            }
            this.id = id;
            return true;
        }

        public Boolean IsValid()
        {
            return this.naziv.Length != 0 && this.kolicina >= 0 && this.cena >= 0;
        }

        public void PrintModel()
        {
            MessageBox.Show(
                "id: " + id + "\n" + "naziv: " + naziv + "\n" + "cena: " + cena + "\n" + "kolicina: " + kolicina,
                "ArtiklModel"
            );
        }

        public Boolean AzurirajKolicinu()
        {
            kolicina += dostavljena_kolicina;
            return true;
        }

        public Boolean UpdateUBazi()
        {
            String sql = "UPDATE dbo.table_artikli SET " +
                "naziv = '" + this.naziv + "', " +
                "kolicina = " + this.kolicina + " " +
                "WHERE id_artikla = " + this.id;
            // MessageBox.Show(sql);

            String err = String.Empty;
            if(!SQLToolkit.NonSelectQuery(sql, ref err))
            {
                MessageBox.Show("Nije moguce update-ovati Artikl u bazi\n" + err);
                return false;
            }
            return true;
        }

        public int GetDostavljenaKolicina()
        {
            return this.dostavljena_kolicina;
        }
    }
}
