using MySql.Data.MySqlClient;
using System;
using System.Net;
using System.Windows.Forms;

#pragma warning disable IDE0052

namespace AccountHelper.src
{
    class SQLHitelesito
    {
        private readonly MySqlConnection conn;
        private MySqlDataReader read;
        private MySqlCommand cmd;
        private readonly string connString, ipAddress, database, userID, pass, table;
        private string kulcs_tipus, kulcs_licenszkulcs, kulcs_engedelyezettIP;
        private DateTime kulcs_lejaratiDatum;
        private short kulcs_aktiv = 0;
        private bool hitelesitettKulcs = false;
        private readonly bool connectionSuccess = false;

        //PUBLIKUS IP CÍM LEKÉRÉSE
        public string PublicIP()
        {
            string ip = new WebClient().DownloadString("https://ipv4.icanhazip.com/");
            ip.TrimEnd();
            return ip;
        }

        //SIKERES KAPCSOLAT ELLENŐRZÉSE
        public bool SuccessfulConn()
        {
            return connectionSuccess;
        }

        public SQLHitelesito(string ipAddress, string database, string userID, string pass, string table)
        {
            this.ipAddress = ipAddress;
            this.database = database;
            this.userID = userID;
            this.pass = pass;
            this.table = table;

            connString = $"server={this.ipAddress};userid={this.userID};password={this.pass};database={this.database};";
            conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                connectionSuccess = true;
            }
            catch (MySqlException ex)
            {
                Close();
                connectionSuccess = false;
                MessageBox.Show("Nem sikerült SQL kapcsolatot létesíteni!");
                Console.WriteLine(ex.ToString());
            }
        }

        //SQL KAPCSOLAT BEZÁRÁSA
        public void Close()
        {
            if (read != null)
            {
                read.Close();
            }
            if (conn != null)
            {
                conn.Close();
            }
        }

        //LICENSZKULCS ELLENŐRZÉSE
        public void EllenorizLicensz(string licenszkulcs)
        {
            cmd = new MySqlCommand("SELECT * FROM " + table + " WHERE  termekkulcs = '" + licenszkulcs + "';", conn);

            read = cmd.ExecuteReader();

            while (read.Read())
            {
                if (!read.HasRows)
                {
                    MessageBox.Show("Ilyen licenszkulcs nem létezik!");
                    read.Close();
                    return;
                }

                kulcs_tipus = read.GetString(0);
                kulcs_licenszkulcs = read.GetString(1);
                kulcs_engedelyezettIP = read.GetString(2);
                kulcs_aktiv = read.GetInt16(4);

                if (!kulcs_tipus.StartsWith("orok"))
                {
                    kulcs_lejaratiDatum = read.GetDateTime(3);
                }

                if (kulcs_aktiv == 1)
                {
                    hitelesitettKulcs = true;
                }
                else if (kulcs_aktiv == 0)
                {
                    hitelesitettKulcs = false;
                }
            }

            read.Close();
        }

        //AKTIVÁLÁS
        public void Aktivalas(string licenszkulcs)
        {
            cmd = new MySqlCommand("SELECT * FROM " + table + " WHERE  termekkulcs = '" + licenszkulcs + "';", conn);

            read = cmd.ExecuteReader();

            while (read.Read())
            {
                if (!read.HasRows)
                {
                    MessageBox.Show("Ilyen licenszkulcs nem létezik!");
                    read.Close();
                    return;
                }

                kulcs_aktiv = read.GetInt16(4);
            }

            read.Close();

            //SIKERES AKTIVÁLÁS
            if (kulcs_aktiv == 0)
            {
                cmd = new MySqlCommand("UPDATE " + table + " SET aktiv = 1 WHERE termekkulcs = '" + kulcs_licenszkulcs + "';", conn);
                cmd.ExecuteNonQuery();
                hitelesitettKulcs = true;
                MessageBox.Show("Az aktiválás sikeresen megtörtént! Kérjük indítsa újra a programot!");
                Close();
            }

            //MÁR BEAKTIVÁLT KULCS
            else if (kulcs_aktiv == 1)
            {
                hitelesitettKulcs = false;
                MessageBox.Show("A megadott licenszkulcs már be van aktiválva! Kérjük indítsa újra a programot és próbálja újra!");
                Close();
                Application.Exit();
            }
        }

        //PROGRAMBA LÉPÉS ENGEDÉLY ELLENŐRZÉSE
        public bool Hitelesitve()
        {
            return hitelesitettKulcs;
        }
    }
}

