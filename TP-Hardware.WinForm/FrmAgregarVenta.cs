using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Hardware.Entidades;
using TP_Hardware.Negocio;

namespace TP_Hardware.WinForm
{
    public partial class FrmAgregarVenta : Form
    {
        public VentaNegocio _ventaNegocio;
        public ClienteServicio clienteServicio;
        public ProductServicio productNegocio;
        private Producto _productoSeleccionado;
        bool ready = false;
        public FrmAgregarVenta(Form prop)
        {
            clienteServicio = new ClienteServicio();
            productNegocio = new ProductServicio();
            _ventaNegocio = new VentaNegocio();
            _productoSeleccionado = new Producto();
            this.Owner = prop;
            InitializeComponent();
        }

        
        private void _btnAgregarCliente_Click(object sender, EventArgs e)
        {
            string msj = "";
            Validaciones(msj);


            if (msj == "")
            {

                try
                {
                    Venta venta = new Venta(Convert.ToInt32(cmbIdCliente.SelectedValue), Convert.ToInt32(cmbIdProducto.SelectedValue), Convert.ToInt32(txCantidad.Text), Convert.ToInt32(txEstado.Text));
                    _ventaNegocio.AgregarVenta( _productoSeleccionado.Id,venta);
                    LimpiarCampos();
                    this.Hide();
                    this.Owner.Show();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CargarCmb()
        {
            cmbIdCliente.DataSource = clienteServicio.GetClientes();
            cmbIdCliente.DisplayMember = "Mostrar";
            cmbIdCliente.ValueMember = "Id";
            cmbIdCliente.SelectedIndex = -1;

            //Agrego Productos
            cmbIdProducto.DataSource = productNegocio.GetProductos();
            cmbIdProducto.DisplayMember = "MostrarCombo";
            cmbIdProducto.ValueMember = "Id";
            cmbIdProducto.SelectedIndex = -1;
        }
        private void Validaciones(string msj)
        {

           
            msj += ValidarDatos.ValidarNumero(txCantidad.Text, "Cantidad");
            msj += ValidarDatos.ValidarNumero(txEstado.Text, "Estado");
            

            if (msj != "")
            {
                MessageBox.Show(msj, "Error");
            }
        }


        private void LimpiarCampos()
        {
            cmbIdCliente.SelectedIndex = 0;
            cmbIdProducto.SelectedIndex = 0;
            txCantidad.Clear();
            txEstado.Clear();
        }

    

        private void _bntVolver_Click(object sender, EventArgs e)
        {
        this.Hide();
        this.Owner.Show();

        }

        private void FrmAgregarVenta_Load(object sender, EventArgs e)
        {
            CargarCmb();
            ready = true;
        }

        private void cmbIdProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ready)
            {
                _productoSeleccionado = productNegocio.GetProductos().Find(x => x.Id == Convert.ToInt32(cmbIdProducto.SelectedValue));
            }
        }
    }
}
