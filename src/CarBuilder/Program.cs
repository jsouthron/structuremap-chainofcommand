using CarBuilder.BuilderSystem;
using MediatR;

namespace CarBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = ContainerBootstrapper.Container.GetInstance<IMediator>();

            mediator.Send(new BuildCarRequest
            {
                Color = CarColor.Blue,
                IsConvertible = true
            });
        }
    }
}
