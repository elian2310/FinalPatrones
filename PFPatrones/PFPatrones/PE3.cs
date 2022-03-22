using System;
using System.Collections.Generic;
using System.Text;

namespace PFPatrones
{
    class PE3
    {
        public string Nombre { get; set; }
        public PE3()
        {
            Nombre = "Importaciones México";
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
            Console.WriteLine("Requerimientos de pedido de " + Nombre);
            Console.WriteLine("Por favor envie su:\n-Certificado de seguro internacional de transporte\n-Extracto bancario de movimientos delúltimo año\n-Número de Identificación Tributaria actualizado");
            Console.WriteLine("Al siguiente email: pedidos@impmx.org");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
