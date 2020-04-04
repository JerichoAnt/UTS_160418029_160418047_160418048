using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS_160418029_160418047_160418048Lib
{
    public class User
    {
        private int id;
        private string username;
        private string password;
        private string role;
        private string name;

        public User(int id, string username, string password, string role, string name)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.Role = role;
            this.Name = name;
        }

        public User(string username, string role)
        {
            this.Id = id;
            this.Username = username;
            this.Role = role;
        }

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        public string Name { get => name; set => name = value; }

        public static void BuatUserBaru(User user, string namaServer)
        {
            string sql = "create user '" + user.Username + "'@'" + namaServer + "' identified by '" +
                user.Password + "'";
            Koneksi.JalankanPerintahDML(sql);
        }

        public static void BeriHakAkses(User user, string namaServer, string namaDatabase)
        {
            string sql = "grant all privileges on " + namaDatabase + ".* to '" + user.Username +
                "'@'" + namaServer + "'";
            Koneksi.JalankanPerintahDML(sql);
        }

        public static void ManajemenUser(User u)
        {
            string namaServer = Koneksi.GetNamaServer();
            string namaDatabase = Koneksi.GetNamaDatabase();

            User.BuatUserBaru(u, namaServer);
            User.BeriHakAkses(u, namaServer, namaDatabase);
        }

        public static List<User> BacaData(string pUsername)
        {
            string sql = "";

            if (pUsername == "")
            {
                sql = "SELECT username,role from user";
            }
            else
            {
                sql = "SELECT username,role from user where username like '%" + pUsername + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<User> listUser = new List<User>();
            while (hasil.Read() == true)
            {
                User u = new User(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString());
                listUser.Add(u);
            }
            return listUser;
        }
        public static bool cekUser(string username)
        {
            List<User> users = new List<User>();
            users=BacaData(username);
            bool duplikat = false;
            if (users.Count() > 0)
                duplikat = true;
            
            return duplikat;
        }
        public static int getRegisterId()
        {
            List<User> users = new List<User>();
            users = BacaData("");
            return users.Count() + 1;
        }
    }


}
