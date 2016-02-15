using System;
using System.IO;
namespace ConsoleApplication2
{
    public class ChangeDirectory : AbstractFactory
    {
        public override void ErrorMessage(string error)
        {
            //throw new NotImplementedException();
            Console.WriteLine("Can not Change Directory for you. The error messages are as follows:");
            Console.WriteLine(error);
        }

        private string GetCurrentDirectory()
        {
            return Directory.GetCurrentDirectory();
        }
        private void SetCurDirectory(string input)
        {
            Directory.SetCurrentDirectory(input);            
        }
        public override void Excute(string input)
        {
            try{                
                string[] command = input.Split(' ');
                DirectoryInfo di = new DirectoryInfo(GetCurrentDirectory());
                if (command.Length == 1 && command[0].EndsWith(".."))
                {
                    SetCurDirectory(di.Parent.FullName);       
                }
                else if (command.Length == 2)
                {
                    SetCurDirectory(di.FullName + "\\" + command[1]);                    
                }
                else
                {
                    SetCurDirectory(command[0].Substring(3, command[0].Length - 3));                    
                }
            }
            catch(Exception ex)
            {
                ErrorMessage(ex.Message);
            }
        }
    }
}
