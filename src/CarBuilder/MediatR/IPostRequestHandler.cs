namespace CarBuilder.MediatR
{
    public interface IPostRequestHandler<in TRequest, in TResponse>
    {
        void Handle(TRequest request, TResponse response);
        bool CanHandle(TRequest request);
    }
}