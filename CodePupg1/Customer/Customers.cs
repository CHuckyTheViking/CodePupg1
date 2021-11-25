using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePupg1.Customer
{

    public class Customers
    {

        private List<ICustomerInfo> listCustomers = new List<ICustomerInfo>();
        public List<ICustomerInfo> customers
        {
            get
            {
                return listCustomers;
            }
        }


    }
}
