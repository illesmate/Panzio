using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panzió
{
    public class Ugyfel
    {
        string nev;
        string azon;
        string email;
        string vip;
        DateTime szuldatum;
        bool vip2;

        public Ugyfel(string nev, string azon, string email, string vip, DateTime szuldatum, bool vip2)
        {
            Nev = nev;
            Azon = azon;
            Email = email;
            Vip = vip;
            Szuldatum = szuldatum;
            Vip2 = vip2;
        }

        public string Nev { get => nev; set => nev = value; }
        public string Azon { get => azon; set => azon = value; }
        public string Email { get => email; set => email = value; }
        public string Vip { get => vip; set => vip = value; }
        public DateTime Szuldatum { get => szuldatum; set => szuldatum = value; }

        public bool Vip2 { get => vip2; set => vip2 = value; }
    }
}
