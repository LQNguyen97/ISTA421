using System;

namespace DelLab01
{
    //1. declare a delegate type
    delegate void MyDel();
    delegate int Moe(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate Lab 1");
            //2. instantiate a delegate object
            //either of the two lines below, a or b
            var md = new MyDel(someMethod); //a
            //MyDel md = someMethod; //b
            md += Gloria;
            //3. call the delegate
            md();
            Moe m = Add;
            int n = m(13, 14);
            Console.WriteLine(n);
        }

        static void someMethod()
        {
            Console.WriteLine("This is the body of the method named \"someMethod()\"");
        }

        static void Gloria()
        {
            int a = 5;
            int b = 6;
            int c = a * b;
            Console.WriteLine($"The value of {a} * {b} is {c}");
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}