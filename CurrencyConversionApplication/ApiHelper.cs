using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace CurrencyConversionApplication
{
    public class ApiHelper : IApiHelper
    {
        public static HttpClient httpClient=new HttpClient();
        private IApiDetails _apidetails;
        Double result;
        static ApiHelper()
        {
        
            httpClient = new HttpClient();
            
        }
       public ApiHelper(IApiDetails apidetails)
        {
            _apidetails = apidetails;
        }
        public async Task<double> Helper()
        {
            var body = "";
            try
            {
                HttpClient client = new HttpClient();
                HttpRequestMessage request = new HttpRequestMessage();
                request.Method = HttpMethod.Get;
                request.RequestUri = new Uri(_apidetails.Api);
                request.Headers.Add(_apidetails.ApiKey, _apidetails.ApiValue);
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    body = await response.Content.ReadAsStringAsync();
                    if (body == "0")
                        throw new InvalidOperationException("Exception");
                }
            }
            catch(Exception w)
            {
                throw new InvalidOperationException("Exception");
            }
            result = Convert.ToDouble(body);
            return result;
       }
    }
}
