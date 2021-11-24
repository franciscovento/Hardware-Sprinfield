using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Hardware.AccesoDatos;
using TP_Hardware.Entidades;

namespace TP_Hardware.Negocio
{
    public class VentaNegocio
    {
        private List<Venta> _lstVenta;
        private VentaMapper _ventaMapper;
        
        public VentaNegocio()
        {
            _ventaMapper = new VentaMapper();

        }
        public List<Venta> GetVentas()
        {
            _lstVenta = _ventaMapper.TraerTodo();
            return _lstVenta;

        }
        public TransactionResult Agregar(Venta venta)
        {
            TransactionResult result = _ventaMapper.Insertar(venta);
            if (result.IsOk == false)
                throw new Exception("No se pudo insertar el cliente. Motivo " + result.Error);
            return result;
        }


    }
}
