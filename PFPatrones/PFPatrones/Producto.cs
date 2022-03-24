using System;
using System.Collections.Generic;
using System.Text;

namespace PFPatrones
{
    class Producto
    {
        public string nombreProducto;
        public int cantidad;

        public Producto(string nombreProd, int cantidad)
        {
            this.nombreProducto = nombreProd;
            this.cantidad = cantidad;
        }
        public int CalcularPrecio()
        {
            int azar = 0;
            foreach (char letra in nombreProducto)
            {
                azar = azar + (int)letra;
            }
            return azar;
        }
    }
}
