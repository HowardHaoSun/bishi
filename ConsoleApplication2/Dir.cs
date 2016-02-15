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
        public override void Excute(string input)
        {
            //throw new NotImplementedException();
            try
            {
                string[] command = input.Split(' ');
                DirectoryInfo di = new DirectoryInfo(GetCurrentDictionary());
                DirectoryInfo[] directories = di.GetDirectories();
                FileInfo[] fis = di.GetFiles(command[1]);
                foreach(var item in directories)
                {
                    Output(item.Name);
                }
                foreach(var item in fis)
                {
                    Output(item.Name);
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
