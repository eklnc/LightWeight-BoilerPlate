using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using LWBoilerPlate.ComponentModules;

namespace LWBoilerPlate.Container.Installers
{
    public class ComponentInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var componentBootstrapper = new ComponentModule();
            componentBootstrapper.Init(container);
        }
    }
}