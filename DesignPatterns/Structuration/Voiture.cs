//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Text;

//namespace DesignPatterns.Structuration.DecorateurV1
//{
//    public class Decorateur
//    {
//        public static void Main()
//        {
//            Voiture vCorsa = new Corsa();
//            Console.WriteLine("Voiture : " + vCorsa);

//            Voiture vC2 = new C2();
//            Console.WriteLine("Voiture : " + vC2);

//            Voiture vCorsaReg = new Regulateur(vCorsa);
//            Console.WriteLine("Voiture : " + vCorsaReg);

//            Voiture vC2GPS = new Regulateur(vC2);
//            Console.WriteLine("Voiture  :" + vC2GPS);

//            Voiture vCorsa1 = new Corsa();
//            Voiture vCorsa2 = new GPS(vCorsa1);
//            Voiture vCorsa3 = new Regulateur(vCorsa2);
//            Voiture vCorsa4 = new ToitOuvrant(vCorsa3);

//            Console.WriteLine("Voiture Corsa =>" + vCorsa4);
           
//        }

//        public class Voiture
//        {
//            private string Libelle;
//            private int Prix;
//            private int Poids;

//            public virtual string GetLibelle()
//            {
//                return this.Libelle;
//            }

//            public virtual int GetPrix()
//            {

//                return this.Prix;
//            }

//            public virtual int GetPoids()
//            {

//                return this.Poids;
//            }

//            public void SetLibelle(string libelle)
//            {
//                Libelle = libelle;
//            }

//            public void SetPrix(int Prix)
//            {

                
//            }

//            public void SetPoids(int Poid)
//            {

//            }

//            public override string ToString()
//            {
//                return "Libellé de la Voiture : " + GetLibelle() + " Prix : " + GetPrix() + "Poid : " + GetPoids();
//            }
//        }

//        public class Corsa :Voiture
//        { 
//            public Corsa()
//            {
//               base.SetLibelle("Corsa");
//               base.SetPoids(5000);
//               base.SetPrix(1500);
//            }

//            public override string GetLibelle()
//            {
//                return base.Libelle;
//            }

//            public override int GetPrix()
//            {

//                return base.Prix;
//            }

//            public override int GetPoids()
//            {

//                return base.Poids;
//            }
//        }

//        public class C2 :Voiture
//        {
//           public C2()
//           {
//              base.SetLibelle("C2");
//              base.SetPoids(4000);
//              base.SetPrix(1000);
//           }

//            public override string GetLibelle()
//            {
//                return base.Libelle;
//            }

//            public override int GetPrix()
//            {

//                return base.Prix;
//            }

//            public override int GetPoids()
//            {

//                return base.Poids;
//            }
//        }

//        public abstract class DecorateurVoiture: Voiture
//        {
//           public Voiture voiture;

//            public override string GetLibelle()
//            {
//                return base.Libelle;
//            }

//            public override int GetPrix()
//            {

//                return base.Prix;
//            }

//            public override int GetPoids()
//            {

//                return base.Poids;
//            }
//        }

//        class ToitOuvrant: DecorateurVoiture
//        {

//            public ToitOuvrant(Voiture v)
//            {

//            }
//            public override string GetLibelle()
//            {
//                return base.Libelle;
//            }

//            public override int GetPrix()
//            {

//                return base.Prix;
//            }

//            public override int GetPoids()
//            {

//                return base.Poids;
//            }
//        }

//        class GPS : DecorateurVoiture
//        {

//            public GPS(Voiture v)
//            {

//            }
//            public override string GetLibelle()
//            {
//                return base.Libelle;
//            }

//            public override int GetPrix()
//            {

//                return base.Prix;
//            }

//            public override int GetPoids()
//            {

//                return base.Poids;
//            }
//        }

//        class Regulateur : DecorateurVoiture
//        {
//            public Regulateur(Voiture v)
//            {

//            }

//            public override string GetLibelle()
//            {
//                return base.Libelle;
//            }

//            public override int GetPrix()
//            {

//                return base.Prix;
//            }

//            public override int GetPoids()
//            {

//                return base.Poids;
//            }
//        }

//    }
//}
