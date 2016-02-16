
namespace ConsoleApplication2
{
    public class MoveFactory : Factory
    {
        public override CommandExcute CreateFactory()
        {
            //throw new System.NotImplementedException();
            return new Move();
        }
    }
}
