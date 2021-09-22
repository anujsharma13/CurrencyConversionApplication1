using System;
using System.Threading.Tasks;

namespace CurrencyConversionApplication
{
    public class CurrencyConversion
    {
        private IUserDetails _userDetails;
        private IApiDetails _apiDetails;

        public CurrencyConversion(IUserDetails userDetails, IApiDetails apiDetails)
        {
            _apiDetails = apiDetails;
            _userDetails = userDetails;
        }

       public async Task ConvertCurrency()
        {
            try
            {
                ApiHelper apiHelper = new ApiHelper(_apiDetails);
                var output = await apiHelper.Helper();
                output = output * _userDetails.Amount;
                StandardMessages.DisplayOutput(_userDetails.Amount,_userDetails.Source+" = "+output+" "+_userDetails.Destination);
            }
            catch(Exception e)
            {
                StandardError.standardexception(" No Such Currency Exist for Conversion Try with another one",e);
            }
        }
     
    }
}