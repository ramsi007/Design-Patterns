//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace DesignPatterns.Creation.AbstractFactory
//{
//    public class Program
//    {
//        public static void Main()
//        {
//            PCFactory pcFactory = new PCFactory("2GB", "500GB", "2.4Ghz");
//            Computer pc = ComputerFactory.GetComputer(pcFactory);

//            ServerFactory serverFactory = new ServerFactory("4GB", "1TB", "5.4Ghz");
//            Computer server = ComputerFactory.GetComputer(serverFactory);

//            TabletteFactory tabletteFactory = new TabletteFactory("1GB", "1.0Ghz");
//            Computer tablette = ComputerFactory.GetComputer(tabletteFactory);

//            Console.WriteLine("PC : " + pc);
//            Console.WriteLine("Server : " + server);
//            Console.WriteLine("tablette : " + tablette);
//            Console.ReadLine();

//        }
//    }

//    public abstract class Computer
//    {
//        public string Ram;
//        public string Hdd;
//        public string Cpu;

//        public Computer(string ram, string hdd, string cpu)
//        {
//            this.Ram = ram;
//            this.Hdd = hdd;
//            this.Cpu = cpu;
//        }

//        public override string ToString()
//        {
//            return "RAM = " + Ram + ", HDD = " + Hdd + ", CPU = " + Cpu;
//        }
//    }

//    public class PC : Computer
//    {
//        public PC(string ram, string hdd, string cpu) : base(ram, hdd, cpu)
//        {
//        }
//    }

//    public class Server : Computer
//    {
//        public Server(string ram, string hdd, string cpu) : base(ram, hdd, cpu)
//        {
//        }
//    }

//    public class Tablette : Computer
//    {
//        public Tablette(string ram, string hdd, string cpu) : base(ram, hdd, cpu)
//        {
//        }
//    }

//    public interface IComputerAbstractFactory
//    {
//        Computer createComputer();
//    }

//    public class PCFactory : IComputerAbstractFactory
//    {
//        public string Ram;
//        public string Hdd;
//        public string Cpu;

//        public PCFactory(string ram, string hdd, string cpu)
//        {
//            this.Ram = ram;
//            this.Hdd = hdd;
//            this.Cpu = cpu;
//        }

//        public Computer createComputer()
//        {
//            return new PC(Ram, Hdd, Cpu);
//        }
//    }

//    public class ServerFactory : IComputerAbstractFactory
//    {
//        public string Ram;
//        public string Hdd;
//        public string Cpu;

//        public ServerFactory(string ram, string hdd, string cpu)
//        {
//            this.Ram = ram;
//            this.Hdd = hdd;
//            this.Cpu = cpu;
//        }

//        public Computer createComputer()
//        {
//            return new Server(Ram, Hdd, Cpu);
//        }
//    }

//    public class TabletteFactory : IComputerAbstractFactory
//    {
//        public string Ram;
//        public string Cpu;

//        public TabletteFactory(string ram, string cpu)
//        {
//            this.Ram = ram;
//            this.Cpu = cpu;
//        }

//        public Computer createComputer()
//        {
//            return new Tablette(Ram, "", Cpu);
//        }
//    }

//    public class ComputerFactory
//    {
//        public static Computer GetComputer(IComputerAbstractFactory factory)
//        {
//            return factory.createComputer();
//        }
//    }
//}
