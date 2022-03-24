using System;
using System.Collections.Generic;
using System.Text;

namespace PFPatrones
{
    class Usuario : IProxy
    {
        public string User { get; set; }
        public string Pass { get; set; }
        public List<Producto> carrito { get; set; }
        public CareTaker saves;

        public Usuario(string usr, string psw)
        {
            User = usr;
            Pass = psw;
            carrito = new List<Producto>();
            saves = new CareTaker();
        }
        

        public void AddProducto(string nprod, int cant)
        {
            carrito.Add(new Producto(nprod, cant));
            Console.WriteLine(nprod + " x" + cant.ToString() + " añadido al carrito");
        }

        public void GuardarCarrito()
        {
            List<Producto> copia = new List<Producto>();
            foreach (Producto p in carrito)
            {
                copia.Add(new Producto(p.nombreProducto, p.cantidad));
            }
            saves.mementos.Add(new Memento(copia));
            Console.WriteLine("Carrito Guardado!");
        }

        public void Login(string usr, string psw)
        {
            bool logout = false;
            while (!logout)
            {
                Console.WriteLine("¿Que desea hacer?");
                Console.WriteLine("1: Añadir producto al carrito | 2: Guardar Carrito | 3: Recuperar Carrito | 4: Vaciar Carrito | 5: Pagar Carrito | 6: Cerrar Sesión");
                int selec = Convert.ToInt32(Console.ReadLine());
                switch (selec)
                {
                    case 1:
                        Console.WriteLine("Inserte el nombre del producto");
                        string nprod = Console.ReadLine();
                        Console.WriteLine("Inserte la cantidad");
                        int cant = Convert.ToInt32(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Green;
                        AddProducto(nprod, cant);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        GuardarCarrito();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        RestoreCarrito(saves.mementos[^1]);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        ResetCarrito();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Green;
                        PagarCarrito();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 6:
                        Console.WriteLine("Adios " + User);
                        logout = true;
                        break;
                    default:
                        break;
                }
            }
        }

        public void PagarCarrito()
        {
            Console.WriteLine("Procesando pedidos");
            int precio = 0;
            foreach (Producto p in carrito)
            {
                Console.WriteLine(p.nombreProducto + " " + p.cantidad.ToString() + "x = " + p.CalcularPrecio().ToString() + " Bs.");
                precio = precio + p.CalcularPrecio();
            }
            Console.WriteLine("TOTAL: " + precio.ToString() + " Bs.");
            Console.WriteLine("Carrito pagado satisfactoriamente");
        }

        public void ResetCarrito()
        {
            carrito.Clear();
            Console.WriteLine("Carrito vaciado!");
        }

        public void RestoreCarrito(Memento memento)
        {
            carrito.Clear();
            foreach (Producto p in memento.Carrito)
            {
                carrito.Add(p);
            }
            Console.WriteLine("Carrito restaurado!");
        }
    }
}
