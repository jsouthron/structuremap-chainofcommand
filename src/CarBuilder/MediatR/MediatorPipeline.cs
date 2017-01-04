using System.Linq;
using MediatR;
using CarBuilder.BuilderSystem;

namespace CarBuilder.MediatR
{
    public class MediatorPipeline<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
        where TRequest : class, IRequest<TResponse>
    {
        private readonly IRequestHandler<TRequest, TResponse> _inner;
        private readonly IPreRequestHandler<TRequest>[] _preRequestHandlers;
        private readonly IPostRequestHandler<TRequest, TResponse>[] _postRequestHandlers;


        public MediatorPipeline(
            IRequestHandler<TRequest, TResponse> inner,
            IPreRequestHandler<TRequest>[] preRequestHandlers,
            IPostRequestHandler<TRequest, TResponse>[] postRequestHandlers
            )
        {
            _inner = inner;
            _preRequestHandlers = preRequestHandlers;
            _postRequestHandlers = postRequestHandlers;
        }

        public TResponse Handle(TRequest message)
        {
            foreach (var preRequestHandler in _preRequestHandlers.Where(h => h.CanHandle(message)))
            {
                preRequestHandler.Handle(message);
            }

            var result = _inner.Handle(message);

            foreach (var postRequestHandler in _postRequestHandlers.Where(h => h.CanHandle(message)))
            {
                postRequestHandler.Handle(message, result);
            }

            return result;
        }
    }
}