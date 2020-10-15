using Microsoft.Office.Core;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AccountHelper.src.Nyilvantartas
{
    class Ceg
    {
        #region Változók

        public static List<Ceg> lista;

        private static XmlDocument xml;

        readonly static string work_Folder = Application.StartupPath + "/" + Program.cegek;

        public readonly string ceg_neve, szamlazasiNev, varos, cim,
            levelezesi_varos, levelezesi_cim, cegjegyzekszam,
            cegAdoszam, cegTelefonszam, cegWeboldal;
        public readonly int iranyitoszam, levelezesi_iranyitoszam;

        public readonly string path;

        public readonly string fajlNev;

        #endregion

        /// <summary>
        /// Konstruktor 1 mezők
        /// </summary>
        /// <param name="ceg_neve"></param>
        /// <param name="szamlazasiNev"></param>
        /// <param name="varos"></param>
        /// <param name="iranyitoszam"></param>
        /// <param name="cim"></param>
        /// <param name="levelezesi_varos"></param>
        /// <param name="levelezesi_cim"></param>
        /// <param name="levelezesi_iranyitoszam"></param>
        /// <param name="cegjegyzekszam"></param>
        /// <param name="cegAdoszam"></param>
        /// <param name="cegTelefonszam"></param>

        #region Konstruktor 1

        public Ceg(string ceg_neve,
            string szamlazasiNev,
            string varos,
            int iranyitoszam,
            string cim,
            string levelezesi_varos,
            string levelezesi_cim,
            int levelezesi_iranyitoszam,
            string cegjegyzekszam,
            string cegAdoszam,
            string cegTelefonszam,
            string cegWeboldal)
        {
            //Cégneve
            this.ceg_neve = ceg_neve;

            //Számlázási
            this.szamlazasiNev = szamlazasiNev;
            this.varos = varos;
            this.cim = cim;
            this.iranyitoszam = iranyitoszam;

            //Levelezési
            this.levelezesi_varos = levelezesi_varos;
            this.levelezesi_cim = levelezesi_cim;
            this.levelezesi_iranyitoszam = levelezesi_iranyitoszam;

            //Cégadatok
            this.cegjegyzekszam = cegjegyzekszam;
            this.cegAdoszam = cegAdoszam;
            this.cegTelefonszam = cegTelefonszam;
            this.cegWeboldal = cegWeboldal;
        }

        #endregion

        /// <summary>
        /// Konstruktor 2 mezők
        /// </summary>
        /// <param name="hely">Fájl elérési útvonala, fájlnév nélkül!</param>
        /// <param name="fajlNev">A fájl neve, kiterjesztéssel együtt!</param>

        #region Konstruktor 2
        public Ceg(string hely, string fajlNev)
        {
            path = hely + "/" + fajlNev;
            this.fajlNev = fajlNev;
            string xmlContent = File.ReadAllText(hely + "/" + fajlNev);
            xml = new XmlDocument();
            xml.LoadXml(xmlContent);

            //Cégneve
            ceg_neve = xml.DocumentElement.GetAttribute("nev");

            //Számlázási
            szamlazasiNev = xml.GetElementsByTagName("szamlazasiNev").Item(0).InnerText;
            varos = xml.GetElementsByTagName("varos").Item(0).InnerText;
            cim = xml.GetElementsByTagName("cim").Item(0).InnerText;
            iranyitoszam = int.Parse(xml.GetElementsByTagName("iranyitoszam").Item(0).InnerText);

            //Levelezési
            levelezesi_varos = xml.GetElementsByTagName("levelezesi_varos").Item(0).InnerText;
            levelezesi_cim = xml.GetElementsByTagName("levelezesi_cim").Item(0).InnerText;
            levelezesi_iranyitoszam = int.Parse(xml.GetElementsByTagName("levelezesi_iranyitoszam").Item(0).InnerText);

            //Cégadatok
            cegjegyzekszam = xml.GetElementsByTagName("cegjegyzekszam").Item(0).InnerText;
            cegAdoszam = xml.GetElementsByTagName("cegAdoszam").Item(0).InnerText;
            cegTelefonszam = xml.GetElementsByTagName("cegTelefonszam").Item(0).InnerText;
            cegWeboldal = xml.GetElementsByTagName("cegWeboldal").Item(0).InnerText;
        }

        #endregion

        /// <summary>
        /// Konstruktor 3 mezők
        /// </summary>
        /// <param name="utvonal">A fájl teljes útvonala</param>

        #region Konstruktor 3
        public Ceg(string utvonal)
        {
            path = utvonal;
            string xmlContent = File.ReadAllText(utvonal);
            xml = new XmlDocument();
            xml.LoadXml(xmlContent);

            //Cégneve
            ceg_neve = xml.DocumentElement.GetAttribute("nev");

            //Számlázási
            szamlazasiNev = xml.GetElementsByTagName("szamlazasiNev").Item(0).InnerText;
            varos = xml.GetElementsByTagName("varos").Item(0).InnerText;
            cim = xml.GetElementsByTagName("cim").Item(0).InnerText;
            iranyitoszam = int.Parse(xml.GetElementsByTagName("iranyitoszam").Item(0).InnerText);

            //Levelezési
            levelezesi_varos = xml.GetElementsByTagName("levelezesi_varos").Item(0).InnerText;
            levelezesi_cim = xml.GetElementsByTagName("levelezesi_cim").Item(0).InnerText;
            levelezesi_iranyitoszam = int.Parse(xml.GetElementsByTagName("levelezesi_iranyitoszam").Item(0).InnerText);

            //Cégadatok
            cegjegyzekszam = xml.GetElementsByTagName("cegjegyzekszam").Item(0).InnerText;
            cegAdoszam = xml.GetElementsByTagName("cegAdoszam").Item(0).InnerText;
            cegTelefonszam = xml.GetElementsByTagName("cegTelefonszam").Item(0).InnerText;
            cegWeboldal = xml.GetElementsByTagName("cegWeboldal").Item(0).InnerText;
        }

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

            XmlWriter writer = XmlWriter.Create(work_Folder + "/" + ceg_neve + ".xml", settings);

            //xml nyit
            writer.WriteStartDocument();

            writer.WriteStartElement("ceg");
            writer.WriteAttributeString("nev", ceg_neve);

            //Számlázási
            writer.WriteStartElement("szamlazasi");

            writer.WriteStartElement("szamlazasiNev");
            writer.WriteString(szamlazasiNev);
            writer.WriteEndElement();

            writer.WriteStartElement("varos");
            writer.WriteString(varos);
            writer.WriteEndElement();

            writer.WriteStartElement("cim");
            writer.WriteString(cim);
            writer.WriteEndElement();

            writer.WriteStartElement("iranyitoszam");
            writer.WriteString(iranyitoszam.ToString());
            writer.WriteEndElement();

            writer.WriteEndElement();

            //Levelezési
            writer.WriteStartElement("levelezesi");

            writer.WriteStartElement("levelezesi_varos");
            writer.WriteString(levelezesi_varos);
            writer.WriteEndElement();

            writer.WriteStartElement("levelezesi_cim");
            writer.WriteString(levelezesi_cim);
            writer.WriteEndElement();

            writer.WriteStartElement("levelezesi_iranyitoszam");
            writer.WriteString(levelezesi_iranyitoszam.ToString());
            writer.WriteEndElement();

            writer.WriteEndElement();

            //Cégadatok
            writer.WriteStartElement("cegadatok");

            writer.WriteStartElement("cegjegyzekszam");
            writer.WriteString(cegjegyzekszam);
            writer.WriteEndElement();

            writer.WriteStartElement("cegAdoszam");
            writer.WriteString(cegAdoszam);
            writer.WriteEndElement();

            writer.WriteStartElement("cegTelefonszam");
            writer.WriteString(cegTelefonszam);
            writer.WriteEndElement();

            writer.WriteStartElement("cegWeboldal");
            writer.WriteString(cegWeboldal);
            writer.WriteEndElement();

            writer.WriteEndElement();

            //xml zár
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();

            Console.WriteLine("file created");
        }

        #endregion

        #region Változtatás metódus

        public void Valtoztat(string ceg_neve,
            string szamlazasiNev,
            string varos,
            int iranyitoszam,
            string cim,
            string levelezesi_varos,
            string levelezesi_cim,
            int levelezesi_iranyitoszam,
            string cegjegyzekszam,
            string cegAdoszam,
            string cegTelefonszam,
            string cegWeboldal)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(File.ReadAllText(path));

            xml.GetElementsByTagName("ceg")[0].Attributes[0].InnerText = ceg_neve;
            xml.GetElementsByTagName("szamlazasiNev")[0].InnerText = szamlazasiNev;
            xml.GetElementsByTagName("varos")[0].InnerText = varos;
            xml.GetElementsByTagName("iranyitoszam")[0].InnerText = iranyitoszam.ToString();
            xml.GetElementsByTagName("cim")[0].InnerText = cim;
            xml.GetElementsByTagName("levelezesi_varos")[0].InnerText = levelezesi_varos;
            xml.GetElementsByTagName("levelezesi_cim")[0].InnerText = levelezesi_cim;
            xml.GetElementsByTagName("levelezesi_iranyitoszam")[0].InnerText = levelezesi_iranyitoszam.ToString();
            xml.GetElementsByTagName("cegjegyzekszam")[0].InnerText = cegjegyzekszam;
            xml.GetElementsByTagName("cegAdoszam")[0].InnerText = cegAdoszam;
            xml.GetElementsByTagName("cegTelefonszam")[0].InnerText = cegTelefonszam;
            xml.GetElementsByTagName("cegWeboldal")[0].InnerText = cegWeboldal;

            xml.Save(path);

            Console.WriteLine("file modified and saved");
        }

        #endregion

        #region Betöltés

        public static List<Ceg> Betoltes()
        {
            string[] files = Directory.GetFiles(work_Folder);

            lista = new List<Ceg>();
            lista.Clear();

            foreach (string file in files)
            {
                lista.Add(new Ceg(work_Folder, Path.GetFileName(file)));
            }

            return lista;
        }

        #endregion
    }
}
