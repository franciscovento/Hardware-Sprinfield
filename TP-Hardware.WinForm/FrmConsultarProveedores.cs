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
    public partial class FrmConsultarProveedores : Form
    {
        private ProveedorNegocio _proveedorNegocio;
        private List<Proveedor> _proveedor;
        private FrmAgregarProveedor frmAgregarProveedor;
        public FrmConsultarProveedores(Form propietario)
        {
            frmAgregarProveedor = new FrmAgregarProveedor(this);
            _proveedorNegocio = new ProveedorNegocio();
            _proveedor = new List<Proveedor>();
            this.Owner = propietario;
            InitializeComponent();
        }

        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void FrmConsultarProveedores_Load(object sender, EventArgs e)
        {
        Recargar();
        }    

        private void Recargar()
        { 
            lstProveedor.DataSource = null;
            lstProveedor.DataSource = _proveedorNegocio.TraerTodo(); ;
            lstProveedor.DisplayMember = "Mostrar";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarProveedor.Show();
            this.Hide();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            Recargar();
        }

        private void _btnbuscarcliente_click(object sender, EventArgs e)
        {
            int salida;
            if (txtBuscarProd.Text == "" || (!Int32.TryParse(txtBuscarProd.Text, out salida)))
            {
                MessageBox.Show("el campo debe ser númerico y no debe estar vacío", "error");
            }

            List<Proveedor> p = _proveedorNegocio.TraerTodo().FindAll(x => x.Id== Convert.ToInt32(txtBuscarProd.Text));

            if (p.Count > 0)
            {
                lstProveedor.DataSource = null;
                lstProveedor.DataSource = p;
                lstProveedor.DisplayMember = "mostrar";
                lstProveedor.ValueMember = "dni";
                txtBuscarProd.Clear();
            }
            else
            {
                MessageBox.Show("no existen clientes con ese documento", "error");
            }

        }

        private void _btnBuscarCliente_Click_1(object sender, EventArgs e)
        {
            int salida;
            if (txtBuscarProd.Text == "" || (!Int32.TryParse(txtBuscarProd.Text, out salida)))
            {
                MessageBox.Show("El campo debe ser númerico y no debe estar vacío", "Error");
            }
            else
            {
                List<Proveedor> p = _proveedorNegocio.TraerTodo().FindAll(x => x.Id == Convert.ToInt32(txtBuscarProd.Text));

                if (p.Count > 0)
                {
                    lstProveedor.DataSource = null;
                    lstProveedor.DataSource = p;
                    lstProveedor.DisplayMember = "Mostrar";
                    txtBuscarProd.Clear();
                }
                else
                {
                    MessageBox.Show("No existen clientes con ese documento", "Error");
                }
            }

        }
    }
}
