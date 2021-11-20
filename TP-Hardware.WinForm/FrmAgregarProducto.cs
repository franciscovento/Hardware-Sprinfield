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
    public partial class FrmAgregarProducto : Form
    {
        private ProductServicio _productServicio;
        public FrmAgregarProducto(Form propietario)
        {
            _productServicio = new ProductServicio();
            this.Owner = propietario;
            InitializeComponent();
        }

        private void _bntVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void _btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string msj = "";
            Validaciones(ref msj);


            if (msj == "")
            {
                Producto p1 = new Producto(Convert.ToInt32(_txtIdCategoria.Text), _txtNombreProducto.Text, Convert.ToInt32(_txtStock.Text), Convert.ToInt32(_txtIdProveedor.Text), Convert.ToDouble(_txtPrecio.Text));
                _productServicio.AddProducto(p1);

                LimpiarCampos();
                this.Hide();
                this.Owner.Show();
            }
        }

        private void Validaciones(ref string msj)
        {
            msj += ValidarDatos.ValidarNumero(_txtIdCategoria.Text, "Id Categoría");
            msj += ValidarDatos.ValidarVacio(_txtNombreProducto.Text, "Nombre producto");
            msj += ValidarDatos.ValidarNumero(_txtStock.Text, "Stock");
            msj += ValidarDatos.ValidarNumero(_txtIdProveedor.Text, "Id proveedor");
            msj += ValidarDatos.ValidarNumero(_txtPrecio.Text, "Precio");
            if (msj != "")
            {
                MessageBox.Show(msj, "Error");
            }
        }

        private void LimpiarCampos()
        {
            _txtIdCategoria.Clear();
            _txtNombreProducto.Clear();
            _txtStock.Clear();
            _txtIdProveedor.Clear();
            _txtPrecio.Clear();
        }
    }
}
