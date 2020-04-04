using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace UTS_160418029_160418047_160418048Lib
{
    public class Koneksi
    {
        private MySqlConnection koneksiDB;

        #region Properties
        public MySqlConnection KoneksiDB { get => koneksiDB; private set => koneksiDB = value; }
        #endregion

        #region Constructors
        public Koneksi()
        {
            KoneksiDB = new MySqlConnection();

            KoneksiDB.ConnectionString = ConfigurationManager.ConnectionStrings["koneksiku"].ConnectionString;

            Connect();
        }
        public Koneksi(string server, string database, string username, string password)
        {
            string connection;
            if (password != "")
            {
                connection = "Server=" + server + ";Database=" + database + ";Uid=" + "root" + ";Pwd=" + password + ";";
            }
            else
            {
                connection = "Server=" + server + ";Database=" + database + ";Uid=" + "root" + ";";
            }

            KoneksiDB = new MySqlConnection();

            KoneksiDB.ConnectionString = connection;

            Connect();
            UpdateAppConfig(connection);
        }
        #endregion

        #region Methods
        public void Connect()
        {
            if (KoneksiDB.State == System.Data.ConnectionState.Open)
            {
                KoneksiDB.Close();
            }
            KoneksiDB.Open();
        }

        public void UpdateAppConfig(string pConnectionString)
        {
            Configuration myConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            myConfig.ConnectionStrings.ConnectionStrings["koneksiku"].ConnectionString = pConnectionString;

            myConfig.Save(ConfigurationSaveMode.Modified, true);

            ConfigurationManager.RefreshSection("connectionStrings");
        }

        public static void JalankanPerintahDML(string sql)
        {
            Koneksi koneksi = new Koneksi();

            MySqlCommand command = new MySqlCommand(sql, koneksi.KoneksiDB);

            command.ExecuteNonQuery();
        }

        public static MySqlDataReader JalankanPerintahQuery(string sql)
        {
            Koneksi k = new Koneksi();

            MySqlCommand command = new MySqlCommand(sql, k.KoneksiDB);

            MySqlDataReader hasil = command.ExecuteReader();

            return hasil;
        }
        public static string GetNamaServer()
        {
            // ambil connection string yg tersimpan di App.config
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["koneksiku"].ConnectionString;

            // ambil nama server
            return con.DataSource;
        }

        public static string GetNamaDatabase()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["koneksiku"].ConnectionString;

            return con.Database;
        }
    }
}
#endregion
