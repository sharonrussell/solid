using System;

namespace BreakingDependencyInversionPrinciple
{
    public class ExceptionLogger : IExceptionLogger
    {
        public void Log(Exception ex)
        {
            //Log the important details of the exception somewhere useful.
        }
    }
}