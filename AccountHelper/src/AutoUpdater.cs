
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountHelper.src
{
    static class AutoUpdater
    {

        public static string GetGitRepoVersion()
        {
            WebClient client = new WebClient
            {
                Encoding = Encoding.UTF8
            };
            string repoVersion = client.DownloadString("https://raw.githubusercontent.com/deegl0rd/AccountHelper/master/AccountHelper/bin/Debug/version.txt");
            byte[] versionBytes = Encoding.UTF8.GetBytes(repoVersion);

            return Encoding.UTF8.GetString(versionBytes);
        }



        public static bool IsNewestVersion()
        {
            if (Application.ProductVersion == GetGitRepoVersion())
            {
                return true;
            }
            return false;
        }
    }
}
