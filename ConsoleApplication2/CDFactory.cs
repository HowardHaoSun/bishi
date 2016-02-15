
namespace ConsoleApplication2
{
    public class CDFactory:Factory
    {
        public override CommandExcute CreateFacory()
        {
            //throw new System.NotImplementedException();
            return new ChangeDirectory();
        }
    }
}
