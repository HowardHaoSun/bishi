
namespace ConsoleApplication2
{
    public class MakeDirectoryFactory : Factory
    {
        public override CommandExcute CreateFactory()
        {
            //throw new System.NotImplementedException();
            return new MakeDirectory();
        }
    }
}
