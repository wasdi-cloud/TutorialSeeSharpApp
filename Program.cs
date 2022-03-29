using WasdiLib;

namespace TutorialSeeSharpApp
{
    internal class Program : IWasdiRunnable
    {
        static void Main(string[] args)
        {
            Wasdi wasdi = new();
            wasdi.Init();
            wasdi.SetVerbose(true);

            Program program = new Program();
            program.Run(wasdi);
        }

        public void Run(Wasdi wasdi)
        {
            wasdi.WasdiLog(wasdi.Hello());
        }
    }
}
