using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using LWBoilerPlate.RepositoryModules;

namespace LWBoilerPlate.Container.Installers
{
    public class RepositoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var repositoryBootstrapper = new RepositoryModule();
            repositoryBootstrapper.Init(container);
        }
    }
}