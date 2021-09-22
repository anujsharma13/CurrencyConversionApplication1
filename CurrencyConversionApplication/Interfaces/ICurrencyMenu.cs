namespace CurrencyConversionApplication
{
    public interface ICurrencyMenu
    {
        public void MainMenu();
        public void SubMenu(ref string source,ref string destination,ref int amount);
    }
}
