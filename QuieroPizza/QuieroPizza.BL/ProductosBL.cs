using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuieroPizza.BL
{
    public class ProductosBL
    {   
      public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Pizza 8 quesos ";
            producto1.Precio = 200;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Pizza Jamon y Carne ";
            producto2.Precio = 100;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Pizza Hawaiana ";
            producto1.Precio = 250;

            var ListadeProductos = new List<Producto>();
            ListadeProductos.Add(producto1);
            ListadeProductos.Add(producto2);
            ListadeProductos.Add(producto3);
            return ListadeProductos;
        }
    }
}
