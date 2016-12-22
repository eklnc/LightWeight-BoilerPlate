using System.Web.Mvc;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace LWBoilerPlate.Container
{
    public class IocContainer
    {
        public static IWindsorContainer Container;

        public static void Setup()
        {
            Container = new WindsorContainer()
                .Install(FromAssembly.This());
            var controllerFactory = new Container.WindsorControllerFactory(Container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }

        public static void Dispose()
        {
            Container.Dispose();
        }
    }
}