using System;
using System.Threading.Tasks;

namespace CurrencyConversionApplication
{
  
    public  class StartConversion
    {
        ICurrencyMenu _currencyMenu;
        IValidateUser _validateUser;
        private string source = "";
        private string destination = "";
        private int amount = 1;
       public StartConversion(ICurrencyMenu currencyMenu,IValidateUser validateUser)
        {
            _currencyMenu = currencyMenu;
            _validateUser = validateUser;
        }
        public async Task Continue()
        {
            try
            {
                int choice;
                Console.WriteLine("--------------------Invalid Input--------------------");
                Console.WriteLine("               1.To Enter Again press 1");
                Console.WriteLine("               2.To Continue Press 2");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    await Start();
                }
                else if(choice==2)
                {
                    return;
                }
                else
                {
                    throw new InvalidOperationException("invalid input");
                }
            }
            catch(Exception invalid)
            {
                StandardError.standardexception("Not a Valid Input",invalid);
                return;
            }
            return;
        }
        public async Task Start()
        {
            int choice;
            bool wannaexit=false;
            UserDetails userDetails = new UserDetails();
            ApiDetails apiDetails = new ApiDetails();
            

            _currencyMenu.MainMenu();
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        _currencyMenu.SubMenu(ref source, ref destination, ref amount);
                        break;
                    case 2:
                        wannaexit = true;
                        break;
                    default:
                        StandardError.standarderror();
                        break;
                }
            }
            catch(Exception invalid)
            {
              
                Console.Clear();
                StandardError.standardexception("Not a Valid Input Try Again", invalid);
                await Continue();
                return;
            }
            if (wannaexit == true)
            {
                StandardMessages.EndMessage();
                return ;
            }
            if(source=="" || destination=="")
            {
                StandardError.standarderror();
                try
                {
                    Console.Clear();
                    await Continue();
                }
                catch (Exception e1)
                {
                    StandardError.standardexception("Not a Valid Input Try Again",e1);
                }
                return;
            }
         
            userDetails.Source = source.ToUpper().Trim();
            userDetails.Destination = destination.ToUpper().Trim();
            userDetails.Amount = amount;

            
            apiDetails.Api = $"https://currency-exchange.p.rapidapi.com/exchange?to={userDetails.Destination}&from={userDetails.Source}&q=1.0";
            apiDetails.ApiKey = "x-rapidapi-key";
            apiDetails.ApiValue = "64892e83d5msh2c4dfea8d121897p1f23a7jsnafd1a9f55ca0";

            var isValidated=_validateUser.Validate(userDetails.Source,userDetails.Destination,userDetails.Amount);
            if(!isValidated)
            {
                StandardError.standarderror();
                try
                {
                    Console.Clear();
                    await Continue();
                }
                catch (Exception e1)
                {
                    StandardError.standardexception("Not a Valid Input Try Again",e1);
                }
                return;

            }

            CurrencyConversion currencyConversion = new CurrencyConversion(userDetails, apiDetails);
            await currencyConversion.ConvertCurrency();
            return;
        }
    }
}