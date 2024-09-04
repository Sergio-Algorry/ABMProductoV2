using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMProducto
{
    public class Producto
    {
        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public decimal Precio { get; set; }
       
        public void Crear(string codigo, 
                          string nombre,
                          string precio)
        {
            Codigo=codigo;
            Nombre=nombre;
            Precio= Convert.ToDecimal(precio);  
        }

        public string NombreCompleto()
        {
            return Codigo + " - " + Nombre + " $ " + Precio.ToString();
        }
    }
}
