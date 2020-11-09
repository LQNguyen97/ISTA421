using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_20
{
    delegate void Gun();
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate Quiz!");
            Console.WriteLine("=================================================");
            Gun weapons = new Gun(Rifle.rifle);
            weapons += Pistol.pistol;
            weapons += Shotgun.shotgun;
            weapons();
        }
    }

    class Rifle
    {
        public static void rifle()
        {
            Console.WriteLine("I am Rifle and I go BANG.");
            Console.WriteLine("=================================================");
        }
    }

    class Pistol
    {
        public static void pistol()
        {
            Console.WriteLine("I am Pistol and I go POP.");
            Console.WriteLine("=================================================");

        }
    }

    class Shotgun
    {
        public static void shotgun()
        {
            Console.WriteLine("I am Shotgun and I go BOOM.");
            Console.WriteLine("=================================================");

        }
    }
}