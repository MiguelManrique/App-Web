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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Order objOrder = new Order();
                objOrder.OrderDate = this.dtpODate.Value;
                objOrder.RequiredDate = this.dtpRDate.Value;
                objOrder.ShippedDate = this.dtpSDate.Value;
                objOrder.ShipVia = Convert.ToInt32(this.txtSVia.Text);
               //objIncidencia.Id = Convert.ToInt32(this.txtID.Text);
               //objIncidencia.Fecha = this.dtpFecha.Value;
               //objIncidencia.IdEstado = Convert.ToInt32(this.cbEstado.SelectedValue);
               //objIncidencia.IdRecursosDigitales = Convert.ToInt32(this.cbRecursoDigitales.SelectedValue);
               //objIncidencia.Descripcion = this.txtDescripcion.Text;
               //objIncidencia.IdSupervisor = Convert.ToInt32(this.cbSupervisor.SelectedValue);
               //objIncidencia.ICliente = Convert.ToInt32(this.cbCLiente.SelectedValue);

                //this.IncidenciaService.UpdateIncidencia(objIncidencia);
                //this.LoadAllIncidencias();
                //MessageBox.Show("Incidencia Actualizada satisfactoriamente!");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //private void dgvIncidencias_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //
        //        int incidenciaId = Convert.ToInt32(dgvIncidencias.Rows[e.RowIndex].Cells["IdColumn"].Value);
        //        Incidencia objIncidencia = this.IncidenciaService.GetIncidenciaById(incidenciaId);
        //        this.txtID.Text = objIncidencia.Id.ToString();
        //        this.dtpFecha.Value = objIncidencia.Fecha;
        //        this.cbRecursoDigitales.SelectedValue = objIncidencia.IdRecursosDigitales;
        //        this.txtDescripcion.Text = objIncidencia.Descripcion;
        //        this.cbSupervisor.SelectedValue = objIncidencia.IdSupervisor;
        //        this.cbCLiente.SelectedValue = objIncidencia.ICliente;
        //
        //    }
        //}

        //private void btnAgregar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //
        //        Incidencia objIncidencia = new Incidencia();
        //        //objIncidencia.Fecha = this.dtpFecha.Value.ToString("dd/MM/yyyy");
        //        objIncidencia.Fecha = this.dtpFecha.Value.ToLocalTime();
        //        objIncidencia.IdEstado = Convert.ToInt32(this.cbEstado.SelectedValue);
        //        objIncidencia.IdRecursosDigitales = Convert.ToInt32(this.cbRecursoDigitales.SelectedValue);
        //        objIncidencia.Descripcion = this.txtDescripcion.Text;
        //        objIncidencia.IdSupervisor = Convert.ToInt32(this.cbSupervisor.SelectedValue);
        //        objIncidencia.ICliente = Convert.ToInt32(this.cbCLiente.SelectedValue);
        //
        //        this.IncidenciaService.InsertIncidencia(objIncidencia);
        //        this.LoadAllIncidencias();
        //        MessageBox.Show("Incidencia Guardada satisfactoriamente!");
        //    }
        //    catch (Exception ex)
        //    {
        //        //throw ex;
        //    }
        //}

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    if (dgvCourses.SelectedRows.Count > 0)
        //    {
        //        string thisText = "this record?";
        //        if (dgvCourses.SelectedRows.Count > 1)
        //        {
        //            thisText = "these records?";
        //        }
        //        if (MessageBox.Show("Are you sure you want to delete " + thisText,
        //            "Confirmation",
        //            MessageBoxButtons.YesNoCancel) ==
        //            System.Windows.Forms.DialogResult.Yes)
        //        {
        //            for (int i = 0; i < dgvCourses.SelectedRows.Count; i++)
        //            {
        //                int courseId = Convert.ToInt32(dgvCourses.SelectedRows[i].Cells["IdColumn"].Value);
        //                this.CourseService.DeleteCourse(courseId);
        //            }
        //            this.LoadAllCourses();
        //        }
        //    }
        //}

    }
}
