using System;
using System.Collections.Generic;
using System.Text;

namespace PFPatrones
{
    class PE2
    {
        public string Nombre { get; set; }
        public PE2()
        {
            Nombre = "Nestle Chile";
        }
        public int GenerarCosto(string producto)
        {
            int azar = 0;
            foreach (char letra in producto)
            {
                azar = azar + (int)letra;
            }
            return azar;
        }
        public void RecibirPedido(string producto, int cantidad)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Prorocolo de pedidos de "+Nombre);
            Console.WriteLine("Orden recivida: " + cantidad.ToString() + "x " + producto);
            Console.WriteLine("Por favor realice el deposito de: " + ((GenerarCosto(producto) * cantidad) / 5).ToString()+" Bs. a nuestra cuenta de banco");
            Console.WriteLine("El pedido llegara 3 meses despues de recibido el deposito");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
