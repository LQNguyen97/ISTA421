using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Quiz09_Linh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is C Sharp quiz 9");
            Console.WriteLine("Here is the stack");
            Stack<string> numbers = new Stack<string>();
            numbers.Push("\nOne");
            numbers.Push("\nTwo");
            numbers.Push("Three");
            PrintValues(numbers);

            Console.WriteLine("Here is my Queue!!");
            Queue<string> QueueNumber = new Queue<string>();
            QueueNumber.Enqueue("One");
            QueueNumber.Enqueue("\nTwo");
            QueueNumber.Enqueue("\nThree");
            PrintValues(QueueNumber);

            Console.WriteLine("Here is my Dictionary!!");
            Dictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");
            foreach (KeyValuePair<int, string> number in numberNames)

                Console.WriteLine("{0}, {1}", number.Value, number.Key);

        }

        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
            Console.Write("{0}", obj);
            Console.WriteLine();
        }
    }
}
