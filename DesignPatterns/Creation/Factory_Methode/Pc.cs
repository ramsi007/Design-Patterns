using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creation.Factory_Methode
{
     public class Pc : Computer
    {
        private string Ram;
        private string Hdd;
        private string Cpu;


        public Pc(string ram, string hdd, string cpu)
        {
            this.Ram = ram;
            this.Hdd = hdd;
            this.Cpu = cpu;

        }

        
            public override String getRAM()
        {
            return this.Ram;
        }

        
            public override String getHDD()
        {
            return this.Hdd;
        }

        
            public override String getCPU()
        {
            return this.Cpu;
        }

    }
}
