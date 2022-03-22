using System;
using System.Collections.Generic;
using System.Text;

namespace PFPatrones
{
    class FlyweightFactory
    {
        private List<IFlyweight> flyweights = new List<IFlyweight>();

        public int AddFlyweight(string producto, int price)
        {
            bool existe = false;
            foreach (IFlyweight f in flyweights)
            {
                if (f.GetNombre() == producto)
                    existe = true;
            }
            if (existe)
            {
                Console.WriteLine("Ese producto ya esta añadido");
                return -1;
            }
            else
            {
                ConcreteFlyweight prod = new ConcreteFlyweight();
                prod.SetNombre(producto);
                prod.SetPrecio(price);
                flyweights.Add(prod);
                return (flyweights.Count - 1);
            }
        }

        public IFlyweight this[int index]
        {
            get { return flyweights[index]; }
        }
    }
}
