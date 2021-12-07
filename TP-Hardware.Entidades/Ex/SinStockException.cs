using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Hardware.Entidades.Ex
{
    public class SinStockException:Exception
    {
        public SinStockException(Producto prod) : base("No se encontraron stock del producto" + prod.Nombre)
        {

        }
    }
}
