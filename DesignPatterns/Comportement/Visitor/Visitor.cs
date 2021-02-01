//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace DesignPatterns.Comportement.Visitor
//{
//    class Visitor
//    {
//        public static void Main()
//        {

//        }

//        public interface IElementVoiture
//        {
//            void Accept(IElementVoitureVisitor elementVoitureVisitot);
            

//        }

//        public interface IElementVoitureVisitor
//        {

//        }

//        public class Roue
//        {
//            private string Name { get; }


//            public Roue(string name)
//            {
//                this.Name = name;
//            }

//            public string getName()
//            {
//                return this.Name;
//            }

//            public void Accept(IElementVoitureVisitor elementVoitureVisitot)
//            {

//            }
//        }

//        public class Moteur
//        {
//            public void Accept(IElementVoitureVisitor elementVoitureVisitot)
//            {

//            }
//        }

//        public class Carosserie
//        {
//            public void Accept(IElementVoitureVisitor elementVoitureVisitot)
//            {

//            }
//        }

//        public class Voiture
//        {
//            public IElementVoiture[] Elements { get; }

//            public Voiture()
//            {

//            }

//            public void GetElements()
//            {

//            }
//        }
//    }
//}
