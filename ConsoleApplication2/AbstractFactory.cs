using System;

namespace ConsoleApplication2
{
    public abstract class AbstractFactory
    {
      
        public abstract void Excute(string input);
        public abstract void ErrorMessage(string error);
       // public abstract void SetCurDirectory(string input);
       
    }
}
