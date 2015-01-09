using System;
using System.Collections.Generic;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main()
        {
            Display(new List<bool>{true, false, true});
            Console.ReadKey();
        }

        static void Display(IEnumerable<bool> argument)
        {
            foreach (var a in argument)
            {
                Console.WriteLine(a);
            }
        }
        static void Display1(List<bool> argument)
        {
            foreach (var a in argument)
            {
                Console.WriteLine(a);
            }
        }

    }
}
