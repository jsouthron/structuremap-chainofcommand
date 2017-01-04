using System;

namespace CarBuilder.BuilderSystem
{
    public class BuildBodyBuildCarHandler : IBuildCarHandler
    {
        public bool CanHandle(BuildCarRequest buidCarRequest) { return true; }

        public int GetPriority() { return 20; }

        public void HandleRequest(BuildCarRequest buildCarRequest)
        {
            Console.WriteLine("Building Body of Care ...");
        }
    }
}