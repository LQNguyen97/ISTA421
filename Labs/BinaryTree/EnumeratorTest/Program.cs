using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree;

namespace EnumeratorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree1 = new Tree<int>(10);
            tree1.Insert(5);
            tree1.Insert(11);
            tree1.Insert(5);
            tree1.Insert(-12);
            tree1.Insert(15);
            tree1.Insert(0);
            tree1.Insert(14);
            tree1.Insert(-8);
            tree1.Insert(10);

            foreach (int item in tree1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("====================================================");

            Tree<char> tree2 = new Tree<char>('W');
            tree2.Insert('i');
            tree2.Insert('l');
            tree2.Insert('l');
            tree2.Insert('i');
            tree2.Insert('a');
            tree2.Insert('m');
            tree2.Insert('!');

            foreach (char item in tree2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("====================================================");

            foreach (char item in tree2)
            {
                Console.WriteLine((int)item);
            }
            
            Console.WriteLine("====================================================");

            Tree<char> tree3 = new Tree<char>('A');
            tree3.Insert('B');
            tree3.Insert('C');
            tree3.Insert('D');
            tree3.Insert('E');
            tree3.Insert('F');
            tree3.Insert('G');
            tree3.Insert('H');

            foreach (var item in tree3)
            {
                Console.WriteLine((int)item);
            }
        }
    }
}
