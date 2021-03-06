using System;

namespace CarBuilder.BuilderSystem
{
    public class PaintBlueBuildCarHandler : IBuildCarHandler
    {
        public bool CanHandle(BuildCarRequest buidCarRequest) { return buidCarRequest.Color == CarColor.Blue; }

        public int GetPriority() { return 30; }

        public void HandleRequest(BuildCarRequest buildCarRequest)
        {
            Console.WriteLine("Painting Car Blue ...");
        }
    }
}