using Castle.Windsor;

namespace LWBoilerPlate.ModuleContracts
{
    public interface IIoCBootstrapper
    {
        void Init(IWindsorContainer container);
    }
}
