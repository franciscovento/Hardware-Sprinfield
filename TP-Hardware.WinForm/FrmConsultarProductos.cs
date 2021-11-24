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
using TP_Hardware.Entidades.Enum;
using TP_Hardware.Negocio;

namespace TP_Hardware.WinForm
{
    public partial class FrmConsultarProductos : Form
    {
        private ProductServicio _productServicio;
        private FrmAgregarProducto _formAgregarProducto;
        bool ready = false;
        public FrmConsultarProductos(Form propietario)
        {
            _formAgregarProducto = new FrmAgregarProducto(this);
            _productServicio = new ProductServicio();
            this.Owner = propietario;
            InitializeComponent();
        }

        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void FrmConsultarProductos_Load(object sender, EventArgs e)
        {
            CargarListaProducto();
            CargarCombos();
            ready = true;
        }

        private void CargarListaProducto()
        {
            _lstProductos.DataSource = null;
            _lstProductos.DataSource = _productServicio.GetProductos();
            _lstProductos.DisplayMember = "Mostrar";
            _lstProductos.ValueMember = "Id";
        }

        private void CargarCombos()
        {
            _cbListarPorCategoria.DataSource = Enum.GetValues(typeof(CategoriaEnum));
        }

        private void _btnAgregarProd_Click(object sender, EventArgs e)
        {
            this.Hide();
            _formAgregarProducto.Show();
        }

        private void _btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarListaProducto();
        }

        private void _btnBuscarProducto_Click(object sender, EventArgs e)
        {
            int salida;
            if (_txtBuscarProducto.Text == "" || (!Int32.TryParse(_txtBuscarProducto.Text, out salida)))
            {
                MessageBox.Show("El campo debe ser númerico y no debe estar vacío", "Error");
            }
            else
            {
                List<Producto> c = _productServicio.GetProductos().FindAll(x => x.Id == Convert.ToInt32(_txtBuscarProducto.Text));

                if (c.Count > 0)
                {
                    _lstProductos.DataSource = null;
                    _lstProductos.DataSource = c;
                    _lstProductos.DisplayMember = "Mostrar";
                    _lstProductos.ValueMember = "Id";
                    _txtBuscarProducto.Clear();
                }
                else
                {
                    MessageBox.Show("No existen productos con ese id", "Error");
                }
            }


        }

        private void _cbListarPorCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ready)
            {
                List<Producto> c = _productServicio.GetProductos().FindAll(x => x.IdCategoria == _cbListarPorCategoria.SelectedIndex);

                _lstProductos.DataSource = null;
                _lstProductos.DataSource = c;
                _lstProductos.DisplayMember = "Mostrar";
                _txtBuscarProducto.Clear();
            }
        }

       
    }
}
