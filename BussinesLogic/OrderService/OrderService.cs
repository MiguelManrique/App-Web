using DataAccess.OrderRepository;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.OrderService
{
    public class OrderService : IOrderService
    {
        public List<Order> GetAllOrders()
        {
            IOrderRepository repository = new OrderRepository();
            return repository.GetAllOrders();
        }


        public Order GetOrderById(int orderId)
        {
            IOrderRepository repository = new OrderRepository();
            return repository.GetOrderById(orderId);
        }
    }
}
