using System;
using Castle.DynamicProxy;
using Castle.MicroKernel;
using LWBoilerPlate.AspectContracts;
using LWBoilerPlate.Models;
using LWBoilerPlate.Models.Entities;

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
            //var exceptionHandlerManager = _kernel.Resolve<IExceptionHandlerManager>();
            //var loggingHandlerManager = _kernel.Resolve<ILoggingHandlerManager>();

            using (var context = new LWBoilerPlateContext())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        LWBoilerPlateContext.SetContext(context);

                        invocation.Proceed();

                        context.SaveChanges();

                        dbContextTransaction.Commit();

                        //loggingHandlerManager.LogToDb(invocation);
                    }
                    catch (Exception ex)
                    {
                        dbContextTransaction.Rollback();

                        // exception'ın loglanması 
                        //exceptionHandlerManager.HandleException(ex);
                    }
                }
            }
        }
    }
}
