using CarBuilder.MediatR;
using log4net;

namespace CarBuilder.BuilderSystem.PostRequestHandlers
{
    public class MyPostRequestHandler : IPostRequestHandler<BuildCarRequest, BuildCarResponse>
    {
        public void Handle(BuildCarRequest request, BuildCarResponse response)
        {
            var log = LogManager.GetLogger("FileRemovalPostRequestHandler");
            log.InfoFormat("Post Request Handler has Fired");

        }

        public bool CanHandle(BuildCarRequest request)
        {
            return request.RunPostProcessor;
        }
    }
}
