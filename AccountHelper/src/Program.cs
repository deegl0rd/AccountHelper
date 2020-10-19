using AccountHelper.Properties;
using AccountHelper.src.Nyilvantartas;
using AccountHelper.src.XKROlvaso;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

#pragma warning disable CS0162, IDE0044, IDE0051

namespace AccountHelper.src
{
    static class Program
    {
        //SQL HITELESÍTÉS INAKTÍV
        //private static SQLHitelesito sql;

        #region Ablakok

        public static Form KezeloAblak = new KezeloAblak();
        public static Form HitelesitoAblak = new HitelesitoAblak();
        public static Form NevjegyPanel = new NevjegyPanel();
        public static Form NyilvantartasAblak = new NyilvantartasAblak();
        public static Form SzerkesztesAblak = new SzerkesztesAblak();

        #endregion

        #region Fájl/mappa nevek

        //Mappák
        public static string temp = "temp";
        public static string cegek = "cegek";
        public static string alkalmazottak = "alkalmazottak";

        //Fájlok
        public static string verzioFajl = "info.txt";

        #endregion

        #region Főmetódus

        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);

            AutoUpdater.GetGitRepoVersion();

            VerzioFajlIr();
            MappaLetrehoz();
            Futtat();
            return;

            //SQL HITELESÍTÉS INAKTÍV
            //sql = new SQLHitelesito("localhost", "xkrolvaso_adatok", "xkr_kliens", "Q3bafedocA5O", "licenszek");
        }

        #endregion

        public static void Futtat()
        {
            Application.Run(new StartupForm());
        }

        public static void MappaLetrehoz()
        {
            string work_Folder;
            List<string> mappak = new List<string>
            {
                temp,
                cegek,
                alkalmazottak
            };

            foreach (string mappa in mappak)
            {
                work_Folder = Application.StartupPath + "/" + mappa;
                Directory.CreateDirectory(work_Folder);
            }
        }

        public static void VerzioFajlIr()
        {
            string path = Application.StartupPath + "/" + verzioFajl;

            File.WriteAllText(path, Application.ProductVersion);
        }
    }
}
