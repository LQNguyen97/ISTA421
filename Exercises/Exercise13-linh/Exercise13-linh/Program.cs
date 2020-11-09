using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using Microsoft.VisualBasic.FileIO;

namespace Exercise13_linh
{
    class Program
    {
            static void Main(string[] args)
            {
                var Questions = buildDB();
                var numbers = pickQuestions(Questions.Count);
                test(Questions, numbers);
            }

            private static void test(Dictionary<int, TestQuestions> Questions, List<int> numbers)
            {
                double score = 0, numProbs = numbers.Count();
                do
                {
                    int n = numbers.First();
                    Console.WriteLine(Questions[n]);
                    Console.Write("Answer: ");
                    var answer = Console.ReadLine();
                    if (answer.ToLower() == Questions[n].Answer.ToLower())
                    {
                        Console.WriteLine("You are correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("sorry, that is not correct");
                        Console.WriteLine($"The Correct answer is {Questions[n].Answer}");
                    }
                    numbers.Remove(n);
                }
                while (numbers != null && numbers.Any());
                score = (score / numProbs) * 100;
                Console.WriteLine($"Your score is: {(int)score}%");
            }

            public static Dictionary<int, TestQuestions> buildDB()
            {
                var Questions = new Dictionary<int, TestQuestions>();
                using (TextFieldParser reader = new TextFieldParser(@"C:\Users\nguye\quantico06\ISTA421\Exercises\Exercise13-linh\Exercise13-linh\Questions.txt"))
                {
                    reader.CommentTokens = new string[] { "#" };
                    reader.SetDelimiters(new string[] { "," });
                    reader.HasFieldsEnclosedInQuotes = true;
                    int i = 1;
                    while (!reader.EndOfData)
                    {
                        string[] fields = reader.ReadFields();
                        string Question = fields[0];
                        string Answer = fields[1];
                        string[] falseAs = { fields[2], fields[3], fields[4] };
                        Questions.Add(i, new TestQuestions(Question, Answer, falseAs));
                        i++;
                    }
                }
                return Questions;
            }
            public static List<int> pickQuestions(int DbSize)
            {
                var rando = new Random();
                List<int> possible = Enumerable.Range(1, DbSize).ToList();
                var numbers = new List<int>();
                Console.Write($"How Many Questions do you want(1 - {DbSize})? ");
                int numQuestions = int.Parse(Console.ReadLine());
                for (int i = 0; i < numQuestions; i++)
                {
                    int index = rando.Next(0, possible.Count);
                    numbers.Add(possible[index]);
                    possible.RemoveAt(index);
                }
                return numbers;
            }
        }
    }
    public static class Lists
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            var rando = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rando.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
       
    }
class TestQuestions
{
    public string Question { get; set; }
    public string Answer { get; set; }
    public string[] FalseAs { get; set; }
    public TestQuestions(string Q, string A, string[] FalseAs)
    {
        this.Question = Q;
        this.Answer = A;
        this.FalseAs = FalseAs;
    }
    public override string ToString()
    {
        var strB = new StringBuilder($"{Question}\n");
        var Answers = new List<string>();
        Answers.Add(Answer);
        foreach (string s in FalseAs)
        Answers.Add(s);
        Answers.Shuffle();
        foreach (string s in Answers)
        {
            strB.Append($" - {s}\n");
        }
        return strB.ToString();
    }
}

