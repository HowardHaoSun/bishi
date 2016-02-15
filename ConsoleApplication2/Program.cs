using System;
using System.IO;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            processor();

        }

        static void processor()
        {
            Console.Write(Directory.GetCurrentDirectory()+">");
            string input = Console.ReadLine();
            CommandExcute ce;
            if(input.ToLower().StartsWith("cd"))
            {
                ce = new ChangeDirectory();
                ce.Excute(input);
            }
            else
            {
                string command = input.ToLower().Split(' ')[0];
                switch (command)
                {
                    case "copy":
                        ce = new Copy();
                        ce.Excute(input);
                        break;
                    case "dir":
                        ce = new Dir();
                        ce.Excute(input);
                        break;
                    case "md":
                        ce = new MakeDirectory();
                        ce.Excute(input);
                        break;
                    case "rd":
                        ce = new RemoveDirectory();
                        ce.Excute(input);
                        break;
                    case "move":
                        ce = new Move();
                        ce.Excute(input);
                        break;
                    case "del":
                        ce = new DeletesFile();
                        ce.Excute(input);
                        break;
                    case "rename":
                        ce = new RenameFile();
                        ce.Excute(input);
                        break;
                    default:

                        break;
                }
            }
            
            
            processor();
        }
    }
}
