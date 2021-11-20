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
    public partial class FrmAgregarProveedor : Form
    {
        private ProveedorNegocio _provNegocio;
        public FrmAgregarProveedor(Form prop)
        {
           
            _provNegocio = new ProveedorNegocio();
            this.Owner = prop;
            InitializeComponent();
        }

        private void _btnAgregarCliente_Click(object sender, EventArgs e)
        {
            string msj = "";
            Validaciones(ref msj);

            if (msj == "")
            {
                Proveedor prov = new Proveedor(Convert.ToInt32(txtIDProd.Text), _txtNombre.Text, _txtApellido.Text, _txtEmail.Text, _txtCuit.Text, cbActivo.Checked);
                _provNegocio.Agregar(prov);
                LimpiarCampos();
                this.Hide();
                this.Owner.Show();

               
            }
        }

        private void Validaciones(ref string msj)
        {

            msj += ValidarDatos.ValidarVacio(_txtNombre.Text, "nombre");
            msj += ValidarDatos.ValidarVacio(_txtApellido.Text, "apellido");
            msj += ValidarDatos.ValidarVacio(_txtCuit.Text, "dirección");
            msj += ValidarDatos.ValidarVacio(_txtEmail.Text, "email");
            msj += ValidarDatos.ValidarNumero(txtIDProd.Text, "IdProd");


            if (msj != "")
            {
                MessageBox.Show(msj, "Error");
            }
        }
        private void LimpiarCampos()
        {
            txtIDProd.Clear();
            _txtNombre.Clear();
            _txtApellido.Clear();
            _txtEmail.Clear();
            _txtCuit.Clear();
            _txtEmail.Clear();
        }
        private void _bntVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
    }
   }

