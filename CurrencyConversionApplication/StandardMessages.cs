using System;

namespace CurrencyConversionApplication
{
    

    public static class StandardMessages 
    {
        public static void DisplayOutput(int amount,string output)
        {
            Console.WriteLine("--------------------The Converted Value is--------------------");
            Console.WriteLine("          "+amount+" "+output);
        }

        public static void EndMessage()
        {
            Console.WriteLine("--------------------Thank You---------------------");
        }
        public static void StartMessage()
        {
            Console.WriteLine("--------------------Welcome--------------------");
        }
    }
}
