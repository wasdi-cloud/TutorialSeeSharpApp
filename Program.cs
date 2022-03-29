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
            GetWorkspacesNames(wasdi);
        }

        private static void GetWorkspacesNames(Wasdi wasdi)
        {
            wasdi.WasdiLog("GetWorkspacesNames():");

            List<string> workspacesNames = wasdi.GetWorkspacesNames();

            foreach (string workspaceName in workspacesNames)
            {
                wasdi.WasdiLog(workspaceName);
            }
        }
    }
}
