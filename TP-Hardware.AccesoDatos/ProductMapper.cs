using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Hardware.Entidades;

namespace TP_Hardware.AccesoDatos
{
    public class ProductMapper
    {
        private List<Producto> _productos;

        public ProductMapper()
        {

        }

        public List<Producto> TraerProductos()
        {
            string docentesHTTP = WebHelper.Get("VentaHardware/Productos/");
            _productos = MapList(docentesHTTP);
            return _productos;
        }

        private List<Producto> MapList(string json)
        {
            List<Producto> req = JsonConvert.DeserializeObject<List<Producto>>(json);
            return req;
        }

        public TransactionResult Agregar(Producto producto)
        {
            NameValueCollection obj = ReverseMap(producto);

            string json = WebHelper.Post("VentaHardware/Productos/", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

        private NameValueCollection ReverseMap(Producto producto)
        {
            int RegistroAlumno = 892789;
            NameValueCollection n = new NameValueCollection();
            n.Add("idCategoria", Convert.ToString(producto.Id));
            n.Add("Nombre", producto.Nombre);
            n.Add("Stock", Convert.ToString(producto.Stock));
            n.Add("idProveedor", Convert.ToString(producto.Proveedor));
            n.Add("Precio", Convert.ToString(producto.Precio));
            n.Add("Usuario", Convert.ToString(RegistroAlumno));
            return n;
        }
    }
}
