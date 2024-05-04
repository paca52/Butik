using SQLToolkitNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace butik.models
{
    public class DostavaArtikliModel
    {
        private long id_dostava;
        private List<ArtiklModel> artikli;

        public DostavaArtikliModel(long id_dostava, List<ArtiklModel> list)
        {
            this.id_dostava = id_dostava;
            this.artikli = list;
        }

        public void PrintModel()
        {
            String tmp = String.Empty;
            foreach (var item in artikli)
            {
                tmp += item.Id + "(" + item.Naziv + ")";
            }
            MessageBox.Show($"id_dostava: {id_dostava}, artikli: {tmp}");
        }

        public Boolean Sacuvaj()
        {
            foreach(var item in artikli)
            {
                if(!item.UpdateUBazi())
                {
                    return false;
                }


                // povezi dostavu i item(artikl)
                String err = String.Empty;
                String sql = "INSERT INTO dbo.table_dostava_artikl " +
                    "(id_dostava, id_artikla, dostavljena_kolicina)" +
                    "VALUES (" + this.id_dostava + ", " + item.Id + ", " + item.GetDostavljenaKolicina() + ");";
                

                if(!SQLToolkit.NonSelectQuery(sql, ref err))
                {
                    MessageBox.Show($"Nije moguce povezati {item.Naziv} sa dostavom.\n" + err);
                    return false;
                }
            }

            return true;
        }

        // public Boolean 

    }
}
