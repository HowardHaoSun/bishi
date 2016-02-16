
namespace ConsoleApplication2
{
    public class MoveFactory : Factory
    {
        /// <summary>
        /// create Move command
        /// </summary>
        /// <returns></returns>
        public override CommandExcute CreateFactory()
        {
            //throw new System.NotImplementedException();
            return new Move();
        }
    }
}
