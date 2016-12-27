using System;
using Castle.DynamicProxy;
using Castle.MicroKernel;
using LWBoilerPlate.AspectContracts;

namespace LWBoilerPlate.AspectLayers.Aspects
{
    public class ComponentsInterceptor : IInterceptor
    {
        private readonly IKernel _kernel;

        public ComponentsInterceptor(IKernel kernel)
        {
            _kernel = kernel;
        }

        public void Intercept(IInvocation invocation)
        {
            //var exceptionHandlerManager = _kernel.Resolve<IExceptionHandlerManager>();
            //var loggingHandlerManager = _kernel.Resolve<ILoggingHandlerManager>();

            try
            {
                invocation.Proceed();

                //loggingHandlerManager.LogToDb(invocation);
            }
            catch (Exception ex)
            {
                // exception'ın loglanması (redis)
                //exceptionHandlerManager.HandleException(ex);
            }
        }
    }
}
