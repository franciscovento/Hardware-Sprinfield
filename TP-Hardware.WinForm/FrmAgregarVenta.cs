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
        public FrmAgregarVenta(Form prop)
        {
            _ventaNegocio = new VentaNegocio();
            this.Owner = prop;
            InitializeComponent();
        }

        
        private void _btnAgregarCliente_Click(object sender, EventArgs e)
        {
            string msj = "";
            Validaciones(msj);


            if (msj == "")
            {
                Venta venta = new Venta(Convert.ToInt32(txIdCliente.Text), Convert.ToInt32(txIdProd.Text),Convert.ToInt32(txCantidad.Text),Convert.ToInt32(txEstado.Text));
                _ventaNegocio.Agregar(venta);
                LimpiarCampos();
                this.Hide();
                this.Owner.Show();
            }
        }

        private void Validaciones(string msj)
        {

            msj += ValidarDatos.ValidarNumero(txIdCliente.Text, "IdCliente");
            msj += ValidarDatos.ValidarNumero(txIdProd.Text, "IdProducto");
            msj += ValidarDatos.ValidarNumero(txCantidad.Text, "Cantidad");
            msj += ValidarDatos.ValidarNumero(txEstado.Text, "Estado");
            

            if (msj != "")
            {
                MessageBox.Show(msj, "Error");
            }
        }


        private void LimpiarCampos()
        {
            txIdCliente.Clear();
            txIdProd.Clear();
            txCantidad.Clear();
            txEstado.Clear();
        }

    

        private void _bntVolver_Click(object sender, EventArgs e)
        {
        this.Hide();
        this.Owner.Show();

        }
    }
}
