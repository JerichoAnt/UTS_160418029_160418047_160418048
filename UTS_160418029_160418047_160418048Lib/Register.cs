using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace UTS_160418029_160418047_160418048Lib
{
    public class Register
    {


        public static void TambahUser(string pUsername, string pPassword, string pRole, string pName)
        {
            using (TransactionScope transcope = new TransactionScope())
            {
                try
                {
                    string sql = "insert into user(username, password, role, name) values ('" + pUsername + "','" + pPassword + "','" + pRole + "','" + pName + "')";

                    Koneksi.JalankanPerintahDML(sql);

                    transcope.Complete();
                }
                catch (Exception ex)
                {
                    transcope.Dispose();
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
