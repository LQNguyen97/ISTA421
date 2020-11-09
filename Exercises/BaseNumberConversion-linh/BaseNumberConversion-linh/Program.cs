using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseNumberConversion_linh
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.DoWork();
        }

        private static void DoWork()
        {
            Console.WriteLine("Please enter the base to convert from [ 2 | 8 | 10 | 16 ]: ");
            int input = int.Parse(Console.ReadLine());

            if (input == 2)
            {
                string input2 = input.ToString();
                BinConvert(input2);
            }
            else if (input == 8)
            {
                string input3 = input.ToString();
                OctConvert(input3);
            }
            else if (input == 10)
            {
                string input4 = input.ToString();
                DecConvert(input4);
            }
            else if (input == 16)
            {
                string input5 = input.ToString();
                HexConvert(input5);
            }
            else if (input != 2 && input != 8 && input != 10 && input != 16)
            {
                Console.WriteLine("Please enter the correct Input!");
                Program.DoWork();
            }
        }

        public static void DecConvert(string message)
        {
            Console.WriteLine("Enter a Decimal number: ");
            string number1 = Console.ReadLine();
            int convertnumber = Convert.ToInt32(number1, 10);
            Console.WriteLine("The binary version of this number is: ");
            Console.WriteLine(Convert.ToString(convertnumber, 2));
            Console.WriteLine("The octal version of this number is: ");
            Console.WriteLine(Convert.ToString(convertnumber, 8));
            Console.WriteLine("The hexadecimal version of this number is: ");
            Console.WriteLine(Convert.ToString(convertnumber, 16));
        }

        public static void OctConvert(string message)
        {

            Console.WriteLine("Enter an Octal number: ");
            string number1 = Console.ReadLine();
            int convertnumber = Convert.ToInt32(number1, 8);
            Console.WriteLine("The binary version of this number is: ");
            Console.WriteLine(Convert.ToString(convertnumber, 2));
            Console.WriteLine("The decimal version of this number is: ");
            Console.WriteLine(Convert.ToString(convertnumber, 10));
            Console.WriteLine("The hexadecimal version of this number is: ");
            Console.WriteLine(Convert.ToString(convertnumber, 16));
        }

        public static void BinConvert(string message)
        {
            Console.WriteLine("Enter a Binary number: ");
            string number1 = Console.ReadLine();
            int convertnumber = Convert.ToInt32(number1, 2);
            Console.WriteLine("The octal version of this number is: ");
            Console.WriteLine(Convert.ToString(convertnumber, 8));
            Console.WriteLine("The decimal version of this number is: ");
            Console.WriteLine(Convert.ToString(convertnumber, 10));
            Console.WriteLine("The hexadecimal version of this number is: ");
            Console.WriteLine(Convert.ToString(convertnumber, 16));
        }

        public static void HexConvert(string message)
        {
            Console.WriteLine("Enter a Hexadecimal number: ");
            string number1 = Console.ReadLine();
            int convertnumber = Convert.ToInt32(number1, 16);
            Console.WriteLine("The binary version of this number is: ");
            Console.WriteLine(Convert.ToString(convertnumber, 2));
            Console.WriteLine("The octal version of this number is: ");
            Console.WriteLine(Convert.ToString(convertnumber, 8));
            Console.WriteLine("The decimal version of this number is: ");
            Console.WriteLine(Convert.ToString(convertnumber, 10));
        }
    }
}
