using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creation.Factory_Methode
{
    public abstract class Computer
    {

        public abstract string getRAM();
        public abstract string getHDD();
        public abstract string getCPU();



        public override string ToString()
        {
            return "[ Les Caractéristique du Computer , RAM : " + this.getRAM() + " HDD :  " + this.getHDD() + " CPU :  " + this.getCPU() + " ]";
        }

    }
}
