using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creation.Factory_Methode
{
    //class JeuxVideoFActory
    //{
    //    static void Main(string[] args)
    //    { 
            
    //    }
    //}

    public class EnemyShipFactory
    {

    }

    public abstract class EnemyShip
    {
        private string Name { get; set; }
        private double AmtDamage { get; set; }

        public void FollowHeroShip()
        {
            Console.WriteLine(GetName() + "is the flowwing Hero");
        }
        public void DisplayHeroShip()
        {
            Console.WriteLine(GetDamage() + "is one in the Screen");
        }


        public void EnemyShipShoots()
        {
            Console.WriteLine(GetDamage() + "attaks and does" + GetDamage());
        }

        public double GetDamage()
        {
            return this.AmtDamage;
        }

        public void SetDamage(double damage)
        {

        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
           
        }


    }

    public class UFOEnemyShip: EnemyShip
    {
 
        public new string GetName()
        {
            return this.GetName();
        }
        public new void SetName( string name)
        {
           
        }
    }

    public class RocketEnemyShip : EnemyShip
    {

        public new string GetName()
        {
            return this.GetName();
        }
        public new void SetName(string name)
        {

        }
    }
}
