﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structuration.DecoratorV2
{
    public class Decorator
    {
        //public static void Main()
        //{
        //    Voiture v = new Voiture();
        //    Console.WriteLine("Voiture sans précision : " + v);

        //    Console.WriteLine("================================================================");

        //    Voiture vCorsa = new Corsa();
        //    Console.WriteLine("Voiture CORSA: " + vCorsa);

        //    Voiture vCorsaReg = new Regulateur(vCorsa);
        //    Console.WriteLine("Voiture CORSA: " + vCorsaReg);

        //    Voiture vCorsaRegGps1 = new GPS(vCorsaReg);
        //    Console.WriteLine("Voiture CORSA: " + vCorsaRegGps1);

        //    Voiture vCorsaRegGps2 = new GPS(vCorsaRegGps1);
        //    Console.WriteLine("Voiture CORSA: " + vCorsaRegGps2);

        //    Voiture vCorsaRegGps3 = new GPS(vCorsaRegGps2);
        //    Console.WriteLine("Voiture CORSA: " + vCorsaRegGps3);

        //    Voiture vCorsaRegGpsToit = new ToitOuvrant(vCorsaRegGps3);
        //    Console.WriteLine("Voiture CORSA: " + vCorsaRegGpsToit);

        //    Console.WriteLine("================================================================");

        //    Voiture vC2 = new C2();
        //    Console.WriteLine("Voiture C2: " + vC2);

        //    Console.Read();
        //}
    }

    public class Voiture
    {
        private string Libelle;
        private int Prix;
        private int Poids;

        public string GetLibelle()
        {
            return Libelle;
        }

        public void SetLibelle(string libelle)
        {
            Libelle = libelle;
        }

        public int GetPrix()
        {
            return Prix;
        }

        public void SetPrix(int prix)
        {
            Prix = prix;
        }

        public int GetPoids()
        {
            return Poids;
        }

        public void SetPoids(int poids)
        {
            Poids = poids;
        }

        public override string ToString()
        {
            return "Voiture : Libelle = " + Libelle + ", Prix = " + Prix + ", Poids = " + Poids;
        }
    }

    public class Corsa : Voiture
    {
        public Corsa()
        {
            SetLibelle("Corsa");
            SetPrix(5000);
            SetPoids(1500);
        }
    }

    public class C2 : Voiture
    {
        public C2()
        {
            SetLibelle("C2");
            SetPrix(8000);
            SetPoids(2300);
        }
    }

    public abstract class DecorateurVoiture : Voiture
    {
        protected Voiture V;
        public abstract new string GetLibelle();
        public abstract new int GetPrix();
        public abstract new int GetPoids();
    }

    public class Regulateur : DecorateurVoiture
    {
        private string Libelle = "Regulateur";
        private int Prix = 200;
        private int Poids = 1;

        public Regulateur(Voiture v)
        {
            V = v;
            SetLibelle(GetLibelle());
            SetPoids(GetPoids());
            SetPrix(GetPrix());
        }

        public override string GetLibelle()
        {
            return V.GetLibelle() + " avec " + this.Libelle;
        }

        public override int GetPoids()
        {
            return V.GetPoids() + this.Poids;
        }

        public override int GetPrix()
        {
            return V.GetPrix() + this.Prix;
        }
    }

    public class GPS : DecorateurVoiture
    {
        private string Libelle = "GPS";
        private int Prix = 1000;
        private int Poids = 3;

        public GPS(Voiture v)
        {
            if (v.GetType().Name != this.GetType().Name)
            {
                V = v;
                SetLibelle(GetLibelle());
                SetPrix(GetPrix());
                SetPoids(GetPoids());
            }
            else
            {
                SetLibelle(v.GetLibelle());
                SetPrix(v.GetPrix());
                SetPoids(v.GetPoids());
            }
        }

        public override string GetLibelle()
        {
            return V.GetLibelle() + " avec " + this.Libelle;
        }

        public override int GetPoids()
        {
            return V.GetPoids() + this.Poids;
        }

        public override int GetPrix()
        {
            return V.GetPrix() + this.Prix;
        }
    }

    public class ToitOuvrant : DecorateurVoiture
    {
        private string Libelle = "Toit ouvrant";
        private int Prix = 2000;
        private int Poids = 15;

        public ToitOuvrant(Voiture v)
        {
            V = v;
            SetLibelle(GetLibelle());
            SetPoids(GetPoids());
            SetPrix(GetPrix());
        }

        public override string GetLibelle()
        {
            return V.GetLibelle() + " avec " + this.Libelle;
        }

        public override int GetPoids()
        {
            return V.GetPoids() + this.Poids;
        }

        public override int GetPrix()
        {
            return V.GetPrix() + this.Prix;
        }
    }

}
