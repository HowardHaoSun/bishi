
namespace ConsoleApplication2
{
    public class DirFactory : Factory
    {
        /// <summary>
        /// create Dir command
        /// </summary>
        /// <returns></returns>
        public override CommandExcute CreateFactory()
        {
            //throw new System.NotImplementedException();
            return new Dir();
        }
    }
}
