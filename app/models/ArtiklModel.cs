using butik.util;
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

        private int delta_kolicina;

        public ArtiklModel(long id, String naziv, Decimal cena, int kolicina)
        {
            this.id = id;
            this.naziv = naziv;
            this.cena = cena;
            this.kolicina = kolicina;
            this.delta_kolicina = 0;
        }
        public ArtiklModel(long id, String naziv, Decimal cena, int kolicina, int delta_kolicina)
        {
            this.id = id;
            this.naziv = naziv;
            this.cena = cena;
            this.kolicina = kolicina;
            this.delta_kolicina = delta_kolicina;
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
                MessageUtil.ShowError($"Greška!\n{err}");
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

        public int Delta_kolicina { get { return delta_kolicina; } set { delta_kolicina = value; } }

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
                MessageUtil.ShowError(err);
            }
            this.id = id;
            return true;
        }

        public Boolean IsValid()
        {
            return 
                naziv.Length != 0 &&
                kolicina >= 0 && 
                cena >= 0 &&
                delta_kolicina >= 0;
        }

        public void PrintModel()
        {
            MessageBox.Show(
                "id: " + id + "\n" + "naziv: " + naziv + "\n" + "cena: " + cena + "\n" + "kolicina: " + kolicina,
                "ArtiklModel"
            );
        }

        public Boolean DostaviKolicinu()
        {
            kolicina += delta_kolicina;
            return true;
        }

        public Boolean ProdajKolicinu()
        {
            kolicina -= delta_kolicina;
            return true;
        }

        public Boolean UpdateUBazi()
        {
            String sql = "UPDATE dbo.table_artikli SET " +
                "naziv = '" + this.naziv + "', " +
                "kolicina = " + this.kolicina + " " +
                "WHERE id_artikla = " + this.id;

            String err = String.Empty;
            if(!SQLToolkit.NonSelectQuery(sql, ref err))
            {
                MessageUtil.ShowError("Nije moguce update-ovati Artikl u bazi\n" + err);
                return false;
            }
            return true;
        }

        public int GetDostavljenaKolicina()
        {
            return delta_kolicina > 0 ? delta_kolicina : 0;
        }

        public int GetProdataKolicina()
        {
            return delta_kolicina < 0 ? delta_kolicina : 0;
        }
    }
}
