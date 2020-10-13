using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AccountHelper.src
{
    public enum LogType
    {
        INFO, ERROR, WARNING
    }

    public enum BookerAnnouncement
    {
        SQL_IDFailed = 4500,
        SQL_IDSuccess = 2500,
        SQL_IDSkipped = 7500,
        SQL_ConnFailed = 4510,
        SQL_ConnSuccess = 2510,

        BHL_Version = 9500,
    }

    class Logger
    {
        readonly static Dictionary<int, string> Announcements;

        static Logger()
        {
            Announcements = new Dictionary<int, string>
            {
                {4500, "Az SQL hitelesítés nem sikerült!"},
                {2500, "Az SQL hitelesítés sikerült!"},
                {7500, "SQL hitelesítés kihagyva, a program enter lenyomására a főablakra lép."},
                {4510, "SQL kapcsolat létesítése nem sikerült!"},
                {2510, "SQL kapcsolat létesítése sikerült!"},

                {9500, $"BookerHelper verzió: {Application.ProductVersion}"},
            };
        }

        //Metódus hívásakor második paraméternek használjunk 'null'-t, ha külön szöveget szeretnénk logcímnek adni!
        public static void Log(string text, LogType? logType = LogType.INFO, string logTitle = "GENERAL")
        {
            switch (logType)
            {
                case LogType.INFO:
                    {
                        logTitle = "INFO.";
                        break;
                    }
                case LogType.ERROR:
                    {
                        logTitle = "HIBA";
                        break;
                    }
                case LogType.WARNING:
                    {
                        logTitle = "FIGY.";
                        break;
                    }
            }
            Console.WriteLine($"[{logTitle}] {DateTime.Now:HH:mm:ss} : " + text);
        }

        //Különböző beállított szövegeket tudunk küldeni 
        public static void Announce(BookerAnnouncement announcement)
        {
            int firstNum = int.Parse(((int)announcement).ToString().Substring(0, 1));
            switch (firstNum)
            {
                case 4:
                    Log(Announcements[(int)announcement], LogType.ERROR);
                    break;
                case 2:
                    Log(Announcements[(int)announcement], LogType.INFO);
                    break;
                case 7:
                    Log(Announcements[(int)announcement], LogType.WARNING);
                    break;
                case 9:
                    Log(Announcements[(int)announcement], null, "BHLP");
                    break;
            }
        }
    }
}
