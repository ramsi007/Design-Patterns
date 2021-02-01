//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace DesignPatterns.Comportement.WithDP
//{
//    public class StateWithDesignPattern
//    {
//        public static void Main()
//        {
//            Video video = new Video();

//            video.SetEtatVideo(new VideoEnDebut());
//            video.Action();

//            video.SetEtatVideo(new VideoEnLecture());
//            video.Action();

//            video.SetEtatVideo(new VideoEnPause());
//            video.Action();

//            video.SetEtatVideo(new VideoEnFin());
//            video.Action();

//            video.SetEtatVideo(new VideoEnArrret());
//            video.Action();

//            video.SetEtatVideo(new VideoAvanceRapide());
//            video.Action();

//            video.SetEtatVideo(new VideoReculeRapide());
//            video.Action();


//            Console.Read();
//        }
//    }

//    public interface IEtatVideo
//    {
//        void Action(Video video);
//    }

//    public class Video
//    {

//        private IEtatVideo EtatVideo;

//        public void SetEtatVideo(IEtatVideo etat)
//        {
//            this.EtatVideo = etat;
//        }

//        public string GetEtatVideo()
//        {
//            à implémenter
//            return "Erreur ! Aucun état connu !";
//        }

//        public void Action()
//        {
//            EtatVideo.Action(this);
//        }
//    }

//    public class VideoEnLecture : IEtatVideo
//    {
//        public void Action(Video video)
//        {
//            Console.WriteLine("La vidéo est en lecture");
//        }
//    }

//    public class VideoEnPause : IEtatVideo
//    {
//        public void Action(Video video)
//        {
//            Console.WriteLine("La vidéo est en pause");
//        }
//    }

//    public class VideoEnDebut : IEtatVideo
//    {
//        public void Action(Video video)
//        {
//            Console.WriteLine("La vidéo recommence depuis le début");
//        }
//    }

//    public class VideoEnFin : IEtatVideo
//    {
//        public void Action(Video video)
//        {
//            Console.WriteLine("La vidéo arrive à la fin");
//        }
//    }


//    public class VideoEnArrret : IEtatVideo
//    {
//        public void Action(Video video)
//        {
//            Console.WriteLine("La vidéo est en arrêt");
//        }
//    }

//    public class VideoAvanceRapide : IEtatVideo
//    {
//        public void Action(Video video)
//        {
//            Console.WriteLine("La vidéo est en état d'avance rapide");
//        }
//    }

//    public class VideoReculeRapide : IEtatVideo
//    {
//        public void Action(Video video)
//        {
//            Console.WriteLine("La vidéo est en état de recule rapide");
//        }
//    }
//}
