
namespace ConsoleApplication2
{
    public class RemoveDirectoryFactory : Factory
    {
        public override CommandExcute CreateFacory()
        {
            //throw new System.NotImplementedException();
            return new RemoveDirectory();
        }
    }
}
