
namespace ConsoleApplication2
{
    public class RemoveDirectoryFactory : Factory
    {
        /// <summary>
        /// create RD command
        /// </summary>
        /// <returns></returns>
        public override CommandExcute CreateFactory()
        {
            //throw new System.NotImplementedException();
            return new RemoveDirectory();
        }
    }
}
