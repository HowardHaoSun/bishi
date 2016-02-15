using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ChangeDictionary cd = new ChangeDictionary();
            //cd.Excute();
            string input = Console.ReadLine();
            Dir dir = new Dir();
            dir.Excute(input);
            Console.ReadLine();
        }
    }
}
