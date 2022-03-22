using System;
using System.Collections.Generic;

namespace PFPatrones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> muebles = new List<int>();
            List<int> cocina = new List<int>();
            List<int> habitacion = new List<int>();
            List<int> electricos = new List<int>();
            List<int> exterior = new List<int>();

            FlyweightFactory fabrica = new FlyweightFactory();

            int ind;
            ind = fabrica.AddFlyweight("Cama", 600);
            muebles.Add(ind);
            habitacion.Add(ind);

            ind = fabrica.AddFlyweight("Comoda", 300);
            muebles.Add(ind);
            habitacion.Add(ind);

            ind = fabrica.AddFlyweight("Televisor", 500);
            habitacion.Add(ind);
            electricos.Add(ind);

            ind = fabrica.AddFlyweight("Licuadora", 60);
            cocina.Add(ind);
            electricos.Add(ind);

            ind = fabrica.AddFlyweight("Hidrolavadora", 200);
            electricos.Add(ind);
            exterior.Add(ind);

            ind = fabrica.AddFlyweight("Mesa con 4 sillas", 100);
            muebles.Add(ind);
            cocina.Add(ind);
            exterior.Add(ind);

            ind = fabrica.AddFlyweight("Aspiradora", 50);
            habitacion.Add(ind);
            electricos.Add(ind);

            ind = fabrica.AddFlyweight("Sillon", 80);
            muebles.Add(ind);
            habitacion.Add(ind);
            exterior.Add(ind);

            ind = fabrica.AddFlyweight("Tostadora", 40);
            cocina.Add(ind);
            electricos.Add(ind);
        }
    }
}
