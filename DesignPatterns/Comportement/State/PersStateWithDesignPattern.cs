using System;

namespace DesignPatterns.Comportement.WithDP
{
    public class StateWithDesignPattern
    {
        //public static void Main()
        //{
        //    Video video = new Video();

        //    video.SetEtatVideo(new VideoEnDebut());
        //    video.Action();
        //    Console.WriteLine("  => Etat actuel de la video : " + video.GetEtatVideo());

        //    video.SetEtatVideo(new VideoEnLecture());
        //    video.Action();
        //    Console.WriteLine("  => Etat actuel de la video : " + video.GetEtatVideo());

        //    video.SetEtatVideo(new VideoEnPause());
        //    video.Action();

        //    video.SetEtatVideo(new VideoEnLecture());
        //    video.Action();

        //    video.SetEtatVideo(new VideoEnAvance());
        //    video.Action();

        //    video.SetEtatVideo(new VideoEnArriere());
        //    video.Action();

        //    video.SetEtatVideo(new VideoEnArret());
        //    video.Action();

        //    Console.Read();
        //}
    }

    public interface IEtatVideo
    {
        void Action(Video video);
    }

    public class Video
    {
        private string currentState; // Etat actuel de la vidéo (exp : en arrêt, en pause, en stop, en fin, en début, ...)
        private IEtatVideo EtatVideo;

        public void SetEtatVideo(IEtatVideo etat)
        {
            this.EtatVideo = etat;

            if (etat.GetType().Name == typeof(VideoEnDebut).Name)  // GetType() s'applique sur une variable pobjet
                currentState = "en début";                         // alors que typeof s'appliuqe sur une classe

            if (etat.GetType().Name == typeof(VideoEnLecture).Name)
                currentState = "en lecture";

            if (etat.GetType().Name == typeof(VideoEnPause).Name)
                currentState = "en pause";

            if (etat.GetType().Name == typeof(VideoEnAvance).Name)
                currentState = "en pause";

            if (etat.GetType().Name == typeof(VideoEnArriere).Name)
                currentState = "en pause";

            if (etat.GetType().Name == typeof(VideoEnArret).Name)
                currentState = "en pause";

        }

        public string GetEtatVideo()
        {
            return this.currentState;
        }

        public void Action()
        {
            EtatVideo.Action(this);
        }
    }

    public class VideoEnLecture : IEtatVideo
    {
        public void Action(Video video)
        {
            Console.WriteLine("La vidéo est en lecture");
        }
    }

    public class VideoEnPause : IEtatVideo
    {
        public void Action(Video video)
        {
            Console.WriteLine("La vidéo est en pause");
        }
    }

    public class VideoEnDebut : IEtatVideo
    {
        public void Action(Video video)
        {
            Console.WriteLine("La vidéo recommence depuis le début");
        }
    }

    public class VideoEnFin : IEtatVideo
    {
        public void Action(Video video)
        {
            Console.WriteLine("La vidéo arrive à la fin");
        }
    }

    public class VideoEnArret : IEtatVideo
    {
        public void Action(Video video)
        {
            Console.WriteLine("La vidéo est arrêtée");
        }
    }

    public class VideoEnAvance : IEtatVideo
    {
        public void Action(Video video)
        {
            Console.WriteLine("La vidéo est en avance rapide");
        }
    }

    public class VideoEnArriere : IEtatVideo
    {
        public void Action(Video video)
        {
            Console.WriteLine("La vidéo est en arrière rapide");
        }
    }

}
