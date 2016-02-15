using System;
using System.IO;
namespace ConsoleApplication2
{
    public class Move : CommandExcute
    {        
        private void CreateDirectory(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            if(!di.Exists)
            {
                di.Create();
            }
        }
        private void MoveFiles(string from, string to)
        {
            this.CreateDirectory(to);
            //Directory.GetFiles(from)
            string source = from.Substring(0,from.LastIndexOf('\\')+1);
            string files = from.Substring(from.LastIndexOf('\\') + 1, from.Length - from.LastIndexOf('\\')-1);
            DirectoryInfo di = new DirectoryInfo(source);            
            foreach(var item in di.GetFiles(files))
            {                
                item.MoveTo(to + "\\" + item.Name);
            }
        }
        public override void Excute(string input)
        {
            //throw new NotImplementedException();
            try
            {
                string[] command = input.Split(' ');
                string source = command[1];
                string destination = command[2];
                //string file = command[2];
                this.MoveFiles(source, destination);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
