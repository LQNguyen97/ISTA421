using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12_linh
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numCorrect = 0;
            int numQuestion = 0;            

            Console.WriteLine("Welcome to Math Games");
            Console.Write("What math problem do you want to solve? Chose from: \n1 for addition \n2 for subtraction, \n3 for multiplication, \n4 for division: ");
            int choice = int.Parse(Console.ReadLine());
            Console.Write("how many problems do you want to solve? ");
            int numProbs = int.Parse(Console.ReadLine());
            Console.WriteLine();

            while (choice == 1 && numQuestion != numProbs)
            {

                var randm = new Random();
                int N1 = randm.Next(1, 100);
                int N2 = randm.Next(1, 100);

                Console.WriteLine($"{N1} + {N2} = ");
                int answer = int.Parse(Console.ReadLine());

                if (answer == N1 + N2)
                {
                    Console.WriteLine("Correct");
                    numCorrect++;
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }    
                
                    numQuestion++;                   
            }

            while (choice == 2 && numQuestion != numProbs)
            {

                var randm = new Random();
                int N1 = randm.Next(1, 100);
                int N2 = randm.Next(1, 100);

                Console.WriteLine($"{N1} - {N2} = ");
                int answer = int.Parse(Console.ReadLine());

                if (answer == N1 - N2)
                {
                    Console.WriteLine("Correct!");
                    numCorrect++;
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }
                numQuestion++;
            }

            while (choice == 3 && numQuestion != numProbs)
            {

                var randm = new Random();
                int N1 = randm.Next(1, 100);
                int N2 = randm.Next(1, 100);

                Console.WriteLine($"{N1} * {N2} = ");
                int answer = int.Parse(Console.ReadLine());

                if (answer == N1 * N2)
                {
                    Console.WriteLine("Correct!");
                    numCorrect++;
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }
                numQuestion++;
            }

            while (choice == 4 && numQuestion != numProbs)
            {

                var randm = new Random();
                double N1 = randm.Next(1, 100);
                double N2 = randm.Next(1, 100);

                Console.WriteLine($"{N1} / {N2} = ");
                double answer = int.Parse(Console.ReadLine());

                if (Math.Abs(answer - (N1 / N2)) < .009)
                {
                    Console.WriteLine("Correct!");
                    numCorrect++;
                }
                else 
                {
                    Console.WriteLine("Incorrect!");
                }
                numQuestion++;
            }
            while (choice >= 5)
            {
                Console.WriteLine("Wrong Input!");
            }
            while (choice <= 0)
            {
                Environment.Exit(0);
            }

            var score = ((double)numCorrect / numProbs) * 100;
            score = (int)score;

            if (numCorrect <= 0)
                score = 0;
            else
                score = score;
            Console.WriteLine($"Your score is {score}%");

        }
    }
}
