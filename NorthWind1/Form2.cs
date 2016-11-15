using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BussinesLogic.CustomerService;
using BussinesLogic.OrderService;

namespace NorthWind1
{
    public partial class Form2 : Form
    {
        private ICustomerService CustomerService;
        private IOrderService OrderService;

        string customerId;
        int orderId;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string customerId, int orderId)
        {
            this.CustomerService = new CustomerService();
            this.OrderService = new OrderService();
            this.customerId = customerId;
            this.orderId = orderId;            

            InitializeComponent();
        }
    }
}
