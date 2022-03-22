using System;
using System.Collections.Generic;
using System.Text;

namespace PFPatrones
{
    class PE1
    {
        public string Nombre { get; set; }
        public PE1()
        {
            Nombre = "Walmart USA";
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
            Console.WriteLine(Nombre + " ORDER PROTOCOL:");
            Console.WriteLine("Order received: " + cantidad.ToString() + "x " + producto);
            Console.WriteLine("Please deposit " + ((GenerarCosto(producto) * cantidad)/2).ToString() + "Bs. to our bank account");
            Console.WriteLine("Please send your bank economic solvency certificate to the email: orders@walmart.org");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
