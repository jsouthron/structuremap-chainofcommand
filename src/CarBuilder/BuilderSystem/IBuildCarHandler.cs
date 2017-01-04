
namespace CarBuilder.BuilderSystem
{

    public interface IBuildCarHandler
    {
        int GetPriority();

        bool CanHandle(BuildCarRequest buidCarRequest);

        void HandleRequest(BuildCarRequest buildCarRequest);
    }
}
