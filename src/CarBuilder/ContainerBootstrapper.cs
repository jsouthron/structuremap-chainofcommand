using CarBuilder.BuilderSystem;
using CarBuilder.MediatR;
using log4net;
using MediatR;
using StructureMap;

namespace CarBuilder
{
    public static class ContainerBootstrapper
    {
        public static Container Container { get; set; }

        static ContainerBootstrapper()
        {
            Container = new Container();
            BootstrapStructureMap();
        }

        public static void BootstrapStructureMap()
        {
           
            Container.Configure(cfg => {
                cfg.Scan(scan =>
                {
                    scan.AssemblyContainingType(typeof(Ping));
                    scan.AddAllTypesOf(typeof(IBuildCarHandler));
                    scan.AddAllTypesOf(typeof(IRequestHandler<,>));
                    scan.AddAllTypesOf(typeof(INotificationHandler<>));
                    scan.AddAllTypesOf(typeof(IPostRequestHandler<,>));
                    scan.AddAllTypesOf(typeof(IPreRequestHandler<>));
                });

                cfg.For<IMediator>().Use<Mediator>();
                cfg.For(typeof(IRequestHandler<,>)).DecorateAllWith(typeof(MediatorPipeline<,>));
                cfg.For<SingleInstanceFactory>().Use<SingleInstanceFactory>(ctx => t => ctx.GetInstance(t));
                cfg.For<MultiInstanceFactory>().Use<MultiInstanceFactory>(ctx => t => ctx.GetAllInstances(t));
                cfg.For<ILog>().Use("log4net setup", c => LogManager.GetLogger(typeof(Program)));
              
            });
        }
    }

    public class Ping { }
}
