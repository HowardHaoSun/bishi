
namespace ConsoleApplication2
{
    public class DeletesFileFactory : Factory
    {
        public override CommandExcute CreateFacory()
        {
            //throw new System.NotImplementedException();
            return new DeletesFile();
        }
    }
}
