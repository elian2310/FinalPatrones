using System;
using System.Collections.Generic;
using System.Text;

namespace PFPatrones
{
    class Proxy: IProxy
    {
        public Usuario user;
        public Proxy(Usuario usuario)
        {
            this.user = usuario;
        }
       public void Login(string usr, string psw)
        {
            
            if (usr == user.User && psw == user.Pass)
            {
                Console.WriteLine("Bienvenido " + usr);
                user.Login(usr, psw);
            }
            else
            {
                Console.WriteLine("Datos incorrectos");
            }

        }
        

    }
}
