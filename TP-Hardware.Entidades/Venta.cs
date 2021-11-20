using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Hardware.Entidades
{
    public class Venta
    {
        private int _idCliente;
        private int _idProducto;
        private int _cantidad;
        private int _estado;
        private DateTime _fechaDeAlta;
        private int _usuario;
        private int id;

        public Venta(int idCliente, int idProducto, int cantidad, int estado)
        {
            _idCliente = idCliente;
            _idProducto = idProducto;
            _cantidad = cantidad;
            _estado = estado;
        }

        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public int IdProducto { get => _idProducto; set => _idProducto = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public int Estado { get => _estado; set => _estado = value; }
        public DateTime FechaDeAlta { get => _fechaDeAlta; set => _fechaDeAlta = value; }
        public int Usuario { get => _usuario; set => _usuario = value; }
        public int Id { get => id; set => id = value; }

        public string Mostrar
        {
            get => $"{this.Estado} - {this.IdCliente} - {this.IdProducto}";
        }
    }
}

