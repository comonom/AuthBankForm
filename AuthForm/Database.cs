using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthForm
{
    public class Database
    {
        MySqlConnection connection = new MySqlConnection("server=cfif31.ru;user ID=ISPr24-38_GilazovaAR;password=ISPr24-38_GilazovaAR;database=ISPr24-38_GilazovaAR_BankDB;CharSet=utf8;Connection Timeout=3600");
        public static Database Instance = new Database();

        //private static Database _instance = null;
        //public static Database Instance
        //{
        //    get
        //    {
        //        return _instance ?? (_instance = new Database());
        //    }
        //} //другой супер пупер конструктор, который я забуду 
        public Database()
        {
            connection.Open();
        }

        public DataTable SqlZapros(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, connection);
            using (var reader = command.ExecuteReader())
            {
                DataTable table = new DataTable();
                table.Load(reader);
                return table;
            }
        }
        public void NonQuerryZapros(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
        }
    }
}
