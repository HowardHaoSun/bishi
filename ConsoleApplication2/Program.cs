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
            Factory factory;
            CommandExcute ce;
            if(input.ToLower().StartsWith("cd"))
            {
                factory = new CDFactory();
                ce = factory.CreateFactory();
                ce.Excute(input);
            }
            else
            {
                string command = input.ToLower().Split(' ')[0];
                switch (command)
                {
                    case "copy":
                        factory = new CopyFactory();
                        ce = factory.CreateFactory();
                        ce.Excute(input);
                        break;
                    case "dir":
                        factory = new DirFactory();
                        ce = factory.CreateFactory();
                        ce.Excute(input);
                        break;
                    case "md":
                        factory = new MakeDirectoryFactory();
                        ce = factory.CreateFactory();
                        ce.Excute(input);
                        break;
                    case "rd":
                        factory = new RemoveDirectoryFactory();
                        ce = factory.CreateFactory();
                        ce.Excute(input);
                        break;
                    case "move":
                        factory = new MoveFactory();
                        ce = factory.CreateFactory();
                        ce.Excute(input);                        
                        break;
                    case "del":
                        factory = new DeletesFileFactory();
                        ce = factory.CreateFactory();
                        ce.Excute(input);
                        break;
                    case "rename":
                        factory = new RenameFileFactory();
                        ce = factory.CreateFactory();
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
