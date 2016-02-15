using System;
using System.IO;

namespace ConsoleApplication2
{
    public class RemoveDirectory:CommandExcute
    {
               
        public override void Excute(string input)
        {
            try
            {
                string path = input.Split(' ')[1];
                Directory.Delete(path, true);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //throw new NotImplementedException();
        }
    }
}
