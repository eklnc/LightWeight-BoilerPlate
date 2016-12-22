using Castle.DynamicProxy;

namespace LWBoilerPlate.AspectContracts
{
    public interface ILoggingHandlerManager
    {
        void LogToDb(IInvocation invocation);
    }
}
