using System;

namespace CarBuilder.BuilderSystem
{
    public class PaintRedBuildCarHandler : IBuildCarHandler
    {
        public bool CanHandle(BuildCarRequest buidCarRequest) { return buidCarRequest.Color == CarColor.Red; }

        public int GetPriority() { return 30; }

        public void HandleRequest(BuildCarRequest buildCarRequest)
        {
            Console.WriteLine("Painting Car Red ...");
        }
    }
}