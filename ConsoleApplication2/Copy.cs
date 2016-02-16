﻿using System;
using System.IO;
namespace ConsoleApplication2
{
    public class Copy : CommandExcute
    {
        
       /// <summary>
       /// if Copy file to a nonexistent folder, create the folder
       /// 
       /// </summary>
       /// <param name="path"></param>
        private void CreateDirectory(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            if(!di.Exists)
            {
                di.Create();
            }
        }
        /// <summary>
        /// Copy file(s)  from source folder to destination folder
        /// matches single responsibility Principle
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        private void CopyFiles(string from, string to)
        {
            this.CreateDirectory(to);
            //Directory.GetFiles(from)
            string source = from.Substring(0,from.LastIndexOf('\\')+1);
            string files = from.Substring(from.LastIndexOf('\\') + 1, from.Length - from.LastIndexOf('\\')-1);
            DirectoryInfo di = new DirectoryInfo(source);            
            foreach(var item in di.GetFiles(files))
            {                
                item.CopyTo(to + "\\" + item.Name,true);
            }
        }
        /// <summary>
        /// Execute Copy command
        /// </summary>
        /// <param name="input"></param>
        public override void Excute(string input)
        {
            //throw new NotImplementedException();
            try
            {
                string[] command = input.Split(' ');
                string source = command[1];
                string destination = command[2];
                //string file = command[2];
                this.CopyFiles(source, destination);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
