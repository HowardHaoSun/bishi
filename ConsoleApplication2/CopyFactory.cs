
namespace ConsoleApplication2
{
    public class CopyFactory:Factory
    {
        public override CommandExcute CreateFactory()
        {
            //throw new System.NotImplementedException();
            return new Copy();
        }
    }
}
