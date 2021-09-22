using System;
namespace CurrencyConversionApplication
{
    public class CurrencyMenu : ICurrencyMenu
    {
        public void MainMenu()
        {
          Console.WriteLine("--------------------Main Menu--------------------");
          Console.WriteLine("              1. To Enter Currency names and start conversion press 1");
          Console.WriteLine("              2. exit                        ");
        }

        

        public void SubMenu(ref string source,ref string destination,ref int amount)
        {
            try
            {
                Console.WriteLine("-------------------- Enter the Currency names--------------------");
                UserDetails.SourceCurrency(ref source);
                UserDetails.DestinationCurrency(ref destination);
                
                UserDetails.AmountCurrency(ref amount);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
