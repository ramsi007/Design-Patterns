//using System;
//using System.Collections.Generic;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;

//namespace DesignPatterns.Structuration
//{
//    public class Composite
//    {
//        public static void Main()
//        {
//            Remorque maRemorque = new Remorque(11);
//            Console.WriteLine("Le poids de ma remorque est :" + maRemorque.getPoid() + " tonnes");

//            Tracteur monTracteur = new Tracteur(8);
//            Console.WriteLine("Le poids de mon trateur est :" + monTracteur.getPoid() + " tonnes");

//            Charge maCharge = new Charge(10);
//            Console.WriteLine("Le poids de ma Charge est :" + maCharge.getPoid() + " tonnes");

//            CamionComposite semiRemorque = new CamionComposite();
//            semiRemorque.Ajouter(maRemorque);
//            semiRemorque.Ajouter(monTracteur);
//            semiRemorque.Ajouter(maCharge);

//            Console.WriteLine("Le poid de mon semi-remorque est de : "+ semiRemorque.getPoid() + " Tonnes");

//            Console.ReadLine();

//            semiRemorque.Retirer(monTracteur);
//            Console.WriteLine("Le poid de mon semi-remorque est de : " + semiRemorque.getPoid() + " Tonnes");

//            semiRemorque.Ajouter(monTracteur);
//            Console.WriteLine("Le poid de mon semi-remorque est de : " + semiRemorque.getPoid() + " Tonnes");

//            semiRemorque.Ajouter(monTracteur);
//            Console.WriteLine("Le poid de mon semi-remorque est de : " + semiRemorque.getPoid() + " Tonnes");
//        }

//        public interface IComposant
//        {
//            int getPoid();
//        }

//        class Remorque : IComposant
//        {
//            private int Poids;

//            public Remorque(int poid)
//            {
//                this.Poids = poid;
//            }

//            public int getPoid()
//            {
//                return this.Poids;
//            }
//        }

//        class Tracteur : IComposant
//        {
//            private int Poids;

//            public Tracteur(int poid)
//            {
//                this.Poids = poid;
//            }

//            public int getPoid()
//            {
//                return this.Poids;
//            }
//        }

//        class Charge : IComposant
//        {
//            private int Poids;

//            public Charge(int poid)
//            {
//                this.Poids = poid;
//            }

//            public int getPoid()
//            {
//                return this.Poids;
//            }
//        }

//        public class CamionComposite 
//            {
//                List<IComposant> Children;

//                public CamionComposite()
//                {
//                    Children = new List<IComposant>();
//                }

//            public void Ajouter(IComposant c)
//            {
//                // exercie :
//                // assurez-vous ici que la liste des composants (Children) ne doit contenir qu'un seul tracteur
//                int compt = 0;
//                IComposant composant= new Tracteur();
//                foreach ( var com in Children)
//                {
//                    if(com.GetType().Name.ToString() == "Tracteur")
//                    {
//                        compt++;
//                        Console.WriteLine(com.GetType().Name + " Compteur : " + compt);
//                    }
//                }
//                    if (compt==0 || (compt!=0  && composant.GetType().Name != "Tracteur"))
//                    {
//                    Children.Add(c);
//                    Console.WriteLine("Compteur :" + compt);
//                    Console.WriteLine(Children.GetType().Name.ToString());
//                }

//                    else
//                    Console.WriteLine("Votre Semi-Remorque Contien déja un Tracteur");
//                    Console.WriteLine("Compteur :" + compt);
//                    Console.WriteLine(Children.GetType().Name.ToString());
//            }

//            public void Retirer(IComposant c)
//                {
//                    Children.Remove(c);
//                }

//                public int getPoid()
//                {
//                    int poidT = 0;
//                    foreach(var c in Children)
                   
//                    poidT += c.getPoid();

//                return poidT;
//                }
//            }
        
//    }
//}
