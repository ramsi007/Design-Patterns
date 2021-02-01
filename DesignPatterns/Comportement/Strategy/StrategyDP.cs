//using System;
//using System.Collections.Generic;
//using System.Security.Cryptography;
//using System.Text;

//namespace DesignPatterns.Comportement.Strategy
//{
//    public class StrategyDP
//    {
//        //public static void Main()
//        //{
//        //    Article a1 = new Article("Livre : ' Tous Savoir sur Le pattern Strategy'", 25);
//        //    Article a2 = new Article("Piano steinway & sons B-11", 51000);
//        //    Article a3 = new Article("A book & sons B-11", 500);

//        //    a1.Payer(new PaypalStrategy("idExemple", "PasswordExemple"));

//        //    a2.Payer(new CarteDeCreditStrategy("123456789", "786", "12/22"));
//        //    a3.Payer(new Especes());

//        //    Panier p1 = new Panier("Livre",500);

//        //    Console.ReadKey();

//        //}

//        public interface IPaiementStrategy
//        {
//            public void Payer(float montant);
//        }

//        public class PaypalStrategy : IPaiementStrategy
//        {
//            private string v1;
//            private string v2;

//            public PaypalStrategy(string v1, string v2)
//            {
//                this.v1 = v1;
//                this.v2 = v2;
//            }

//            public void Payer(float montant)
//            {
//                Console.WriteLine("Le Montant de : "+ montant  + " Euros est payés par Paypal ... ");
//            }
//        }

//        public class CarteDeCreditStrategy : IPaiementStrategy
//        {
//            private string v1;
//            private string v2;
//            private string v3;

//            public CarteDeCreditStrategy(string v1, string v2, string v3)
//            {
//                this.v1 = v1;
//                this.v2 = v2;
//                this.v3 = v3;
//            }

//            public void Payer(float montant)
//            {
//                Console.WriteLine("Le Montant de :" + montant + " Euros est payés par Carte Crédit.");
//            }
//        }

//        public class Especes : IPaiementStrategy
//        {
//            public Especes()
//            {

//            }

//            public void Payer(float montant)
//            {
//                Console.WriteLine("Le Montant de : " + montant + " Euros est payés par Espèces");
//            }
//        }

//        public class Article
//        {
//            public string Nom;
//            public float Prix;

//            public Article(string nom, float prix)
//            {
//                this.Nom = nom;
//                this.Prix = prix;
//            }

//            public string GetNom()
//            {
//                return Nom;
//            }

//            public float GetPrix()
//            {
//                return Prix;
//            }

//            public void Payer(IPaiementStrategy PaiementStrategy)
//            {
//                float montant = this.GetPrix();
//                PaiementStrategy.Payer(montant);
//            }
//        }

//        public class Panier
//        {
//            List<string> A = new List<string>();
//            List<float> PrixArticles = new List<float>();


//            public Panier(string noms, float prix)
//            {
//                foreach( var e in NomArticles)
//                {
//                this.NomArticles = noms;
//                this.PrixArticles = prix;
//                }

//            }

//            public List<string> GetNom()
//            {
//                return NomArticles;
//            }

//            public List<float> GetPrix()
//            {
//                return PrixArticles;
//            }

//            public void Payer(IPaiementStrategy PaiementStrategy)
//            {
//                List<float> montant;
//                foreach (float m in PrixArticles)
//                 montant = this.GetPrix();

//                //float List <montant> = this.GetPrix();
//                //PaiementStrategy.Payer(montant);
//            }
//        }

//    }
//}
