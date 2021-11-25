namespace CodePupg1.Customer
{
    public interface ICustomerManager
    {
        void CreateCustomer();
        void CreateCustomerMockData(string firstName, string lastName, int id);
        ICustomerInfo FindOwner(int id);
        void Init();
        void ShowCustomers();
    }
}