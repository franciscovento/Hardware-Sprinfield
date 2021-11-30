using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TP_Hardware.Entidades
{
    [DataContract]
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
            this.idCategoria = idCategoria;
            this.nombre = nombre;
            this.stock = stock;
            this.proveedor = proveedor;
            this.precio = precio;
        }
        public Producto(int id, int idCategoria, string nombre, int stock, int proveedor, double precio)
        {
            this.id = id;
            this.idCategoria = idCategoria;
            this.nombre = nombre;
            this.stock = stock;
            this.proveedor = proveedor;
            this.precio = precio;
        }


        [DataMember(Name ="Id")]
    public int Id { get => id; set => id = value; }
    [DataMember(Name ="IdCategoria")]
    public int IdCategoria { get => idCategoria; set => idCategoria = value; }

    [DataMember(Name ="Nombre")]
    public string Nombre { get => nombre; set => nombre = value; }
    [DataMember(Name = "Stock")]
    public int Stock { get => stock; set => stock = value; }
    
    public int Proveedor { get => proveedor; set => proveedor = value; }
    [DataMember(Name = "Precio")]
    public double Precio { get => precio; set => precio = value; }
    public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
    public int Usuario { get => usuario; set => usuario = value; }

    public string Mostrar
        {
            get => $"Id Producto:{Id} - {Nombre} - ${Precio}";
        }

        public string MostrarCombo
        {
            get => $"Id:{Id} - {Nombre}";
        }

    }
 
}
