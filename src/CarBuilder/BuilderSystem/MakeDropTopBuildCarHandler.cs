using System;

namespace CarBuilder.BuilderSystem
{
    public class MakeDropTopBuildCarHandler : IBuildCarHandler
    {
        public bool CanHandle(BuildCarRequest buidCarRequest) { return true; }

        public int GetPriority() { return 40; }

        public void HandleRequest(BuildCarRequest buildCarRequest)
        {
            Console.WriteLine("Making car a drop top covertible ...");
        }
    }
}