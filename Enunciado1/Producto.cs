using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enunciado1
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public decimal Precio { get; set; }
        public Usuario Usuario { get; set; }

        public Producto(string nombre, string marca, decimal precio, Usuario usuario)
        {
            Nombre = nombre;
            Marca = marca;
            Precio = precio;
            Usuario = usuario;
        }

        public override string ToString()
        {
            return $"{Nombre} ({Marca}) - {Precio:C} - Usuario: {Usuario}";
        }
    }
}
