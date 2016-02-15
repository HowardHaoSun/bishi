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
            if(input.ToLower().StartsWith("cd"))
            {
                ChangeDirectory cd = new ChangeDirectory();
                cd.Excute(input);
            }
            else
            {
                string command = input.ToLower().Split(' ')[0];
                switch (command)
                {
                    case "copy":
                        Copy copy = new Copy();
                        copy.Excute(input);
                        break;
                    case "dir":
                        Dir dir = new Dir();
                        dir.Excute(input);
                        break;
                    case "md":
                        MakeDirectory md = new MakeDirectory();
                        md.Excute(input);
                        break;
                    case "rd":
                        RemoveDirectory rd = new RemoveDirectory();
                        rd.Excute(input);
                        break;
                    case "move":
                        Move move = new Move();
                        move.Excute(input);
                        break;
                    case "del":
                        DeletesFile del = new DeletesFile();
                        del.Excute(input);
                        break;
                    case "rename":
                        RenameFile rename = new RenameFile();
                        rename.Excute(input);
                        break;
                    default:

                        break;
                }
            }
            
            
            processor();
        }
    }
}
