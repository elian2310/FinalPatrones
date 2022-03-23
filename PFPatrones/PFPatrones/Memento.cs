using System;
using System.Collections.Generic;
using System.Text;

namespace PFPatrones
{
    class Memento
    {
        public List<Producto> Carrito { get; set; }

        public Memento(List<Producto>carrito)
        {
            Carrito = carrito;
        }
    }
}
