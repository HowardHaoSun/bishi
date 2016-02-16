
namespace ConsoleApplication2
{
    public class DirFactory : Factory
    {
        public override CommandExcute CreateFactory()
        {
            //throw new System.NotImplementedException();
            return new Dir();
        }
    }
}
