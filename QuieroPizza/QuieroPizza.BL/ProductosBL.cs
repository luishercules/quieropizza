﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuieroPizza.BL
{
    public class ProductosBL
    {
        Contexto _contexto;

        public List<Producto> ListadeProductos { get; set; }


        public ProductosBL()//Constructor de la clase
        {
            _contexto = new Contexto();
            ListadeProductos = new List<Producto>();    
        }
      public List<Producto> ObtenerProductos()
        {            
            return _contexto.Productos.ToList();
        }
    }
}
