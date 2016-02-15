using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApplication2
{
    public class DeletesFile:CommandExcute
    {
        public override void ErrorMessage(string error)
        {
            //throw new NotImplementedException();
            Console.WriteLine("Can not Delete file for you. The error messages are as follows:");
            Console.WriteLine(error);
        }

        private void DeleteFiles(string path)
        {

            string source = path.Substring(0, path.LastIndexOf('\\') + 1);
            string files = path.Substring(path.LastIndexOf('\\') + 1, path.Length - path.LastIndexOf('\\') - 1);
            DirectoryInfo di = new DirectoryInfo(source);
            foreach (var item in di.GetFiles(files))
            {
                item.Delete();
            }
        }
        public override void Excute(string input)
        {
            //throw new NotImplementedException();
            try
            {
                              
                this.DeleteFiles(input.Split(' ')[1]);
            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
            }
        }
    }
}
