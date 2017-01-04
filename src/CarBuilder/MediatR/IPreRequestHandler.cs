namespace CarBuilder.MediatR
{
    public interface IPreRequestHandler<in TRequest>
    {
        bool CanHandle(TRequest request);

        void Handle(TRequest request);
    }
}