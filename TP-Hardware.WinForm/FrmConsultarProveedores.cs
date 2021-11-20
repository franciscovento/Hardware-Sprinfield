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

        //    private void _btnBuscarCliente_Click(object sender, EventArgs e)
        //    {
        //        int salida;
        //        if (_txtBuscarCliente.Text == "" || (!Int32.TryParse(_txtBuscarCliente.Text, out salida)))
        //        {
        //            MessageBox.Show("El campo debe ser númerico y no debe estar vacío", "Error");
        //        }

        //        List<Cliente> c = _clienteServicio.GetClientes().FindAll(x => x.DNI == Convert.ToInt32(_txtBuscarCliente.Text));

        //        if (c.Count > 0)
        //        {
        //            _lstClientes.DataSource = null;
        //            _lstClientes.DataSource = c;
        //            _lstClientes.DisplayMember = "Mostrar";
        //            _lstClientes.ValueMember = "DNI";
        //            _txtBuscarCliente.Clear();
        //        }
        //        else
        //        {
        //            MessageBox.Show("No existen clientes con ese documento", "Error");
        //        }

        //    }
    }
}
