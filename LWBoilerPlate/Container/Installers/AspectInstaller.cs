using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using LWBoilerPlate.AspectModules;

namespace LWBoilerPlate.Container.Installers
{
    public class AspectInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var aspectBootstrapper = new AspectModule();
            aspectBootstrapper.Init(container);
        }
    }
}