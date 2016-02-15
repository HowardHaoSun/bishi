using System;
using System.IO;

namespace ConsoleApplication2
{
    public class MakeDirectory : CommandExcute
    {
        
        public override void ErrorMessage(string error)
        {
            //throw new NotImplementedException();
            Console.WriteLine("Cannot Make directory for you. The error messages are as follows:");
            Console.WriteLine(error);
        }

        public override void Excute(string input)
        {
            //throw new NotImplementedException();
            try
            {
                string[] command = input.Split(' ');
                Directory.CreateDirectory(command[1]);
            }
            catch(Exception ex)
            {
                ErrorMessage(ex.Message);
            }
        }
    }
}
