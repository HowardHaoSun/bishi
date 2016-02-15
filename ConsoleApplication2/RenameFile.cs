﻿using System;
using System.IO;
namespace ConsoleApplication2
{
    public class RenameFile:CommandExcute
    {
        public override void ErrorMessage(string error)
        {
            //throw new NotImplementedException();
            Console.WriteLine("Can not Rename file for you. The error messages are as follows:");
            Console.WriteLine(error);
        }
        private void RenameFiles(string from, string to)
        {
            string source = "";
            if (from.Substring(0, from.LastIndexOf('\\') + 1) == "")
                source = Directory.GetCurrentDirectory();
            else
                source = from.Substring(0, from.LastIndexOf('\\') + 1);
            string files = from.Substring(from.LastIndexOf('\\') + 1, from.Length - from.LastIndexOf('\\') - 1);
            string newFile = to.Substring(to.LastIndexOf('\\') + 1, to.Length - to.LastIndexOf('\\') - 1);
            string[] newFileName = newFile.Split('.');
            DirectoryInfo di = new DirectoryInfo(source);
            if (newFileName[0] == "*")
            {
                foreach (var item in di.GetFiles(files))
                {
                    item.MoveTo(source + "\\" + item.Name.Split('.')[0] + "." + newFileName[1]);                    
                }
            }
            else
            {
                foreach (var item in di.GetFiles(files))
                {
                    item.MoveTo(source + "\\" + newFile);                    
                }
            }
        }
        private void Rename(string from, string to)
        {
           
            if(Directory.Exists(from))
            {
                DirectoryInfo di = new DirectoryInfo(from);
                di.MoveTo(to);
               
            }
            else
            {
                this.RenameFiles(from,to);
                
            }
            
            
        }
        public override void Excute(string input)
        {
            //throw new NotImplementedException();
            try
            {
                string[] command = input.Split(' ');
                string from = command[1];
                string to = command[2];
                //string file = command[2];
                this.Rename(from, to);
            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
            }
        }
    }
}
