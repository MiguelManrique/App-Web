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
            this.customerId = customerId;
            this.orderId = orderId;

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {    
            try
            {
                this.CustomerService = new CustomerService();
                this.OrderService = new OrderService();


                Customer objCustomer = this.CustomerService.GetCustomerById(customerId);
                Order objOrder = this.OrderService.GetOrderById(orderId);

                this.dtpODate.Value = objOrder.OrderDate.Value;
                this.dtpRDate.Value = objOrder.RequiredDate.Value;
                this.dtpSDate.Value = objOrder.ShippedDate.Value;
                this.txtSVia.Text = objOrder.ShipVia.ToString();
                this.txtFreight.Text = objOrder.Freight.ToString();
                this.txtSName.Text = objOrder.ShipName;
                this.txtSAddress.Text = objOrder.ShipAddress;
                this.txtSCity.Text = objOrder.ShipCity;
                this.txtSRegion.Text = objOrder.ShipRegion;
                this.txtSPostalCode.Text = objOrder.ShipPostalCode;
                this.txtSCountry.Text = objOrder.ShipCountry;

                this.LoadAllOrders();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LoadAllOrders()
        {
            dgvOrders.DataSource = this.OrderService.GetAllOrders();
        }
    }
}
