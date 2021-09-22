using System;

namespace CurrencyConversionApplication
{
    public interface IValidateUser
    {
        public bool Validate(string Source,String Destination,int Amount);
    }
}
