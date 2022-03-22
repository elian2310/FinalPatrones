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

        public Usuario(string usr, string psw)
        {
            User = usr;
            Pass = psw;
            carrito = new List<Producto>();
        }
        

        public void AddProducto()
        {
            
            Console.WriteLine("Añadiendo producto(s) a su carrito");   
        }

        public void GuardarCarrito()
        {
            
        }

        public void Login()
        {
            
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
