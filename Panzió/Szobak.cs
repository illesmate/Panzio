using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panzió
{
    internal class Szobak
    {
        int szobaszam;
        int ferohely;
        int ar;

        public Szobak(int szobaszam, int ferohely, int ar)
        {
            Szobaszam = szobaszam;
            Ferohely = ferohely;
            Ar = ar;
        }

        public int Szobaszam { get => szobaszam; set => szobaszam = value; }
        public int Ferohely { get => ferohely; set => ferohely = value; }
        public int Ar { get => ar; set => ar = value; }
    }
}
