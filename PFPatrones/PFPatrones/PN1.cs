using System;
using System.Collections.Generic;
using System.Text;

namespace PFPatrones
{
    class PN1
    {
        public string Nombre { get; set; }
        public PN1()
        {
            Nombre = "Confecciones Champarancho";
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
            Console.WriteLine("Gracias por pedir a " + Nombre);
            Console.WriteLine("Por favor deposite el pago de seguro de transporte en territorio nacional a nuestra cuenta de banco");
            Console.WriteLine("Por favor envie su extracto de movimiento economico de los ultimos 5 meses al email: felixarancibia@gmail.com");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
