//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace DesignPatterns.Comportement
//{
//    public class StateWithoutDesignPattern
//    {
//        public static void Main()
//        {
//            Video video = new Video();

//            video.SetEtat(EtatVideo.PLAY.ToString());
//            video.Action();

//            video.SetEtat(EtatVideo.PAUSE.ToString());
//            video.Action();

//            video.SetEtat(EtatVideo.DEBUT.ToString());
//            video.Action();

//            video.SetEtat(EtatVideo.FIN.ToString());
//            video.Action();

//            Console.Read();
//        }
//    }

//    public class Video
//    {
//        private string Etat = "";

//        public void SetEtat(string etat)
//        {
//            this.Etat = etat;
//        }

//        public void Action()
//        {
//            switch (Enum.Parse(typeof(EtatVideo), Etat))
//            {

//                case EtatVideo.PLAY:
//                    Console.WriteLine("La vidéo est en lecture");
//                    break;

//                case EtatVideo.PAUSE:
//                    Console.WriteLine("La vidéo est en pause");
//                    break;

//                case EtatVideo.DEBUT:
//                    Console.WriteLine("La vidéo recommence depuis le début");
//                    break;

//                case EtatVideo.FIN:
//                    Console.WriteLine("La vidéo s'arrête");
//                    break;

//                default:
//                    Console.WriteLine("Erreur !! Cet état de vidéo n'est pas géré !");
//                    break;

//            }
//        }
//    }

//    public enum EtatVideo
//    {
//        PLAY,
//        PAUSE,
//        DEBUT,
//        FIN
//    }

//}
