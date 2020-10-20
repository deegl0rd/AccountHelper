using AccountHelper.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AccountHelper.src.Beallitasok
{
    public class Beallitas
    {
        public string ikon;
        public string nev;

        public Beallitas(string ikon, string nev)
        {
            this.ikon = ikon;
            this.nev = nev;
        }

        public static object ImageGetter(object rowObject)
        {
            Beallitas b = (Beallitas)rowObject;
            return b.ikon;
        }

        public static List<Beallitas> GetBeallitas()
        {
            List<Beallitas> lista = new List<Beallitas>()
            {
                new Beallitas("alkalmazas", "Alkalmazás"),
                new Beallitas("xkrolvaso", "XKR Olvasó"),
                new Beallitas("nyilvantartas", "Nyilvántartás"),
                new Beallitas("licensz", "Licensz"),
            };

            return lista;
        }
    }
}
