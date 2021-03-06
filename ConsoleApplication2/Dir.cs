﻿using System;
using System.IO;
namespace ConsoleApplication2
{
    public class Dir : CommandExcute
    {         
       /// <summary>
        /// Get sub directories in user assigned directory base on search pattern.
        /// matches single responsibility Principle
       /// </summary>
       /// <param name="path"></param>
       /// <param name="pattern"></param>
       
        private void GetSubDiretories(string path, string pattern)
        {
            foreach (var item in Directory.GetDirectories(path, pattern))
            {
                Console.WriteLine(item);
            }
        }
        /// <summary>
        /// Get file(s) in user assigned directory base on search pattern.
        /// matches single responsibility Principle
        /// </summary>
        /// <param name="path"></param>
        /// <param name="pattern"></param>
        private void GetFiles(string path, string pattern)
        {
            foreach(var item in Directory.GetFiles(path,pattern))
            {
                Console.WriteLine(item);
            }
        }
        /// <summary>
        /// Execute Dir command
        /// </summary>
        /// <param name="input"></param>
        public override void Excute(string input)
        {
            //throw new NotImplementedException();
            try
            {
                string[] command = input.Split(' ');
                DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());               
                this.GetSubDiretories(di.FullName, command[1]);
                this.GetFiles(di.FullName, command[1]);               

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
