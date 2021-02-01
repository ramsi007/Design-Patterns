using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creation.FactoryMethod
{
    public class ProgramFactory
    {
        public static void Main()
        {
            Computer pc = ComputerFactory.GetComputer("PC", "2 GB", "500 GB", "2.4 GHz");
            Computer server = ComputerFactory.GetComputer("Server", "16 GB", "1 TB", "3.5 GHz");
            Console.WriteLine("Factory - Configuration PC : " + pc);
            Console.WriteLine("Factory - Configuration Server : " + server);
            Console.Read();
        }
    }

    public class ComputerFactory
    {
        public static Computer GetComputer(string type, string ram, string hdd, string cpu)
        {
            if (string.Equals(type, "PC", StringComparison.OrdinalIgnoreCase))
            {
                return new PC(ram, hdd, cpu);
            }
            if (string.Equals(type, "Server"))
            {
                return new Server(ram, hdd, cpu);
            }
            throw new ArgumentException("le type de computer '" + type + "' à créer n'est pas géré !");
        }
    }

    public abstract class Computer
    {
        public abstract string GetRAM();
        public abstract string GetHDD();
        public abstract string GetCPU();

        public override string ToString()
        {
            return "RAM = " + this.GetRAM() + ", HDD = " + this.GetHDD() + ", CPU = " + this.GetCPU();
        }
    }

    public class PC : Computer
    {
        private string Ram;
        private string Hdd;
        private string Cpu;

        public PC(string ram, string hdd, string cpu)
        {
            this.Ram = ram;
            this.Hdd = hdd;
            this.Cpu = cpu;
        }
        public override string GetRAM()
        {
            return this.Ram;
        }

        public override string GetHDD()
        {
            return this.Hdd;
        }

        public override string GetCPU()
        {
            return this.Cpu;
        }

    }

    public class Server : Computer
    {
        private string Ram;
        private string Hdd;
        private string Cpu;

        public Server(string ram, string hdd, string cpu)
        {
            this.Ram = ram;
            this.Hdd = hdd;
            this.Cpu = cpu;
        }

        public override string GetRAM()
        {
            return this.Ram;
        }

        public override string GetHDD()
        {
            return this.Hdd;
        }

        public override string GetCPU()
        {
            return this.Cpu;
        }
    }
}
