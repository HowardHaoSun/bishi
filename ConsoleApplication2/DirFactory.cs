
namespace ConsoleApplication2
{
    public class DirFactory : Factory
    {
        public override CommandExcute CreateFacory()
        {
            //throw new System.NotImplementedException();
            return new Dir();
        }
    }
}
