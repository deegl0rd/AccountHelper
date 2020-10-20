using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AccountHelper.src.Nyilvantartas
{
    class SzervezetiEgyseg
    {
        #region Variables

        readonly static string work_Folder = Application.StartupPath + "/" + Program.cegek;
        readonly static string szervezeti_egysegek_Folder = Program.szervezeti_egysegek;

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

        public void Letrehoz()
        {
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                OmitXmlDeclaration = true,
                NewLineOnAttributes = false
            };

            XmlWriter writer = XmlWriter.Create(work_Folder + "/" + szervezeti_egysegek_Folder +  "/" + Neve + ".xml", settings);

            //xml nyit
            writer.WriteStartDocument();

            writer.WriteStartElement("szervezeti_egyseg");
            writer.WriteAttributeString("nev", Neve);

            writer.WriteStartElement("sablon");
            writer.WriteString(Sablon);
            writer.WriteEndElement();

            writer.WriteStartElement("mkidoKezd");
            writer.WriteString(MkidoKezd);
            writer.WriteEndElement();

            writer.WriteStartElement("mkidoVege");
            writer.WriteString(MkidoVege);
            writer.WriteEndElement();

            writer.WriteStartElement("mkSzunetek");
            for (int i = 0; i < MkSzunetek.Count; i++)
            {
                writer.WriteStartElement("mkSzunet" + i);
                writer.WriteAttributeString("kezdes", MkSzunetek[i][0]);
                writer.WriteAttributeString("veg", MkSzunetek[i][1]);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();

            writer.WriteStartElement("napimkIdo");
            writer.WriteString(NapimkIdo.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("mkSzunetNemResze");
            writer.WriteAttributeString("ertek", MkSzunetNemResze ? "igaz" : "hamis");
            writer.WriteEndElement();

            writer.WriteStartElement("autoNyilvantartas");
            writer.WriteAttributeString("ertek", AutoNyilvantartas ? "igaz" : "hamis");
            writer.WriteEndElement();

            //xml zár
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();

            Console.WriteLine("szervezeti egyseg file created");
        }

        #endregion
    }
}
