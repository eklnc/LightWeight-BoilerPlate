using Castle.Windsor;
using LWBoilerPlate.AspectLayers.Aspects;
using LWBoilerPlate.ComponentContracts;
using LWBoilerPlate.ComponentLayers;
using LWBoilerPlate.ModuleContracts;
using Component = Castle.MicroKernel.Registration.Component;

namespace LWBoilerPlate.ComponentModules
{
    public class ComponentModule : IIoCBootstrapper
    {
        public void Init(IWindsorContainer container)
        {
            // Component Interface-Class'lar 
            container.Register(Component.For<IExampleComponent>().ImplementedBy<ExampleComponent>().Interceptors(typeof(ComponentsInterceptor)));
        }
    }
}
