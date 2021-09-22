using System.Threading.Tasks;

namespace CurrencyConversionApplication
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            StandardMessages.StartMessage();

            CurrencyMenu currency = new CurrencyMenu();

            ValidateUser validateUser = new ValidateUser();
            
            StartConversion startConversion = new StartConversion(currency,validateUser);
            
            await startConversion.Start();
            
            StandardMessages.EndMessage();
        }
    }
}