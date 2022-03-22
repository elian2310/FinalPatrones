using System;
using System.Collections.Generic;
using System.Text;

namespace PFPatrones
{
    class Fachada
    {
        private PE1 extr1 = new PE1();
        private PE2 extr2 = new PE2();
        private PE3 extr3 = new PE3();
        private PN1 nac1 = new PN1();
        private PN2 nac2 = new PN2();
        public void RealizarPedido(string producto,int cantidad, int proveedor)
        {
            switch (proveedor)
            {
                case 1:
                    extr1.RecibirPedido(producto, cantidad);
                    break;
                case 2:
                    extr2.RecibirPedido(producto, cantidad);
                    break;
                case 3:
                    extr3.RecibirPedido(producto, cantidad);
                    break;
                case 4:
                    nac1.RecibirPedido(producto, cantidad);
                    break;
                case 5:
                    nac2.RecibirPedido(producto, cantidad);
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
        }
    }
}
