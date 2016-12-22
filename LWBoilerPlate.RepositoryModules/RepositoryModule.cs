using Castle.Windsor;
using LWBoilerPlate.AspectLayers.Aspects;
using LWBoilerPlate.ModuleContracts;
using LWBoilerPlate.RepositoryContracts;
using LWBoilerPlate.RepositoryLayers;
using Component = Castle.MicroKernel.Registration.Component;

namespace LWBoilerPlate.RepositoryModules
{
    public class RepositoryModule : IIoCBootstrapper
    {
        public void Init(IWindsorContainer container)
        {
            // Repository Interface-Class'lar 

            container.Register(Component.For<IExampleRepository>().ImplementedBy<ExampleRepository>().Interceptors(typeof(RepositoriesInterceptor)));
        }
    }
}
