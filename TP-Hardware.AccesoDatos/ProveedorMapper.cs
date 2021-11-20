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
    public class ProveedorMapper
    {
        public List<Proveedor> TraerTodo()
        {
            string json = WebHelper.Get("VentaHardware/Proveedores/892789");
            List < Proveedor > rst = MapList(json);
            return rst;
        }

        private List<Proveedor> MapList(string json)
        {
            List<Proveedor> lst = JsonConvert.DeserializeObject<List<Proveedor>>(json);
            return lst;
        }
        public TransactionResult Insertar(Proveedor proveedor)
        {
            NameValueCollection obj = ReverseMap(proveedor);
            string json = WebHelper.Post("VentaHardware/Proveedores", obj);
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }

        private NameValueCollection ReverseMap(Proveedor proveedor)
        {
            NameValueCollection n = new NameValueCollection();
            
            n.Add("idProducto", proveedor.IdProducto.ToString());
            n.Add("nombre", proveedor.Nombre);
            n.Add("apellido", proveedor.Apellido);
            n.Add("email", proveedor.Email);
            n.Add("cuit", proveedor.Cuit);
            n.Add("activo", proveedor.Activo.ToString());           
            n.Add("usuario", "892789");

            return n;
        }
    }
}
