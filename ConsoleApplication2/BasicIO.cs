using System;

namespace ConsoleApplication2
{
    public abstract class BasicIO
    {
        public abstract string GetCurrentDictionary();

        public abstract void Output(string input);

        public abstract string Input();

        public abstract void Excute(string input);
        public abstract void SetCurDirectory(string input);
       
    }
}
