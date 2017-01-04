using System;

namespace CarBuilder.BuilderSystem
{
    public class PaintGreenBuildCarHandler : IBuildCarHandler
    {
        public bool CanHandle(BuildCarRequest buidCarRequest) { return buidCarRequest.Color == CarColor.Green; }

        public int GetPriority() { return 30; }

        public void HandleRequest(BuildCarRequest buildCarRequest)
        {
            Console.WriteLine("Painting Car Green ...");
            Console.WriteLine("Green cars cannot be convertibles.  Setting override ...");
            buildCarRequest.IsConvertible = false;

        }
    }
}