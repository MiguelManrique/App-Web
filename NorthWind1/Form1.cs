using BussinesLogic.CustomerService;
using BussinesLogic.OrderService;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWind1
{
    public partial class Form1 : Form
    {
        private ICustomerService CustomerService;
        private IOrderService OrderService;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.OrderService = new OrderService();
                this.LoadAllOrders();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LoadAllOrders()
        {
            dgvList.DataSource = this.OrderService.GetAllOrders();
        }

        private void dgvList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void dgvList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int orderId = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells["OrderID"].Value);
            string customerId = Convert.ToString(dgvList.Rows[e.RowIndex].Cells["CustomerId"].Value);
            Form2 form2 = new Form2(string customerId, int orderId);
            form2.Show();
        }
    }
}
