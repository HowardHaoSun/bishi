using System;
using System.IO;
namespace ConsoleApplication2
{
    public class ChangeDictionary: BasicIO
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
            try{                
                string[] command = input.Split(' ');
                DirectoryInfo di = new DirectoryInfo(GetCurrentDictionary());
                if (command.Length == 1 && command[0].EndsWith(".."))
                {
                    SetCurDirectory(di.Parent.FullName);       
                }
                else if (command.Length == 2)
                {
                    SetCurDirectory(di.Parent.FullName + "//" + command[1]);                    
                }
                else
                {
                    SetCurDirectory(command[0].Substring(2, command[0].Length - 2));                    
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
