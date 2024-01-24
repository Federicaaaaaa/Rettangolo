using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rettangolo
{
    internal class Rettangolo
    {
        public float Lato1 { get; set; }
        public float Lato2 { get; set; }
        public float Area()
        {
            return Lato1 * Lato2;
        }
        public float Perimetro()
        {
            return Lato1 * 2 + Lato2 * 2;
        }
        public override string ToString()
        {
            return string.Format("Rettangolo di lati {0} e {1}", Lato1, Lato2);
        }
    }
}
