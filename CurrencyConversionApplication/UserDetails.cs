using System;
namespace CurrencyConversionApplication
{
    public class UserDetails : IUserDetails
    {
        private string source, destination;
        private int amount;
        
        public static void SourceCurrency(ref string source)
        {
            Console.WriteLine("Enter Source Currency eg-> USD");
            source = Console.ReadLine();
        }
        public static void DestinationCurrency(ref string destination)
        {
            Console.WriteLine("Enter destination Currency eg-> INR");
            destination = Console.ReadLine();
        }

        public static void AmountCurrency(ref int amount)
        {
            try
            {
                Console.WriteLine("Enter Amount eg-> 10");

                amount = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);   
            }
            
        }
        public string Source 
        { 
            get
            {
                return source;
            }
            set
            {
                source = value;
            }

        }
        public string Destination 
        { 
            get
            {
                return destination;
            }

            set
            {
                destination = value;
            }

        }

        public int Amount 
        {
            get
            {
                return amount;
            } 
            set
            {
                amount = value;
            }
                
        }

      
    }
}
