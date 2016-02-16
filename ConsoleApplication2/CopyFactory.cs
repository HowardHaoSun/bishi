
namespace ConsoleApplication2
{
    public class CopyFactory:Factory
    {
        /// <summary>
        /// create Copy command
        /// </summary>
        /// <returns></returns>
        public override CommandExcute CreateFactory()
        {
            //throw new System.NotImplementedException();
            return new Copy();
        }
    }
}
