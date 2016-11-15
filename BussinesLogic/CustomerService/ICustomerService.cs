using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.CustomerService
{
    public interface ICustomerService
    {
        void InsertCustomer(Customer objCustomer);
        void UpdateCustomer(Customer objCustomer);
        void DeleteCustomer(int customerId);
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(int customerId);
    }
}
