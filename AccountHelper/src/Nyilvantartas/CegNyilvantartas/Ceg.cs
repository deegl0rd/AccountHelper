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
using System.Xml.Linq;

namespace AccountHelper.src.Nyilvantartas
{
    class Ceg
    {
        #region Változók

        public List<SzervezetiEgyseg> SzervezetiEgysegek { get; set; }

        public static List<Ceg> ceglista;

        private static XmlDocument xml;

        readonly static string work_Folder = Application.StartupPath + "/" + Program.cegek;

        public string ceg_neve, szamlazasiNev, varos, cim,
            levelezesi_varos, levelezesi_cim, cegjegyzekszam,
            cegAdoszam, cegTelefonszam, cegWeboldal;
        public int iranyitoszam, levelezesi_iranyitoszam;

        public string filepath;

        public string fajlNev;

        #region Szervezeti egység betöltési változók

        string szerv_neve, szerv_ID, szerv_sablon, szerv_mkidoKezd, szerv_mkidoVege;

        int szerv_napimkIdo, szerv_szunetekSzama;

        List<string[]> szerv_atalakitva;

        bool szerv_mkSzunetNemResze, szerv_autoNyilvantartas;

        #endregion

        #endregion

        #region Parser

        private void Parser(XmlDocument xml)
        {
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

        #region Konstruktorok

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

        #region Konstruktor LÉTREHOZÁSI

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

        #region Konstruktor HELY + FÁJLNÉV ALAPJÁN MEGNYIÍTÁS
        public Ceg(string hely, string fajlNev)
        {
            filepath = hely + "/" + fajlNev;
            this.fajlNev = fajlNev;
            string xmlContent = File.ReadAllText(hely + "/" + fajlNev);
            xml = new XmlDocument();
            xml.LoadXml(xmlContent);

            Parser(xml);
        }

        #endregion

        /// <summary>
        /// Konstruktor 3 mezők
        /// </summary>
        /// <param name="utvonal">A fájl teljes útvonala</param>

        #region Konstruktor ABSZOLÚT HELY ALAPJÁN MEGNYITÁS

        public Ceg(string utvonal)
        {
            filepath = utvonal;
            string xmlContent = File.ReadAllText(utvonal);
            xml = new XmlDocument();
            xml.LoadXml(xmlContent);

            Parser(xml);
        }

        #endregion

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

            Console.WriteLine("ceg file created");
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
            xml.LoadXml(File.ReadAllText(filepath));

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

            xml.Save(filepath);

            Console.WriteLine("file modified and saved");
        }

        #endregion

        #region Betöltés

        public static List<Ceg> Betoltes()
        {
            string[] files = Directory.GetFiles(work_Folder);

            ceglista = new List<Ceg>();
            ceglista.Clear();

            foreach (string file in files)
            {
                Ceg c = new Ceg(work_Folder, Path.GetFileName(file));
                ceglista.Add(c);
            }

            return ceglista;
        }

        #endregion

        #region Szervezeti egység Betöltése

        public List<SzervezetiEgyseg> SzervezetiEgysegBetoltes()
        {
            SzervezetiEgysegek = new List<SzervezetiEgyseg>();

            XmlDocument xml = new XmlDocument();
            xml.Load(filepath);

            XmlNodeList szervezetiEgysegLista = xml.GetElementsByTagName("szervezeti_egyseg");

            for (int i = 0; i < szervezetiEgysegLista.Count; i++)
            {
                szerv_neve = szervezetiEgysegLista[i].Attributes.GetNamedItem("neve").InnerText;
                szerv_ID = szervezetiEgysegLista[i].Attributes.GetNamedItem("id").InnerText;
                szerv_szunetekSzama = 0;
                szerv_atalakitva = new List<string[]>();

                foreach (XmlNode node in szervezetiEgysegLista[i].ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "sablon": { szerv_sablon = node.InnerText; break; }
                        case "mkidoKezd": { szerv_mkidoKezd = node.InnerText; break; }
                        case "mkidoVege": { szerv_mkidoVege = node.InnerText; break; }
                        case "mkSzunetek": 
                            {
                                for(int j = 0; j < node.ChildNodes.Count; j++)
                                {
                                    string kezdes = node.ChildNodes[j].Attributes.GetNamedItem("kezdes").InnerText;
                                    string veg = node.ChildNodes[j].Attributes.GetNamedItem("veg").InnerText;
                                    string perc = node.ChildNodes[j].Attributes.GetNamedItem("perc").InnerText;

                                    szerv_atalakitva.Add(new string[] { kezdes, veg, perc });
                                    szerv_szunetekSzama = szerv_atalakitva.Count;
                                }
                                break;
                            }
                        case "napimkIdo": { szerv_napimkIdo = int.Parse(node.InnerText); break; }
                        case "mkSzunetNemResze": 
                            {
                                switch (node.Attributes.GetNamedItem("ertek").InnerText)
                                {
                                    case "igaz":
                                        {
                                            szerv_mkSzunetNemResze = true;
                                            break;
                                        }
                                    case "hamis":
                                        {
                                            szerv_mkSzunetNemResze = false;
                                            break;
                                        }
                                }
                                break;
                            }
                        case "autoNyilvantartas": 
                            {
                                switch (node.Attributes.GetNamedItem("ertek").InnerText)
                                {
                                    case "igaz":
                                        {
                                            szerv_autoNyilvantartas = true;
                                            break;
                                        }
                                    case "hamis":
                                        {
                                            szerv_autoNyilvantartas = false;
                                            break;
                                        }
                                }
                                break;
                            }
                    }
                }

                SzervezetiEgysegek.Add(new SzervezetiEgyseg()
                {
                    Neve = szerv_neve,
                    ID = szerv_ID,
                    Sablon = szerv_sablon,
                    MkidoKezd = szerv_mkidoKezd,
                    MkidoVege = szerv_mkidoVege,
                    MkSzunetek = szerv_atalakitva,
                    SzunetekSzama = szerv_szunetekSzama,
                    NapimkIdo = szerv_napimkIdo,
                    MkSzunetNemResze = szerv_mkSzunetNemResze,
                    AutoNyilvantartas = szerv_autoNyilvantartas
                });
            }

            return SzervezetiEgysegek;
        }

        #endregion
    }
}
