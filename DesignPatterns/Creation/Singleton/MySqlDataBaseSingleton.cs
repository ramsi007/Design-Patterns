using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace DesignPatterns.Creation.Singleton
{

    public sealed class MySqlDataBaseSingleton
    {
        private static readonly string urlConnection = "SERVER=127.0.0.1; DATABASE=doranco_db; UID=root; PWD=root";
        private static MySqlDataBaseSingleton instance = null;

        private MySqlDataBaseSingleton()
        {
        }

        // pour empêcher l'accès simultané de plusieurs threads
        // [on utilise ici le verrouillage sur la variable concernée]


        public static MySqlDataBaseSingleton GetInstance2()
        {
            //lock (instance)
            //{
            //    ...ici votre code de la méthode GetInstance()
            //}
            return instance;
        }

        // pour empêcher l'accès simultané de plusieurs threads (un seul thread à la fois)
        // [on utilise ici la synchronisation sur la méthode ]
        [MethodImpl(MethodImplOptions.Synchronized)]

        public static MySqlDataBaseSingleton GetInstance()
        {
            Console.WriteLine("Récupération de l'instance...");
            // Nous permet de renvoyer toujours la même instance unique
            if (instance == null)
            {
                instance = new MySqlDataBaseSingleton();
            }
            return instance;
        }

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

        //public class getSingleton2 : MySqlDataBaseSingleton
        //{

        //}

    }
}

