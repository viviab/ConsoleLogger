namespace ConsoleLog4Net.Services
{
    public class CustomerService : ICustomerService
    {
        public int GetCustomer(int i)
        {
            Logger.Log.Info($"GetCustomer: {i}");
            return i + 1;
        }
    }
}
