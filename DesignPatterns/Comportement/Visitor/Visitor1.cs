using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Comportement.Visitor
{
    //public class Program
    //{
    //    public static void Main()
    //    {
    //        IElementVoitureVisitor printVisitor = new ElementVoiturePrintVisitor();
    //        IElementVoitureVisitor doVisitor = new ElementVoitureDoVisitor();

    //        Voiture voiture = new Voiture();

    //        printVisitor.VisitVoiture(voiture);
    //        doVisitor.VisitVoiture(voiture);

    //        Console.ReadKey();

    //    }
    //}

    public class Voiture
    {
        //IList<IElementVoiture> ListeElements;
        public IElementVoiture[] Elements { get; }

        public Voiture()
        {
            this.Elements = new IElementVoiture[] {
                new Roue("Avant Gauche"),
                new Roue("Avant Droit"),
                new Roue("Arrière Gauche"),
                new Roue("Arrière Droit"),
                new Moteur(),
                new Carosserie()
            };
        }
    }

    public interface IElementVoiture
    {
        void Accept(IElementVoitureVisitor visitor);
    }

    public class Roue : IElementVoiture
    {
        public string Name { get; }

        public Roue(string name)
        {
            this.Name = name;
        }

        public void Accept(IElementVoitureVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Moteur : IElementVoiture
    {
        public void Accept(IElementVoitureVisitor visitor)
        {
            visitor.Visit(this);
        }

    }

    public class Carosserie : IElementVoiture
    {
        public void Accept(IElementVoitureVisitor visitor)
        {
            visitor.Visit(this);
        }

    }

    public interface IElementVoitureVisitor
    {
        void Visit(Roue roue);
        void Visit(Moteur moteur);
        void Visit(Carosserie carosserie);
        void VisitVoiture(Voiture voiture);
    }

    public class ElementVoiturePrintVisitor : IElementVoitureVisitor
    {
        public void Visit(Roue roue)
        {
            Console.WriteLine("Visite de " + roue.Name + " roue");
        }

        public void Visit(Moteur moteur)
        {
            Console.WriteLine("Visite de Moteur");
        }

        public void Visit(Carosserie carosserie)
        {
            Console.WriteLine("Visite de la Carosserie");
        }

        public void VisitVoiture(Voiture voiture)
        {
            Console.WriteLine();
            Console.WriteLine("Visite de Moteur");
        }
    }

    public class ElementVoitureDoVisitor : IElementVoitureVisitor
    {
        public void Visit(Roue roue)
        {
            Console.WriteLine("coups de pied sur roue " + roue.Name);
        }

        public void Visit(Moteur moteur)
        {
            Console.WriteLine("Démarrer mon moteur");
        }

        public void Visit(Carosserie carosserie)
        {
            Console.WriteLine("Déplacer ma carosserie");
        }

        public void VisitVoiture(Voiture voiture)
        {
            Console.WriteLine();
            Console.WriteLine("Démarrer ma voiture");
            foreach (IElementVoiture element in voiture.Elements)
            {
                element.Accept(this);
            }
            Console.WriteLine(" => Voiture en marche.");
        }
    }

}
