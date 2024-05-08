using butik.util;
using SQLToolkitNS;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace butik.models
{
    internal class ProdajaArtikliModel
    {
        private long id_prodaje;
        private List<ArtiklModel> artikli;

        public ProdajaArtikliModel(long id_prodaje, List<ArtiklModel> list)
        {
            this.id_prodaje = id_prodaje;
            this.artikli = list;
        }

        public void PrintModel()
        {
            String tmp = String.Empty;
            foreach (var item in artikli)
            {
                tmp += item.Id + "(" + item.Naziv + ")";
            }
            MessageUtil.ShowError($"id_prodaje: {id_prodaje}, artikli: {tmp}");
        }

        public Boolean Sacuvaj()
        {
            foreach (var item in artikli)
            {
                if (!item.UpdateUBazi())
                {
                    return false;
                }

                // povezi racun i item(artikl)
                String err = String.Empty;
                String cena = item.Cena.ToString().Replace(',', '.');

                String sql = "INSERT INTO dbo.table_racun_body " +
                    "(id_artikla, id_racun_header, kolicina, prodajna_cena)" +
                    "VALUES (" + item.Id + ", " + id_prodaje + ", " + item.GetDeltaKolicina() + ", " + cena + ");";

                if (!SQLToolkit.NonSelectQuery(sql, ref err))
                {
                    MessageUtil.ShowError($"Nije moguce povezati {item.Naziv} sa računom {id_prodaje}.\n" + err);
                    return false;
                }
            }

            return true;
        }
    }
}
