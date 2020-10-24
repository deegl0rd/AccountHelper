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
        public string Sablon { get; set; }
        public string MkidoKezd { get; set; }
        public string MkidoVege { get; set; }
        public List<string[]> MkSzunetek { get; set; }
        public int NapimkIdo { get; set; }
        public bool MkSzunetNemResze { get; set; }
        public bool AutoNyilvantartas { get; set; }

        #endregion

        #region Létrehozás metódus

        public void Letrehoz(Ceg ceg)
        {
            XDocument cegX = XDocument.Load(ceg.filepath);

            List<XElement> elem = new List<XElement>();

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
                    new XAttribute("neve", Neve),
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

            //xml zár
            cegX.Save(ceg.filepath);

            Console.WriteLine("szervezeti egyseg created");
        }

        #endregion

        #region Törlés metódus

        public static void Torles(Ceg ceg, string neve)
        {
            XDocument cegX = XDocument.Load(ceg.filepath);

            IEnumerable<XElement> nodes = from node in cegX.Descendants()
                    let attr = node.Attribute("neve")
                    where node.Name == xmlTagNeve && attr.Value == neve
                    select node;

            nodes.Remove();
            cegX.Save(ceg.filepath);
        }

        #endregion
    }
}
