
namespace ConsoleApplication2
{
    public class CDFactory:Factory
    {
        public override CommandExcute CreateFactory()
        {
            //throw new System.NotImplementedException();
            return new ChangeDirectory();
        }
    }
}
