using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.CustomerRepository
{
    public class CustomerRepository : ICustomerRepository
    {
        public void InsertCustomer(Entities.Customer objCustomer)
        {
            using (var model = new NorthwindModelEntities())
            {  
                model.Customers.Add(objCustomer);
                model.SaveChanges();
            }
        }

        public void UpdateCustomer(Entities.Customer objCustomer)
        {
            using (var model = new NorthwindModelEntities())
            {
                var original = model.Customers.Find(objCustomer.CustomerID);

                if (original != null)
                {
                    model.Entry(original).CurrentValues.SetValues(objCustomer);
                    model.SaveChanges();
                }
            }
        }

        public void DeleteCustomer(string customerId)
        {
            using (var model = new NorthwindModelEntities())
            {
                Customer objCustomer = model.Customers.Find(customerId);
                if (objCustomer != null)
                {
                    model.Customers.Remove(objCustomer);
                    model.SaveChanges();
                }
            }
        }

        public List<Entities.Customer> GetAllCustomers()
        {
            using (var model = new NorthwindModelEntities())
            {

                var customer = from c in model.Customers.Include("Orders")
                              select c;
                return customer.ToList();
            }
        }


        public Customer GetCustomerById(string customerId)
        {
            using (var model = new NorthwindModelEntities())
            {
                var customer = from c in model.Customers
                               where c.CustomerID == customerId
                            select c;
                return customer.FirstOrDefault();
            }
        }
    }
}
