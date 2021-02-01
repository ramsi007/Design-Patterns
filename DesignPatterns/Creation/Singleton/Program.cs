//using DesignPatterns.Creation.Singleton;
//using MySql.Data.MySqlClient;
//using System;
//using System.Threading;
//using System.Threading.Tasks;

//namespace DesignPatterns.Singleton
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Console.WriteLine("Sans Singleton :");
//            //Console.WriteLine("----------------");

//            //MySqlDataBase inst1 = new MySqlDataBase();
//            //Console.WriteLine("inst 1 = " + inst1.GetHashCode());

//            //MySqlDataBase inst2 = new MySqlDataBase();
//            //Console.WriteLine("inst 2 = " + inst2.GetHashCode());

//            //MySqlDataBase inst3 = new MySqlDataBase();
//            //Console.WriteLine("inst 3 = " + inst3.GetHashCode());

//            //Console.WriteLine();
//            //Console.WriteLine("Avec Singleton :");
//            //Console.WriteLine("----------------");

//            ////MySqlDataBaseSingleton instance1 = MySqlDataBaseSingleton.GetInstance();
//            ////MySqlDataBaseSingleton instance2 = MySqlDataBaseSingleton.GetInstance();
//            ////MySqlDataBaseSingleton instance3 = MySqlDataBaseSingleton.GetInstance();


//            ////Console.WriteLine("instance 1 : " + instance1.GetHashCode());
//            ////Console.WriteLine("instance 2 : " + instance2.GetHashCode());
//            ////Console.WriteLine("instance 3 : " + instance3.GetHashCode());



//            //Parallel.Invoke(
//            //() =>
//            //    {
//            //        Thread.Sleep(1000);
//            //        MySqlDataBaseSingleton instance1 = MySqlDataBaseSingleton.GetInstance();
//            //        Console.WriteLine("instance 1 : " + instance1.GetHashCode());
//            //    },
//            //() =>
//            //    {
//            //        Thread.Sleep(1000);
//            //        MySqlDataBaseSingleton instance2 = MySqlDataBaseSingleton.GetInstance();
//            //        Console.WriteLine("instance 2 : " + instance2.GetHashCode());
//            //    },
//            //() =>
//            //{
//            //    Thread.Sleep(1000);
//            //    MySqlDataBaseSingleton instance3 = MySqlDataBaseSingleton.GetInstance();
//            //    Console.WriteLine("instance 3 : " + instance3.GetHashCode());
//            //});

//            //Console.Read();


//            /* Déclarer la class de type sealed empêche l(instanciation d'un nouveau objet Connexion
//            //MySqlDataBaseSingleton.getSingleton2 getS = new MySqlDataBaseSingleton.getSingleton2();

//            //Console.WriteLine("instance fille : " + getS.GetHashCode());

         
//            */
//        }
//    }
//}
