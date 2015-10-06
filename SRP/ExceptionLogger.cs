using System;

namespace BreakingSingleResponsibility
{
    public static class ExceptionLogger
    {
        public static void LogException(Exception ex)
        {
            System.IO.File.WriteAllText(@"C:\Error.txt", ex.ToString());
        }
    }
}