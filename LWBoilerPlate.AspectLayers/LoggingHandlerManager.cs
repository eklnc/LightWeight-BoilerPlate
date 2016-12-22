using Castle.DynamicProxy;
using LWBoilerPlate.AspectContracts;

namespace LWBoilerPlate.AspectLayers
{
    public class LoggingHandlerManager : ILoggingHandlerManager
    {
        public void LogToDb(IInvocation invocation)
        {
            // bla bla log işlemleri
        }
    }
}
