﻿using System;
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
        private ProveedorNegocio _proveedorNegocio;
        public FrmAgregarProducto(Form propietario)
        {
            _productServicio = new ProductServicio();
            _proveedorNegocio = new ProveedorNegocio();
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
                Producto p1 = new Producto(Convert.ToInt32(_txtIdCategoria.Text), _txtNombreProducto.Text, Convert.ToInt32(_txtStock.Text), Convert.ToInt32(_cbIdProveedor.Text), Convert.ToDouble(_txtPrecio.Text));
                _productServicio.AddProducto(p1);
                LimpiarCampos();
                this.Hide();
                this.Owner.Show();
            }
        }

        private void Validaciones(ref string msj)
        {
            if (_cbIdProveedor.SelectedIndex == -1)
                msj += "Debes selecionar un id de proveedor" + System.Environment.NewLine;

            msj += ValidarDatos.ValidarNumero(_txtIdCategoria.Text, "Id Categoría");
            msj += ValidarDatos.ValidarVacio(_txtNombreProducto.Text, "Nombre producto");
            msj += ValidarDatos.ValidarNumero(_txtStock.Text, "Stock");
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
            _cbIdProveedor.SelectedIndex = -1;
            _txtPrecio.Clear();
        }

        private void FrmAgregarProducto_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            List<Proveedor> _proveedores = _proveedorNegocio.TraerTodo();
            _cbIdProveedor.DataSource = null;
            _cbIdProveedor.DataSource = _proveedores;
            _cbIdProveedor.DisplayMember = "Id";
            _cbIdProveedor.SelectedIndex = -1;
            
        }
    }
}
