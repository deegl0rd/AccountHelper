using System;
using System.Xml;

namespace AccountHelper.src.XKROlvaso
{
    class XmlKezelo
    {

        private readonly XmlDocument xml;

        public XmlKezelo(string fajlHelye)
        {
            string xmlContent = System.IO.File.ReadAllText(fajlHelye);
            xml = new XmlDocument();
            xml.LoadXml(xmlContent);
            XmlNodeList nodes = xml.GetElementsByTagName("mezo");

            Nev = nodes.Item(4).InnerText;
            DatumKezdete = nodes.Item(10).InnerText;
            DatumNapokSzama = nodes.Item(9).InnerText;
            Adoazonosito = nodes.Item(5).InnerText;
            Tajszam = nodes.Item(6).InnerText;
            Tipus = nodes.Item(7).InnerText;

            //Formázás Taj-szám
            for (int i = 3; i <= Tajszam.Length; i += 3)
            {
                Tajszam = Tajszam.Insert(i, " ");
                i++;
            }

            //Formázás DátumKezdete
            DatumKezdete = DatumKezdete.Insert(4, "/");
            DatumKezdete = DatumKezdete.Insert(7, "/");

            //Számítás, Formázás DátumVége
            DatumVege = DateTime.Parse(DatumKezdete).AddDays(Convert.ToDouble(DatumNapokSzama) - 1).ToString("yyyy'/'MM'/'dd");
        }

        public string Nev { get; }

        public string DatumKezdete { get; }

        public string DatumVege { get; }

        public string DatumNapokSzama { get; }

        public string Adoazonosito { get; }

        public string Tajszam { get; }

        public string Tipus { get; }

    }
}