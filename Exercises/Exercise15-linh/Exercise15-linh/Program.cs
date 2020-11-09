using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15_linh
{
    class Program
    {
        static char[] Match =            {'0','1','2','3','4','5','6','7','8','9','a','b','c','d','e','f','g','h','i','j' ,'k','l','m','n','o','p',
                        'q','r','s','t','u','v','w','x','y','z','A','B','C','D','E','F','G','H','I','J','C','L','M','N','O','P',
                        'Q','R','S','T','U','V','X','Y','Z','!','?',' ','*','-','+'};

        static string FindPassword;
        static int Combi;       
        static int Characters;
        static void Main(string[] args)
        {
            int Count;
            Console.WriteLine("Welcome To Password Cracker!");
            Console.WriteLine("Enter your Password:");

            FindPassword = (Console.ReadLine());
            Characters = FindPassword.Length;
            Console.Clear();

            for (Count = 0; Count <= 15; Count++)
            {
                Recurse(Count, 0, "");
            }
        }

        static void Recurse(int Lenght, int Position, string BaseString)
        {
            int Count = 0;

            for (Count = 0; Count < Match.Length; Count++)
            {
                Combi++;
                if (Position < Lenght - 1)
                {
                    Recurse(Lenght, Position + 1, BaseString + Match[Count]);
                }
                if (BaseString + Match[Count] == FindPassword)
                {
                    Console.WriteLine();
                    Console.WriteLine("Your password is: " + FindPassword);
                    Console.WriteLine("Your password is: " + Characters + " character(s) long");
                    Console.WriteLine("To Exit Enter [0]: ");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
        }
    }
}
