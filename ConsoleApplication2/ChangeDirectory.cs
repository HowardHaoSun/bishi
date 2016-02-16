using System;
using System.IO;
namespace ConsoleApplication2
{
    public class ChangeDirectory : CommandExcute
    {  
        /// <summary>
        /// Execute CD command
        /// </summary>
        /// <param name="input"></param>

        public override void Excute(string input)
        {
            try{                
                string[] command = input.Split(' ');
                DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
                if (command.Length == 1 && command[0].EndsWith(".."))
                {
                    Directory.SetCurrentDirectory(di.Parent.FullName);       
                }
                else if (command.Length == 2)
                {
                    Directory.SetCurrentDirectory(di.FullName + "\\" + command[1]);                    
                }
                else
                {
                    Directory.SetCurrentDirectory(command[0].Substring(3, command[0].Length - 3));                    
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
