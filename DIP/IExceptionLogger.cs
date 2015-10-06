using System;

namespace BreakingDependencyInversionPrinciple
{
    public interface IExceptionLogger
    {
        void Log(Exception ex);
    }
}