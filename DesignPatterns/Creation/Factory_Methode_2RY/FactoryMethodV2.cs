using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creation.FactoryMethodV2
{
    //public class ProgramFactory
    //{
    //    public static void Main()
    //    {
    //        Computer pc = ComputerFactory.GetComputer(new PC("2 GB", "500 GB", "2.4 GHz"));
    //        Computer server = ComputerFactory.GetComputer(new Server("16 GB", "1 TB", "3.5 GHz"));
    //        Computer tablette = ComputerFactory.GetComputer(new Tablette("1 GB", "", "1.0 GHz"));

    //        Console.WriteLine("Factory - Configuration PC : " + pc);
    //        Console.WriteLine("Factory - Configuration Server : " + server);
    //        Console.WriteLine("Factory - Configuration Tablette : " + tablette);
    //        Console.Read();
    //    }
    //}

    public class ComputerFactory
    {
        public static Computer GetComputer(Computer computer)
        {
            return computer;
        }
    }

    public class Computer
    {
        public string typeComputer;
        public string Ram;
        public string Hdd;
        public string Cpu;

        public Computer(string ram, string hdd, string cpu)
        {
            this.Ram = ram;
            this.Hdd = hdd;
            this.Cpu = cpu;
        }

        public override string ToString()
        {
            return "Type Computer = " + typeComputer + ", RAM = " + Ram + ", HDD = " + Hdd + ", CPU = " + Cpu;
        }
    }

    public class PC : Computer
    {
        public PC(string ram, string hdd, string cpu) : base(ram, hdd, cpu)
        {
            base.typeComputer = "PC";
        }
    }

    public class Server : Computer
    {
        public Server(string ram, string hdd, string cpu) : base(ram, hdd, cpu)
        {
            base.typeComputer = "Server";
        }
    }

    public class Tablette : Computer
    {
        public Tablette(string ram, string hdd, string cpu) : base(ram, hdd, cpu)
        {
            base.typeComputer = "Tablette";
        }
    }

}
