//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace DesignPatterns.Comportement.Strategy
//{
//    public class Program
//    {
//        //public static void Main()
//        //{
//        //    Console.OutputEncoding = System.Text.Encoding.UTF8;
//        //    Article article1 = new Article("Livre : 'Tout savoir sur le pattern Strategy'", 25);
//        //    Article article2 = new Article("Piano steinway & sons B-211", 51000);
//        //    Article article3 = new Article("Cours Design Patterns à distance sur Udemy", 10);

//        //    // paiement par paypal
//        //    article1.Payer(new PaypalStrategy("idExemple", "passwordExemple"));

//        //    // paiement par carte de crédit
//        //    article2.Payer(new CarteDeCreditStrategy("1234567890123456", "786", "12/22"));

//        //    // paiement par virement
//        //    article3.Payer(new VirementStrategy());


//        //    Console.ReadKey();
//        //}
//    }

//    public interface IPaiementStrategy
//    {
//        void Payer(float montant);
//    }

//    public class PaypalStrategy : IPaiementStrategy
//    {
//        private string Email;
//        private string Password;

//        public PaypalStrategy(string email, string password)
//        {
//            this.Email = email;
//            this.Password = password;
//        }

//        public void Payer(float montant)
//        {
//            Console.WriteLine(String.Format("{0:0.00}", montant) + " € payés par Paypal.");
//        }
//    }

//    public class CarteDeCreditStrategy : IPaiementStrategy
//    {
//        private string NumeroCarte;
//        private string Cryptogramme;
//        private string DateExpiration;

//        public CarteDeCreditStrategy(string numeroCarte, string cryptogramme, string dateExpiration)
//        {
//            this.NumeroCarte = numeroCarte;
//            this.Cryptogramme = cryptogramme;
//            this.DateExpiration = dateExpiration;
//        }

//        public void Payer(float montant)
//        {
//            Console.WriteLine(String.Format("{0:0.00}", montant) + " € payés par Carte de Crédit.");
//        }
//    }

//    public class VirementStrategy : IPaiementStrategy
//    {
//        public VirementStrategy()
//        {
//        }

//        public void Payer(float montant)
//        {
//            Console.WriteLine(String.Format("{0:0.00}", montant) + " € payés par Virement.");
//        }
//    }


//    public class Article
//    {
//        private string Nom;
//        private float Prix;

//        public Article(string nom, float prix)
//        {
//            this.Nom = nom;
//            this.Prix = prix;
//        }

//        public string GetNom()
//        {
//            return this.Nom;
//        }

//        public float GetPrix()
//        {
//            return this.Prix;
//        }

//        public void Payer(IPaiementStrategy methodePaiement)
//        {
//            methodePaiement.Payer(this.GetPrix());
//        }
//    }

//}
