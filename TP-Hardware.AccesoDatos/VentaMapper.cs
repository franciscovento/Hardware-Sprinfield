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
    public class VentaMapper
    {
        public List<Venta> TraerTodo()
        {
            string json = WebHelper.Get("VentaHardware/Ventas/892789");
            List<Venta> rta = MapList(json);
            return rta;
        }

        private List<Venta> MapList(string json)
        {
            List<Venta> rta = JsonConvert.DeserializeObject<List<Venta>>(json);
            return rta;
        }

        public TransactionResult Insertar(Venta venta)
        {
            NameValueCollection obj = ReverseMap(venta);
            string json = WebHelper.Post("VentaHardware/Ventas", obj);
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }

        private NameValueCollection ReverseMap(Venta venta)
        {
            NameValueCollection n = new NameValueCollection();

            n.Add("IdCliente", venta.IdCliente.ToString());
            n.Add("IdProducto", venta.IdProducto.ToString());
            n.Add("Cantidad" ,venta.Cantidad.ToString());
            n.Add("Estado", venta.Estado.ToString());
            n.Add("Usuario", "892789");

            return n;

        }
    }
}
