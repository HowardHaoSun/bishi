
namespace ConsoleApplication2
{
    public class DeletesFileFactory : Factory
    {
        /// <summary>
        /// create Del command
        /// </summary>
        /// <returns></returns>
        public override CommandExcute CreateFactory()
        {
            //throw new System.NotImplementedException();
            return new DeletesFile();
        }
    }
}
