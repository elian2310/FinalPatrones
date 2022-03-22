using System;
using System.Collections.Generic;
using System.Text;

namespace PFPatrones
{
    class Proxy: IProxy
    {
       private Usuario user;
        public Proxy(Usuario usuario)
        {
            this.user = usuario;
        }
       public void Login()
        {
            Console.WriteLine("Ingrese un usuario:");
            string usr = Console.ReadLine();
            Console.WriteLine("Ingrese su password:");
            string psw = Console.ReadLine();
            if (usr == user.User && psw == user.Pass)
            {
                Console.WriteLine("Bienvenido " + usr);
                user.Login();
            }
            else
            {
                Console.WriteLine("Datos incorrectos");
            }

        }
        

    }
}
