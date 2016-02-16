
namespace ConsoleApplication2
{
    public class DeletesFileFactory : Factory
    {
        public override CommandExcute CreateFactory()
        {
            //throw new System.NotImplementedException();
            return new DeletesFile();
        }
    }
}
