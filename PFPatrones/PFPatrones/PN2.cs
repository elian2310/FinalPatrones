using System;
using System.Collections.Generic;
using System.Text;

namespace PFPatrones
{
    class PN2
    {
        public string Nombre { get; set; }
        public PN2()
        {
            Nombre = "Electronicos ElAlto";
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
            Console.WriteLine("Pedidos a " + Nombre);
            Console.WriteLine("Deposite " + (GenerarCosto(producto) * cantidad).ToString() + " Bs. a nuestra cuenta bancaria");
            Console.WriteLine("El pedido llegara en 1 mes posterior al deposito");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
