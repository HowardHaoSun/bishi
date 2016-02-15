using System;
using System.IO;
namespace ConsoleApplication2
{
    public class Dir : AbstractFactory
    {
        
        public override void ErrorMessage(string error)
        {
            //throw new NotImplementedException();
            Console.WriteLine("Cannot make Dir for you. The error messages are as follows:");
            Console.WriteLine(error);
        }
       
        private string GetCurrentDirectory()
        {
            return Directory.GetCurrentDirectory();
        }
        private void GetSubDiretories(string path, string pattern)
        {

            foreach (var item in Directory.GetDirectories(path, pattern))
            {
                Console.WriteLine(item);
            }
        }
        private void GetFiles(string path, string pattern)
        {
            foreach(var item in Directory.GetFiles(path,pattern))
            {
                Console.WriteLine(item);
            }
        }
        public override void Excute(string input)
        {
            //throw new NotImplementedException();
            try
            {
                string[] command = input.Split(' ');
                DirectoryInfo di = new DirectoryInfo(GetCurrentDirectory());               
                this.GetSubDiretories(di.FullName, command[1]);
                this.GetFiles(di.FullName, command[1]);               

            }
            catch(Exception ex)
            {
                ErrorMessage(ex.Message);
            }

        }
    }
}
