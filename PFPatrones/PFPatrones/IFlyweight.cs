using System;
using System.Collections.Generic;
using System.Text;

namespace PFPatrones
{
    interface IFlyweight
    {
        void SetNombre(string n);
        void SetPrecio(int p);
        string GetNombre();
        int GetPrecio();
    }
}
