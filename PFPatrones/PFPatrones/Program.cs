using System;
using System.Collections.Generic;
using System.Linq;

namespace PFPatrones
{
    class Program
    {
        private static Random random = new Random();
        static void Main(string[] args)
        {
            Fachada fachada = new Fachada();

            List<int> muebles = new List<int>();
            List<int> cocina = new List<int>();
            List<int> habitacion = new List<int>();
            List<int> electricos = new List<int>();
            List<int> exterior = new List<int>();

            FlyweightFactory fabrica = new FlyweightFactory();

            List<Proxy> usuarios = new List<Proxy>();

            int ind;
            ind = fabrica.AddFlyweight("Cama", 600);
            muebles.Add(ind);
            habitacion.Add(ind);

            ind = fabrica.AddFlyweight("Comoda", 300);
            muebles.Add(ind);
            habitacion.Add(ind);

            ind = fabrica.AddFlyweight("Televisor", 500);
            habitacion.Add(ind);
            electricos.Add(ind);

            ind = fabrica.AddFlyweight("Licuadora", 60);
            cocina.Add(ind);
            electricos.Add(ind);

            ind = fabrica.AddFlyweight("Hidrolavadora", 200);
            electricos.Add(ind);
            exterior.Add(ind);

            ind = fabrica.AddFlyweight("Mesa con 4 sillas", 100);
            muebles.Add(ind);
            cocina.Add(ind);
            exterior.Add(ind);

            ind = fabrica.AddFlyweight("Aspiradora", 50);
            habitacion.Add(ind);
            electricos.Add(ind);

            ind = fabrica.AddFlyweight("Sillon", 80);
            muebles.Add(ind);
            habitacion.Add(ind);
            exterior.Add(ind);

            ind = fabrica.AddFlyweight("Tostadora", 40);
            cocina.Add(ind);
            electricos.Add(ind);
            while (true)
            {
                Console.WriteLine("Escoja una opcion:");
                Console.WriteLine("1: Hacer pedido | 2: Ver productos por categoria | 3: Ingresar como Cliente | 4: Registrar Cliente");
                int selec = Convert.ToInt32(Console.ReadLine());
                switch (selec)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre del producto:");
                        string nprod = Console.ReadLine();
                        Console.WriteLine("Ingrese la cantidad");
                        int cant = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Escoja al proovedor:");
                        Console.WriteLine("1: Walmart USA | 2: Nestle Chile | 3: Importaciones México | 4: Confecciones Champarancho | 5: Electronicos ElAlto");
                        int nprov = Convert.ToInt32(Console.ReadLine());
                        fachada.RealizarPedido(nprod, cant, nprov);
                        break;
                    case 2:
                        Console.WriteLine("MUEBLES");
                        foreach (int p in muebles)
                        {
                            ConcreteFlyweight fwprod = (ConcreteFlyweight)fabrica[p];
                            Console.WriteLine(fwprod.GetNombre() + " - " + fwprod.GetPrecio().ToString());
                        }
                        Console.WriteLine("COCINA");
                        foreach (int p in cocina)
                        {
                            ConcreteFlyweight fwprod = (ConcreteFlyweight)fabrica[p];
                            Console.WriteLine(fwprod.GetNombre() + " - " + fwprod.GetPrecio().ToString());
                        }
                        Console.WriteLine("HABITACION");
                        foreach (int p in habitacion)
                        {
                            ConcreteFlyweight fwprod = (ConcreteFlyweight)fabrica[p];
                            Console.WriteLine(fwprod.GetNombre() + " - " + fwprod.GetPrecio().ToString());
                        }
                        Console.WriteLine("ELECTRICOS");
                        foreach (int p in electricos)
                        {
                            ConcreteFlyweight fwprod = (ConcreteFlyweight)fabrica[p];
                            Console.WriteLine(fwprod.GetNombre() + " - " + fwprod.GetPrecio().ToString());
                        }
                        Console.WriteLine("EXTERIOR");
                        foreach (int p in exterior)
                        {
                            ConcreteFlyweight fwprod = (ConcreteFlyweight)fabrica[p];
                            Console.WriteLine(fwprod.GetNombre() + " - " + fwprod.GetPrecio().ToString());
                        }
                        break;
                    case 3:
                        Console.WriteLine("Ingrese su usuario:");
                        string usrnam = Console.ReadLine();
                        Proxy usrprox = UsuarioExiste(usuarios, usrnam);
                        if (usrprox != null)
                        {
                            Console.WriteLine("Ingrese su contraseña:");
                            string passw = Console.ReadLine();
                            string captcha = RandomString(6);
                            Console.WriteLine("Ingrese el captcha: " + captcha);
                            string inpcaptcha = Console.ReadLine();
                            if (inpcaptcha.Equals(captcha))
                            {
                                usrprox.Login(usrnam,passw);
                            }
                            else
                            {
                                Console.WriteLine("Captcha erroneo");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ese usuario no esta registrado");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Ingrese el nuevo usuario:");
                        string nusrnam = Console.ReadLine();
                        Console.WriteLine("Ingrese la nueva contraseña:");
                        string npassw = Console.ReadLine();
                        usuarios.Add(new Proxy(new Usuario(nusrnam, npassw)));
                        Console.WriteLine("Usuario registrado correctamente");
                        break;
                    default:
                        break;
                }
            }
        }
        public static Proxy UsuarioExiste(List<Proxy> lista, string nusr)
        {
            Proxy res = null;
            foreach (Proxy p in lista)
            {
                if (p.user.User == nusr)
                    res = p;
            }
            return res;
        }
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
