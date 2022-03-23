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
        CareTaker saves;

        public Usuario(string usr, string psw)
        {
            User = usr;
            Pass = psw;
            carrito = new List<Producto>();
        }
        

        public void AddProducto(string nprod, int cant)
        {
            carrito.Add(new Producto(nprod, cant));
            Console.WriteLine(nprod + " x" + cant.ToString() + " añadido al carrito");
        }

        public void GuardarCarrito()
        {
            
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
                        AddProducto(nprod, cant);
                        break;
                    case 2:
                        GuardarCarrito();
                        break;
                    case 3:
                        ResetCarrito();
                        break;
                    case 4:
                        ResetCarrito();
                        break;
                    case 5:
                        PagarCarrito();
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
            Console.WriteLine("Carrito pagado satisfactoriamente");
        }

        public void ResetCarrito()
        {
            

        }

        public void RestoreCarrito()
        {
            
            
        }
    }
}
