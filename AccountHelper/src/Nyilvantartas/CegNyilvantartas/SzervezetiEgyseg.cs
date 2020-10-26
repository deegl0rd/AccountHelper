using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace AccountHelper.src.Nyilvantartas
{
    class SzervezetiEgyseg
    {
        #region Variables

        public static string xmlTagNeve = "szervezeti_egyseg";

        //readonly static string work_Folder = Application.StartupPath + "/" + Program.cegek;

        public string Neve { get; set; }

        public string ID { get; set; }
        public string Sablon { get; set; }
        public string MkidoKezd { get; set; }
        public string MkidoVege { get; set; }
        public List<string[]> MkSzunetek { get; set; }
        public int NapimkIdo { get; set; }
        public bool MkSzunetNemResze { get; set; }
        public bool AutoNyilvantartas { get; set; }

        #endregion

        #region Random string generátor

        public static string RandomStr(int length)
        {
            string chars = "ABCDEF0123456789";
            char[] stringChars = new char[length];
            Random random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                if (i == 0)
                {
                    stringChars[i] = chars[random.Next(0,6)];
                }
                else
                {
                    stringChars[i] = chars[random.Next(6,chars.Length)];
                }
            }

            return new string(stringChars);
        }

        #endregion

        #region Létrehozás metódus

        public void Letrehoz(Ceg ceg)
        {
            XDocument cegX = XDocument.Load(ceg.filepath);

            List<XElement> elem = new List<XElement>();

            switch (Sablon)
            {
                case "kötetlen":
                    {
                        cegX.Root.Add(
                            new XElement(xmlTagNeve,
                                new XAttribute("neve", Neve), new XAttribute("id", RandomStr(6)),
                                new XElement("sablon", Sablon))
                        );
                        break;
                    }
                case "munkaidőkeret":
                    {
                        break;
                    }
                case "általános":
                    {
                        for (int i = 0; i < MkSzunetek.Count; i++)
                        {
                            if (MkSzunetek.ElementAt(i) == null) return;

                            elem.Add(new XElement("mkSzunet" + i,
                                new XAttribute("kezdes", (MkSzunetek[i])[0]),
                                new XAttribute("veg", (MkSzunetek[i])[1]),
                                new XAttribute("perc", (MkSzunetek[i])[2])));
                        }

                        //xml nyit
                        cegX.Root.Add(
                            new XElement(xmlTagNeve,
                                new XAttribute("neve", Neve), new XAttribute("id", RandomStr(6)),
                                new XElement("sablon", Sablon),
                                new XElement("mkidoKezd", MkidoKezd),
                                new XElement("mkidoVege", MkidoVege),
                                new XElement("mkSzunetek", elem.Count > 0 ? elem : null),
                                new XElement("napimkIdo", NapimkIdo.ToString()),
                                new XElement("mkSzunetNemResze",
                                    new XAttribute("ertek", MkSzunetNemResze ? "igaz" : "hamis")),
                                new XElement("autoNyilvantartas",
                                    new XAttribute("ertek", AutoNyilvantartas ? "igaz" : "hamis"))
                                )
                        );
                        break;
                    }
            }

            //xml zár
            cegX.Save(ceg.filepath);

            Console.WriteLine("szervezeti egyseg created");
        }

        #endregion

        #region Törlés metódus

        public static void Torles(Ceg ceg, string nev, string ID)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(ceg.filepath);
            XmlNodeList nodes = xml.SelectNodes($"//{xmlTagNeve}[@neve='{nev}' and @id='{ID}']");

            for (int i = 0; i < nodes.Count; i++)
            {
                nodes[i].ParentNode.RemoveChild(nodes[i]);
            }

            xml.Save(ceg.filepath);
        }

        #endregion
    }
}
