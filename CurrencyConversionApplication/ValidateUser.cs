using System;

namespace CurrencyConversionApplication
{
    public class ValidateUser : IValidateUser
    {
      
        public bool Validate(string Source,String Destination,int Amount)
        {
            if (Source.Length != 3 || Destination.Length != 3 || Amount <= 0)
            {
                return false;
            }
            else if(!( (Source[0]>=65 && Source[0] <=90)  || (Source[1]>=65 && Source[1]<=90) || (Source[2]>=65 && Source[0] <=90)))
            {
                return false;
            }
            else if (!((Destination[0] >= 65 && Destination[0] <= 90) || (Destination[1] >= 65 && Destination[1] <= 90) || (Destination[2] >= 65 && Destination[0] <= 90)))
            {
                return false;
            }
            return true;
        }
    }
}
