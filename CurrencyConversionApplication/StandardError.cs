using System;

namespace CurrencyConversionApplication
{
   
    public static class StandardError 
    {
        public static void standarderror()
        {
            System.Console.WriteLine("Invalid details");
        }

        public static void standardexception(string error,Exception InnerException)
        {
            System.Console.WriteLine("Error = "+error);
        }
    }
}
