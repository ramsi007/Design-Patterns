//using System;
//using System.Collections.Generic;
//using System.Dynamic;
//using System.Text;

//namespace DesignPatterns.Comportement.Strategy2
//{
//    public class Program
//    {
//        public static void Main()
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;

//            Article article1 = new Article("Livre : 'Tout savoir sur le pattern Strategy'", 25);
//            Article article2 = new Article("Livre Design Pattern pour les Nuls", 5);
//            Article article3 = new Article("Cours Design Patterns à distance sur Udemy", 10);

//            Panier panier = new Panier();
//            panier.AjouterArticle(article1, 4);
//            panier.AjouterArticle(article2, 6);
//            panier.AjouterArticle(article3, 3);

//            // paiement par paypal
//            panier.Payer(new PaypalStrategy("idExemple", "passwordExemple"));

//            // paiement par carte de crédit
//            panier.Payer(new CarteDeCreditStrategy("1234567890123456", "786", "12/22"));

//            // paiement par virement
//            panier.Payer(new VirementStrategy());

//            Console.ReadKey();
//        }
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
//        public string Nom { get; }
//        public float Prix { get; }

//        public Article(string nom, float prix)
//        {
//            this.Nom = nom;
//            this.Prix = prix;
//        }
//    }

//    public class Panier
//    {
//        private IDictionary<Article, int> ListeArticles;

//        public Panier()
//        {
//            this.ListeArticles = new Dictionary<Article, int>();
//        }

//        public IDictionary<Article, int> GetListeArticle()
//        {
//            return this.ListeArticles;
//        }
//        public void AjouterArticle(Article article, int quantite)
//        {
//            this.ListeArticles.Add(article, quantite);
//        }

//        public void Payer(IPaiementStrategy methodePaiement)
//        {
//            float montant = 0;
//            foreach (var item in ListeArticles)
//            {
//                Article article = item.Key;
//                int quantite = item.Value;
//                montant += article.Prix * quantite;
//            }
//            methodePaiement.Payer(montant);
//        }
//    }
//}
