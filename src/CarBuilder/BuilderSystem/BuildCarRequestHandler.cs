using System.Collections.Generic;
using System.Linq;
using log4net;
using MediatR;

namespace CarBuilder.BuilderSystem
{
    public class BuildCarRequestHandler : IRequestHandler<BuildCarRequest, BuildCarResponse> 
    {
        private readonly ILog _logger;
        private readonly IEnumerable<IBuildCarHandler> _buildCarHandlers;

        public BuildCarRequestHandler(IEnumerable<IBuildCarHandler> buildCarHandlers)
        {
            _logger = LogManager.GetLogger("BuildCarRequestHandler");
            _buildCarHandlers = buildCarHandlers;
        }

        public BuildCarResponse Handle(BuildCarRequest message)
        {
            _logger.InfoFormat("processing {0}", "handler name");

            var builders = _buildCarHandlers
                .Where(h => h.CanHandle(message))
                .OrderBy(h => h.GetPriority());

            foreach (var builder in builders)
            {
                builder.HandleRequest(message);
            }
            
            return new BuildCarResponse();
        }
       
    }
}