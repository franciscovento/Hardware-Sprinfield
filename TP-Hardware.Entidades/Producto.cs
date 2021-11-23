using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TP_Hardware.Entidades
{
    
    public class Producto
{
    private int idCategoria;
    private string nombre;
    private int stock;
    private int proveedor;
    private double precio;
    private DateTime fechaAlta;
    private int usuario;
    private int id;

    public Producto()
    {
    }

    public Producto(int idCategoria, string nombre, int stock, int proveedor, double precio)
    {
        IdCategoria = idCategoria;
        Nombre = nombre;
        Stock = stock;
        Proveedor = proveedor;
        Precio = precio;
    }
    public int Id { get => id; set => id = value; }
    public int IdCategoria { get => idCategoria; set => idCategoria = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public int Stock { get => stock; set => stock = value; }
    
    public int Proveedor { get => proveedor; set => proveedor = value; }
    public double Precio { get => precio; set => precio = value; }
    public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
    public int Usuario { get => usuario; set => usuario = value; }

    public string Mostrar
        {
            get => $"{Nombre} {Id}";
        }
    }
 
}
