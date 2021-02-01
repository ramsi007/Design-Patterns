using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creation.Singleton
{
    public class MySqlDataBase
    {
        private static string urlConnection = "SERVER=127.0.0.1; DATABASE=doranco_db; UID=root; PWD=root";

        public MySqlConnection getConnection()
        {
            MySqlConnection connection = null;

            try
            {
                connection = new MySqlConnection(urlConnection);
                connection.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur !");
                Console.WriteLine(ex);
            }
            return connection;
        }
    }
}