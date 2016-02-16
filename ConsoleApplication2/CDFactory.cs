
namespace ConsoleApplication2
{
    public class CDFactory:Factory
    {
        /// <summary>
        /// create CD command
        /// </summary>
        /// <returns></returns>
        public override CommandExcute CreateFactory()
        {
            //throw new System.NotImplementedException();
            return new ChangeDirectory();
        }
    }
}
