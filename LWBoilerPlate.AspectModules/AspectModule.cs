using Castle.Windsor;
using LWBoilerPlate.AspectContracts;
using LWBoilerPlate.AspectLayers;
using LWBoilerPlate.AspectLayers.Aspects;
using LWBoilerPlate.ModuleContracts;
using Component = Castle.MicroKernel.Registration.Component;

namespace LWBoilerPlate.AspectModules
{
    public class AspectModule : IIoCBootstrapper
    {
        public void Init(IWindsorContainer container)
        {
            // Aspect Interface-Class'lar 

            container.Register(Component.For<IExceptionHandlerManager>().ImplementedBy<ExceptionHandlerManager>());
            container.Register(Component.For<ILoggingHandlerManager>().ImplementedBy<LoggingHandlerManager>());
            container.Register(Component.For<ComponentsInterceptor>());
            container.Register(Component.For<RepositoriesInterceptor>());
        }
    }
}
