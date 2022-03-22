using System;
using System.Collections.Generic;
using System.Text;

namespace PFPatrones
{
    class ConcreteFlyweight : IFlyweight
    {
        private string nombre;
        private int precio;

        public override bool Equals(object obj)
        {
            return obj is ConcreteFlyweight flyweight &&
                   nombre == flyweight.nombre;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(nombre, precio);
        }

        public string GetNombre()
        {
            return nombre;
        }

        public int GetPrecio()
        {
            return precio;
        }

        public void SetNombre(string n)
        {
            nombre = n;
        }

        public void SetPrecio(int p)
        {
            precio = p;
        }
        
    }
}
