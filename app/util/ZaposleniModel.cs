using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace butik.util
{
    internal static class ZaposleniModel
    {
        public static string jmbg = "";
        public static string ime = "";
        public static string prezime = "";
        public static int tip_zaposlenog = -1;
        public static string datumZaposlenja = "";
        public static int satnica = -1;
        public static int brojRadnihSati = -1;
        public static string premija = "";
        public static int brojSlobodnihDana = -1;
        public static string username = "";
        public static string password = "";

        public static Dictionary<string, int> tipZaposlenogMap = new Dictionary<string, int>();

        public static bool validateInput(ref String err)
        {
            if(jmbg.Length < 13)
            {
                err = "JMBG polje mora imati 13 karaktera!";
                return false;
            }
            if(ime == "" || prezime == "" || tip_zaposlenog == -1 || datumZaposlenja == "" ||  satnica == -1 || brojRadnihSati == -1)
            {
                err = "Sva polja su obavezna, sem PREMIJA. ";
                return false;
            }
            return true;
        }
    }
}
