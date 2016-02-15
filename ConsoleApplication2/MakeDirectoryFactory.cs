
namespace ConsoleApplication2
{
    public class MakeDirectoryFactory : Factory
    {
        public override CommandExcute CreateFacory()
        {
            //throw new System.NotImplementedException();
            return new MakeDirectory();
        }
    }
}
