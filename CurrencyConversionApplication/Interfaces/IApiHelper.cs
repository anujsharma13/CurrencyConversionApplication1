using System.Threading.Tasks;

namespace CurrencyConversionApplication
{
    public interface IApiHelper
    {
        public Task<double> Helper();
    }
}
