using System;
using System.Globalization;
using System.Linq;

namespace LINQquizzes
{
    internal class Answer
    {
        internal void Quiz01(int[] intArray)
        {
            var E = from i in intArray
                    where i % 2 == 0
                    select i;
            foreach (var num in E)
            {
                Console.WriteLine(num);
            }
        }

        internal void Quiz02(int[] intArray)
        {
            var P = from i in intArray
                    where i >= 0
                    select i;
            foreach (var positiveNum in P)
                Console.WriteLine(positiveNum);

        }

        internal void Quiz03(int[] intArray)
        {
            var Square = from i in intArray
                         select i;
            foreach (int i in Square)
                Console.WriteLine($"The square of {i} is: {i * i}");
        }

        internal void Quiz04(int[] intArray)
        {
            var freq = from i in intArray
                       group i by i into j
                       select j;
            foreach(var k in freq)
                Console.WriteLine($"Number {k.Key} appears {k.Count()}");
        }

        internal void Quiz05(string s)
        {
            var word = from w in s
                       group w by w into m
                       select m;
            foreach(var k in word)
                Console.WriteLine($"Characters {k.Key} appears {k.Count()}");
        }

        internal void Quiz06(int[] intArray)
        {
            var answer = from i in intArray
                         group i by i into r
                         select r;
            foreach(var m in answer)
                Console.WriteLine($"Number {m.Key} appears {m.Count()} and the product is {m.Key * m.Count()}");
        }
    }
}