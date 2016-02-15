using System;
using System.IO;

namespace ConsoleApplication2
{
    public class RemoveDirectory:CommandExcute
    {
        public override void ErrorMessage(string error)
        {
            //throw new NotImplementedException();
            Console.WriteLine("Can not Remove Directory for you. The error messages are as follows:");
            Console.WriteLine(error);
        }
        
        public override void Excute(string input)
        {
            try
            {
                string path = input.Split(' ')[1];
                Directory.Delete(path, true);
            }
            catch(Exception ex)
            {
                ErrorMessage(ex.Message);
            }
            //throw new NotImplementedException();
        }
    }
}
