
namespace ConsoleApplication2
{
    public class RenameFileFactory : Factory
    {
        /// <summary>
        /// create rename command
        /// </summary>
        /// <returns></returns>
        public override CommandExcute CreateFactory()
        {
            //throw new System.NotImplementedException();
            return new RenameFile();
        }
    }
}
