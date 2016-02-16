
namespace ConsoleApplication2
{
    public class RemoveDirectoryFactory : Factory
    {
        public override CommandExcute CreateFactory()
        {
            //throw new System.NotImplementedException();
            return new RemoveDirectory();
        }
    }
}
