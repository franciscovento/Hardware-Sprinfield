using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Hardware.AccesoDatos;
using TP_Hardware.Entidades;

namespace TP_Hardware.Negocio
{
    public class ProveedorNegocio
    {
        List<Proveedor> _proveedor;
        ProveedorMapper _proveedorMapper;
        public ProveedorNegocio()
        {
            _proveedorMapper = new ProveedorMapper();

        }

        public List<Proveedor> TraerTodo()
        {
            _proveedor = _proveedorMapper.TraerTodo();
            return _proveedor;
        }

        public TransactionResult Agregar(Proveedor prov)
        {
            TransactionResult result = _proveedorMapper.Insertar(prov);

            if (result.IsOk == false)
                throw new Exception("No se pudo insertar el cliente. Motivo " + result.Error);
            return result;
        }

      
    }
}
