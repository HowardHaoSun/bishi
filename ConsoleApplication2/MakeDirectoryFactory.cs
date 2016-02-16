
namespace ConsoleApplication2
{
    public class MakeDirectoryFactory : Factory
    {
        /// <summary>
        /// create MD command
        /// </summary>
        /// <returns></returns>
        public override CommandExcute CreateFactory()
        {
            //throw new System.NotImplementedException();
            return new MakeDirectory();
        }
    }
}
