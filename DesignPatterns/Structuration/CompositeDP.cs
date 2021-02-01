using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structuration
{
    public class Program
    {
        //public static void Main()
        //{
        //    Remorque remorque = new Remorque(11);
        //    Console.WriteLine("Le poids de ma remorque est : " + remorque.GetPoids());

        //    Tracteur tracteur = new Tracteur(8);
        //    Console.WriteLine("Le poids de mon tracteur est : " + tracteur.GetPoids());

        //    Charge charge = new Charge(5);
        //    Console.WriteLine("Le poids de ma charge est : " + charge.GetPoids());

        //    CamionComposite semiRemorque = new CamionComposite();
        //    semiRemorque.AjouterComposant(remorque);
        //    semiRemorque.AjouterComposant(tracteur);
        //    semiRemorque.AjouterComposant(charge);
        //    Console.WriteLine("Le poids de mon Semi-Remorque est : " + semiRemorque.GetPoids());

        //    Console.WriteLine();
        //    Console.WriteLine("Liste de tous les composants de mon Semi-Remorque : ");
        //    IList<IComposant> listeComposants = semiRemorque.getAllComposants();
        //    foreach (var c in listeComposants)
        //    {
        //        Console.WriteLine("  => " + c.GetType().Name);
        //    }

        //}
    }

    public interface IComposant
    {
        int GetPoids();
    }

    public class Remorque : IComposant
    {
        private int Poids;

        public Remorque(int poids)
        {
            this.Poids = poids;
        }

        public int GetPoids()
        {
            return this.Poids;
        }
    }

    public class Tracteur : IComposant
    {
        private int Poids;

        public Tracteur(int poids)
        {
            this.Poids = poids;
        }

        public int GetPoids()
        {
            return this.Poids;
        }
    }

    public class Charge : IComposant
    {
        private int Poids;

        public Charge(int poids)
        {
            this.Poids = poids;
        }

        public int GetPoids()
        {
            return this.Poids;
        }
    }

    public class CamionComposite : IComposant
    {
        private IList<IComposant> Children;

        public CamionComposite()
        {
            Children = new List<IComposant>();
        }

        public int GetPoids()
        {
            int poidsTotal = 0;
            foreach (var composant in Children)
            {
                poidsTotal += composant.GetPoids();  // <=> poidsTotal = poidsTotal + composant.GetPoids();
            }
            return poidsTotal;
        }

        public void AjouterComposant(IComposant composant)
        {
            // exercie :
            // assurez-vous ici que la liste des composants (Children) ne doit contenir qu'un seul tracteur
            Children.Add(composant);
        }

        public void RetirerComposant(IComposant composant)
        {
            Children.Remove(composant);
        }

        public IList<IComposant> getAllComposants()
        {
            return Children;
        }
    }
}








