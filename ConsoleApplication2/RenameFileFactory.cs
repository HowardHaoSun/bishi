
namespace ConsoleApplication2
{
    public class RenameFileFactory : Factory
    {
        public override CommandExcute CreateFactory()
        {
            //throw new System.NotImplementedException();
            return new RenameFile();
        }
    }
}
