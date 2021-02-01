//using System;
//using System.Collections.Generic;
//using System.Reflection.Metadata.Ecma335;
//using System.Text;

//namespace DesignPatterns.Comportement.Observer
//{
//    class ObserverV1
//    {
//        public class Eleve
//        {
//            List<Observer> Observers = new List<Observer>();
//            List<float> Notes = new List<float>();


//            public Eleve ()
//            {
//                this.Observers = null;
//                this.Notes = null;
//            }

//            public void AjouterNote(float note)
//            {
//                foreach (var n in Notes)
//                    Notes.Add(note);
//            }

//            public float getMoyenne()
//            {
//                float somme = 0;
//                int cpt = 0;
//                foreach (var n in Notes)
//                {
//                somme += n;
//                cpt++;
//                }
//                return somme / cpt;
                
//            }

//            public void setMoyenne(float moyenne)
//            {
//                moyenne = getMoyenne();
//            }

//            public List<float> getNotes()
//            {
//                return Notes;
//            }

//            public void AttachObserver(Observer observer)
//            {
//                foreach (var obs in Observers)
//                    Observers.Add(observer);
//            }

//            public void DetachObserver(Observer observer)
//            {
//                foreach (var obs in Observers)
//                    Observers.Remove(observer);
//            }

//            public void NotifyAllObservers()
//            {

//            }

//        }

//        public abstract class Observer
//        {
//            Eleve eleve;

//            public abstract void Update();

//        }

//        public class NotesObserver
//        {
//            public NotesObserver()
//            {

//            }
            
//            NotesObserver noteOb = new NotesObserver();
//            Eleve eleveN;
//            public NotesObserver(Eleve eleve)
//            {
//                this.eleveN = eleve;
//                //eleve.AttachObserver();

//            }

//           public void Update()
//           {

//           }
//        }

//    }
//}
