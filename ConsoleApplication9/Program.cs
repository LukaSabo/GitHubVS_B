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
        static void Display2()
        {
            var argument = new List<bool> {true, false, true};
            foreach (var a in argument)
            {
                Console.WriteLine(a);
            }
        }
        static void Display3()
        {
            var argument = new List<bool> { true, false, true };
            foreach (var a in argument)
            {
                Console.WriteLine(a);
            }
        }
    }
}
