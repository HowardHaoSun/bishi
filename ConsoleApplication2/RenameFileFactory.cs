
namespace ConsoleApplication2
{
    public class RenameFileFactory : Factory
    {
        public override CommandExcute CreateFacory()
        {
            //throw new System.NotImplementedException();
            return new RenameFile();
        }
    }
}
