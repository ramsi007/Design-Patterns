using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DesignPatterns.Creation.Factory_Methode
{
     
        public class ComputerFactory
    {
        public static Computer GetComputer(string type, string ram, string hdd, string cpu )
        {
            Pc pc = new Pc(ram, hdd, cpu);
            Server sr = new Server(ram, hdd,cpu);

            if (string.Equals(type, "pc"))
        
                return pc;
            else                
                return sr;


        }
    }
}
