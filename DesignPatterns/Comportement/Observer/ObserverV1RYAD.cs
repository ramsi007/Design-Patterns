using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structuration.Observer
{
    public class Program
    {
        //public static void Main()
        //{
        //    Eleve eleve = new Eleve();
        //    new NotesObserver(eleve);
        //    new AbsenceObserver(eleve);

        //    eleve.AjouterNote(15.0f);
        //    Console.WriteLine("Moyenne = " + eleve.GetMoyenne());

        //    eleve.AjouterNote(5.0f);
        //    Console.WriteLine("Moyenne = " + eleve.GetMoyenne());

        //    eleve.AjouterNote(13.0f);
        //    Console.WriteLine("Moyenne = " + eleve.GetMoyenne());

        //    eleve.AjouterAbsence();
        //    eleve.AjouterAbsence();
        //    eleve.AjouterAbsence();
        //    eleve.AjouterAbsence();

        //    Console.Read();
        //}
    }

    public abstract class Observer
    {
        protected Eleve Student;
        public abstract void Signal();
    }

    public class NotesObserver : Observer
    {
        public NotesObserver(Eleve eleve)
        {
            Student = eleve;
            Student.AttachObserver(this);
        }

        public override void Signal()
        {
            float somme = 0;
            foreach (float note in Student.GetNotes())
            {
                somme += note;
            }
            float moyenne = somme / Student.GetNotes().Count;
            Student.SetMoyenne(moyenne);
        }
    }

    public class AbsenceObserver : Observer
    {
        public AbsenceObserver(Eleve eleve)
        {
            Student = eleve;
            Student.AttachObserver(this);
        }

        public override void Signal()
        {
            if (Student.GetNombreAbsences() > 3)
            {
                Console.WriteLine("Attention !! Le nombre d'absences a dépassé !");
            }
        }
    }

    public class Eleve
    {
        private IList<Observer> ListeObservers;
        private IList<float> ListeNotes;
        private int NombreAbsences;
        private float Moyenne;

        public Eleve()
        {
            ListeObservers = new List<Observer>();
            ListeNotes = new List<float>();
        }

        // Chaque fois qu'on ajoute une nouvelle note à un élève, on doit notifier cela à tous les observateurs
        public void AjouterNote(float note)
        {
            ListeNotes.Add(note);
            NotifyAllObservers();
        }

        public float GetMoyenne()
        {
            return Moyenne;
        }

        public void SetMoyenne(float moyenne)
        {
            this.Moyenne = moyenne;
        }

        public IList<float> GetNotes()
        {
            return ListeNotes;
        }

        public void AjouterAbsence()
        {
            NombreAbsences++;
            NotifyAllObservers();
        }

        public int GetNombreAbsences()
        {
            return NombreAbsences;
        }

        public void AttachObserver(Observer observer)
        {
            ListeObservers.Add(observer);
        }

        public void DetachObserver(Observer observer)
        {
            ListeObservers.Remove(observer);
        }

        public void NotifyAllObservers()
        {
            foreach (Observer obs in ListeObservers)
            {
                obs.Signal();
            }
        }
    }

}
