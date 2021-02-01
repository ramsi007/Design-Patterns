using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creation.FactoryMethodV3
{
    public class ProgramFactory
    {
        public static void Main()
        {
            Computer pc = ComputerFactory.GetComputer(new PC("2 GB", "500 GB", "2.4 GHz"));
            Computer server = ComputerFactory.GetComputer(new Server("16 GB", "1 TB", "3.5 GHz"));
            Computer tablette = ComputerFactory.GetComputer(new Tablette("1 GB", "", "1.0 GHz"));

            Console.WriteLine("Factory - Configuration PC : " + pc);
            Console.WriteLine("Factory - Configuration PC : " + pc.Infos());

            Console.WriteLine("Factory - Configuration Server : " + server);
            Console.WriteLine("Factory - Configuration PC : " + server.Infos());

            Console.WriteLine("Factory - Configuration Tablette : " + tablette);
            Console.WriteLine("Factory - Configuration PC : " + tablette.Infos());
            Console.Read();
        }
    }

    public class ComputerFactory
    {
        public static Computer GetComputer(Computer computer)
        {
            return computer;
        }
    }

    public abstract class Computer
    {
        public string typeComputer; // ajout de ce paramètre par rapport à la version précédente sans modifier le constructeur
        public string Ram;
        public string Hdd;
        public string Cpu;

        public Computer(string ram, string hdd, string cpu)
        {
            this.Ram = ram;
            this.Hdd = hdd;
            this.Cpu = cpu;
        }
        public abstract string Infos(); // ajout de cette méthode par rapport à la version précédente

        public override string ToString()
        {
            return "Type Computer = " + typeComputer + ", RAM = " + Ram + ", HDD = " + Hdd + ", CPU = " + Cpu;
        }
    }

    public class PC : Computer
    {
        public PC(string ram, string hdd, string cpu) : base(ram, hdd, cpu)
        {
            // new string typeComputer // c'ets dans le cas où on crée un paramètre qui porte le même nom que celui de la classe mère
            //this.typeComputer = "PC"; // this => correspond au paramètre de cette classe
            //base.typeComputer = "PC"; // base => correspond au paramètre de la classe mère

            typeComputer = "PC";
        }

        public override string Infos()
        {
            return "Je suis un " + base.typeComputer + " - " + this.typeComputer;
        }
    }

    public class Server : Computer
    {
        public Server(string ram, string hdd, string cpu) : base(ram, hdd, cpu)
        {
            typeComputer = "Server";
        }

        public override string Infos()
        {
            return "Je suis un " + typeComputer;
        }

    }

    public class Tablette : Computer
    {
        public Tablette(string ram, string hdd, string cpu) : base(ram, hdd, cpu)
        {
            typeComputer = "Tablette";
        }

        public override string Infos()
        {
            return "Je suis une " + typeComputer;
        }

    }


}
