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
    public partial class FrmConsultarVentas : Form
    {
        private VentaNegocio _ventaNegocio;
        private FrmAgregarVenta _frmAgregarVenta;
        
        public FrmConsultarVentas(Form propietario)
        {
            _ventaNegocio = new VentaNegocio();
            _frmAgregarVenta = new FrmAgregarVenta(this);
            this.Owner = propietario;
            InitializeComponent();
        }

        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void FrmConsultarVentas_Load(object sender, EventArgs e)
        {
            Recargar();
        }

        private void Recargar()
        {
           

            lstVentas.DataSource = null;
            lstVentas.DataSource = _ventaNegocio.GetVentas();
            lstVentas.DisplayMember = "Mostrar";
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Recargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            _frmAgregarVenta.Show();
        }

        private void _btnBuscarVenta_Click(object sender, EventArgs e)
        {
            int salida;
            if (txtConsultarVenta.Text == "" || (!Int32.TryParse(txtConsultarVenta.Text, out salida)))
            {
                MessageBox.Show("El campo debe ser númerico y no debe estar vacío", "Error");
            }
            else
            {
                List<Venta> v = _ventaNegocio.GetVentas().FindAll(x => x.Id == Convert.ToInt32(txtConsultarVenta.Text));

                if (v.Count > 0)
                {
                    lstVentas.DataSource = null;
                    lstVentas.DataSource = v;
                    lstVentas.DisplayMember = "Mostrar";

                    txtConsultarVenta.Clear();
                }
                else
                {
                    MessageBox.Show("No existen clientes con ese documento", "Error");
                }
            }

        }
    }
}
