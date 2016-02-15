
namespace ConsoleApplication2
{
    public class MoveFactory : Factory
    {
        public override CommandExcute CreateFacory()
        {
            //throw new System.NotImplementedException();
            return new Move();
        }
    }
}
