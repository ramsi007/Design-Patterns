//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace DesignPatterns.Comportement
//{

//    // Sans Design Pattern
//    //class Video
//    //{
//    //    private string Etat = "";
//    //    public void SetEtat(string etat)
//    //    {
//    //        this.Etat = etat;
//    //    }

//    //    public void Action()
//    //    {
//    //        if(string.Equals(Etat, "PLAY", StringComparison.OrdinalIgnoreCase))
//    //        {
//    //            Console.WriteLine("La video est en Lecturte");
//    //        }
//    //        else if (string.Equals(Etat, "PAUSE", StringComparison.OrdinalIgnoreCase))
//    //        {
//    //            Console.WriteLine("La video est en Pause");
//    //        }
//    //        else if (string.Equals(Etat, "DEBUT", StringComparison.OrdinalIgnoreCase))
//    //        {
//    //            Console.WriteLine("La video recommence depuis le début");
//    //        }
//    //    }
//    //}

//    public interface IEtatVideo
//    {
//        public void Action(Video v);
//    }


//    class VideoEnLecture : IEtatVideo
//    {
//        public void Action(Video v)
//        {
//            Console.WriteLine("La vidéo est en lecture");
//        }
//    }

//    class VideoEnPause : IEtatVideo
//    {
//        public void Action(Video v)
//        {
//            Console.WriteLine("La vidéo est en Pause");
//        }
//    }

//    class RetourAuDebut : IEtatVideo
//    {
//        public void Action(Video v)
//        {
//            Console.WriteLine("La vidéo recommence depuis le début");
//        }
//    }

//    class SeRendreAuMilieu : IEtatVideo
//    {
//        public void Action(Video v)
//        {
//            Console.WriteLine("La vidéo s'est rendu au milieu");
//        }
//    }

//    public class Video
//    {
//        //creer un nouveau objet de l'interface (qui est une classe de base)
//        private IEtatVideo EtatVideo;

//        // Declaration du methode setState
//        public void SetState(IEtatVideo newEtat)
//        {
//            this.EtatVideo = newEtat;
//        }

//        public void Action()
//        {
//            EtatVideo.Action(this);
//        }
//    }

//    public class Program
//    {
//        public static void Main()
//        {
//            Video video = new Video();

//            video.SetState(new VideoEnLecture());
//            video.Action();

//            video.SetState(new VideoEnPause());
//            video.Action();

//            video.SetState(new RetourAuDebut());
//            video.Action();

//            video.SetState(new SeRendreAuMilieu());
//            video.Action();

//            Console.ReadKey();
//        }
//    }
//}
