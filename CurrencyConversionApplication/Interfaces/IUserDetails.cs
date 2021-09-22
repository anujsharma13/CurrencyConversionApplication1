namespace CurrencyConversionApplication
{
    public interface IUserDetails
    {
        public string Source { get; set; }
        public string Destination { get; set; }
        public int Amount { get; set; }
    }
}
