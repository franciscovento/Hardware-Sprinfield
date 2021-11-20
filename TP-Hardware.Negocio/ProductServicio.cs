using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Hardware.AccesoDatos;
using TP_Hardware.Entidades;

namespace TP_Hardware.Negocio
{
    public class ProductServicio
    {
        private ProductMapper _productMapper;

        public ProductServicio()
        {
            _productMapper = new ProductMapper();
        }

        public List<Producto> GetProductos()
        {
            return _productMapper.TraerProductos();
        }

        public void AddProducto(Producto producto)
        {
            TransactionResult resultado = _productMapper.Agregar(producto);

            if (resultado.IsOk == false)
                throw new Exception("no se pudo insertar el cliente. motivo " + resultado.Error);
        }
    }
}
