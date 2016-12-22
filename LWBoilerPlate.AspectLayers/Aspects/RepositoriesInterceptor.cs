using System;
using Castle.DynamicProxy;
using Castle.MicroKernel;
using LWBoilerPlate.AspectContracts;

namespace LWBoilerPlate.AspectLayers.Aspects
{
    public class RepositoriesInterceptor : IInterceptor
    {
        private readonly IKernel _kernel;

        public RepositoriesInterceptor(IKernel kernel)
        {
            _kernel = kernel;
        }

        public void Intercept(IInvocation invocation)
        {
            var exceptionHandlerManager = _kernel.Resolve<IExceptionHandlerManager>();

            try
            {
                invocation.Proceed();
            }
            catch (Exception ex)
            {
                // exception'ın loglanması 
                exceptionHandlerManager.HandleException(ex);
            }
        }
    }
}
