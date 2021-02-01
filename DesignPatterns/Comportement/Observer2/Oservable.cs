//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace DesignPatterns.Comportement.Observer2
//{
//    class Oservable
//    {
//        // Interface implémentée par tous les observateurs.
//        public interface Observateur
//        {
//            // Méthode appelée automatiquement lorsque l'état (position ou précision) du GPS change
//            public void Actualiser(Observable o);
//        }
     
  

//        // Interface implémentée par toutes les classes souhaitant avoir des observateurs à leur écoute.
//        public interface Observable
//        {
//         // Méthode permettant d'ajouter (abonner) un observateur.
//         public void ajouterObservateur(Observateur o);

//         // Méthode permettant de supprimer (résilier) un observateur.
//         public void supprimerObservateur(Observateur o);

//        // Méthode qui permet d'avertir tous les observateurs lors d'un changement d'état.
//        public void notifierObservateurs();
//            bool IsInstanceOfType(Gps gps);
//        }
    

//        // Classe représentant un GPS (appareil permettant de connaître sa position).
//        public class Gps : Observable
//        {
//        private String position;// Position du GPS.

//        private int precision;// Précision accordé à cette position (suivant le nombre de satellites utilisés).

//        private List<Observateur> listeObservateur;// Tableau d'observateurs.

//            // Permet d'ajouter (abonner) un observateur à l'écoute du GPS.
//            public void ajouterObservateur(Observateur o)
//            {
//                foreach (var ob in listeObservateur)
//                    listeObservateur.Add(ob);
//            }

//            // Méthode permettant de notifier tous les observateurs lors d'un changement d'état du GPS.
//            public void notifierObservateurs()
//            {
//                foreach(var ob in listeObservateur)
//                {
//                    ob.Actualiser(this);
//                }
//            }

//            // Permet de supprimer (résilier) un observateur écoutant le GPS
//            public void supprimerObservateur(Observateur o)
//            {
//                foreach (var ob in listeObservateur)
//                    listeObservateur.Remove(ob);
//            }

//            // Méthode qui permet de mettre à jour de façon artificielle le GPS.
//            // Dans un cas réel, on utiliserait les valeurs retournées par les capteurs.

//            public void setMesures(String position, int precision)
//            {
//                this.position = position;
//                this.precision = precision;
//                notifierObservateurs();
//            }

//            // Méthode "tiré" donc c'est aux observeurs d'aller chercher les valeurs désiré grâce à un objet Gps.
//            // Pour cela on trouve un accesseur en lecture pour position.

//            public String getPosition()
//            {
//                return position;
//            }
//            // Un accesseur en lecture pour précision.
//            public int getPrecision()
//            {
//                return precision;
//            }

//            public bool IsInstanceOfType(Gps gps)
//            {
//                throw new NotImplementedException();
//            }
//        }

//        // Affiche un résumé en console des informations (position) du GPS.
//        public class AfficheResume : Observateur
//        {
//            // Méthode appelée automatiquement lors d'un changement d'état du GPS.
//            public void Actualiser(Observable o)
//            {
//                if (o.IsInstanceOfType(Gps))
//                {
//                    Gps g = (Gps)o;
//                    Console.WriteLine("Position : " + g.getPosition());
//                }
//            }
//        }
//    // Affiche en console de façon complète les informations (position et précision) du GPS.

//    public class AfficheComplet : Observateur
//    {
//        // Méthode appelée automatiquement lors d'un changement d'état du GPS.
//        public void Actualiser(Observable o)
//        {
//        if (o.IsInstanceOfType(Gps))
//            {
//            Gps g = (Gps)o;
//             Console.WriteLine("Position : " + g.getPosition() + "  Précision : " + g.getPrecision() + "/10");
//            }
//        }

//    }

//    }
//}
