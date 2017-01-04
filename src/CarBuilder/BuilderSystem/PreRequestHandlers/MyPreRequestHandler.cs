using CarBuilder.MediatR;
using log4net;
using MediatR;

namespace CarBuilder.BuilderSystem.PreRequestHandlers
{
    public class MyPreRequestHandler : IPreRequestHandler<BuildCarRequest>
    {
        private readonly IMediator _mediator;
        private readonly ILog _log;

        public MyPreRequestHandler(IMediator mediator)
        {
            _log = LogManager.GetLogger("ZipFilePreRequestHandler");
            _mediator = mediator;
        }

        public bool CanHandle(BuildCarRequest request)
        {
            return request.RunPreProcessor;
        }

        public void Handle(BuildCarRequest request)
        {
            _log.Info("Running Pre Processor");
           
        }
    }
}
