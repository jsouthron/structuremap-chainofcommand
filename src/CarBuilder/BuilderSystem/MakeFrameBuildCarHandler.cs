using System;

namespace CarBuilder.BuilderSystem
{
    public class MakeFrameBuildCarHandler : IBuildCarHandler
    {
        public bool CanHandle(BuildCarRequest buidCarRequest) { return true; }

        public int GetPriority() { return 10; }

        public void HandleRequest(BuildCarRequest buildCarRequest)
        {
            Console.WriteLine("Making Frame ...");
        }
    }
}