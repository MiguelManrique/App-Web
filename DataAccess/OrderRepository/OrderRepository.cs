using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.OrderRepository
{
    public class OrderRepository : IOrderRepository
    {
        public List<Entities.Order> GetAllOrders()
        {
            using (var model = new NorthwindModelEntities())
            {

                var order = from c in model.Orders.Include("Customer")
                               select c;
                return order.ToList();
            }
        }


        public Order GetOrderById(int orderId)
        {
            using (var model = new NorthwindModelEntities())
            {
                var order = from c in model.Orders
                             where c.OrderID == orderId
                             select c;
                return order.FirstOrDefault();
            }
        }
    }
}
