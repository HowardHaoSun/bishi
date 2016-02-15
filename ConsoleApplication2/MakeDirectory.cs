using System;
using System.IO;

namespace ConsoleApplication2
{
    public class MakeDirectory : CommandExcute
    {
              

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
                Console.WriteLine(ex.Message);
            }
        }
    }
}
