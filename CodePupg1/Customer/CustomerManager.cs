using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePupg1.Customer
{
    public class CustomerManager : ICustomerManager
    {
        private Customers Customers;
        private ICustomerInfo CustomerInfo;

        public CustomerManager(Customers customers, ICustomerInfo customerInfo)
        {
            Customers = customers;
            CustomerInfo = customerInfo;
        }

        public void Init()
        {
            CreateCustomerMockData("Jesper", "Lövsson", 1);
            CreateCustomerMockData("Kalle", "Karlsson", 2);

        }


        public void CreateCustomerMockData(string firstName, string lastName, int id)
        {
            var userName = firstName + "." + lastName + id;

            CustomerInfo.Id = id;
            CustomerInfo.FirstName = firstName;
            CustomerInfo.LastName = lastName;
            CustomerInfo.UserName = userName;

            Customers.customers.Add(CustomerInfo);
        }

        public void CreateCustomer()
        {
            Console.WriteLine("Please enter Firstname: ");
            CustomerInfo.FirstName = Console.ReadLine();
            Console.WriteLine("Please enter Lastname: ");
            CustomerInfo.LastName = Console.ReadLine();

            CustomerInfo.Id = Customers.customers.Count() + 1;
            var userName = CustomerInfo.FirstName + "." + CustomerInfo.LastName + CustomerInfo.Id;
            CustomerInfo.UserName = userName;

            Customers.customers.Add(CustomerInfo);

            Console.WriteLine("Customer has been added");
            Console.ReadKey();
        }

        public void ShowCustomers()
        {
            Console.WriteLine("Customers:  ");

            foreach (var customer in Customers.customers)
            {
                Console.WriteLine("");
                Console.WriteLine("Id: " + customer.Id);
                Console.WriteLine("Name: " + customer.FirstName + " " + customer.LastName);
                Console.WriteLine("UserName:  " + customer.UserName);
                Console.WriteLine("--------------------------------------");
            }

            Console.ReadKey();
        }

        public ICustomerInfo FindOwner(int id)
        {
            foreach (var customer in Customers.customers)
            {
                if (customer.Id == id)
                {
                    return customer;
                }
            }
            return null;
        }

    }
}
