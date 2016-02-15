
namespace ConsoleApplication2
{
    public class CopyFactory:Factory
    {
        public override CommandExcute CreateFacory()
        {
            //throw new System.NotImplementedException();
            return new Copy();
        }
    }
}
