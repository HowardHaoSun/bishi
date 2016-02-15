using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApplication2
{
    public class Dir:BasicIO
    {
        public override string Input()
        {
            return Console.ReadLine();
        }
        public override void Output(string input)
        {
            Console.WriteLine(input);
        }
        public override string GetCurrentDictionary()
        {
            return Directory.GetCurrentDirectory();
        }
        public override void SetCurDirectory(string input)
        {
            Directory.SetCurrentDirectory(input);
            Console.WriteLine(Directory.GetCurrentDirectory());
        }
        public override void Excute()
        {
            throw new NotImplementedException();
        }
    }
}
