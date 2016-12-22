using System;

namespace LWBoilerPlate.AspectContracts
{
    public interface IExceptionHandlerManager
    {
        void HandleException(Exception exception);
    }
}
