using DataAccess.CustomerRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.CustomerService
{
    public class CustomerService : ICustomerService
    {
        public void InsertCustomer(Entities.Customer objCustomer)
        {
            ICustomerRepository repository = new CustomerRepository();
            repository.InsertCustomer(objCustomer);
        }

        public void UpdateCustomer(Entities.Customer objCustomer)
        {
            ICustomerRepository repository = new CustomerRepository();
            repository.UpdateCustomer(objCustomer);
        }

        public void DeleteCustomer(string customerId)
        {
            ICustomerRepository repository = new CustomerRepository();
            repository.DeleteCustomer(customerId);
        }

        public List<Entities.Customer> GetAllCustomers()
        {
            ICustomerRepository repository = new CustomerRepository();
            return repository.GetAllCustomers();
        }


        public Entities.Customer GetCustomerById(string customerId)
        {
            ICustomerRepository repository = new CustomerRepository();
            return repository.GetCustomerById(customerId);
        }
    }
}
