using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rettangolo
{
    internal class Quadrato : Rettangolo
    {
        public Quadrato(float l) 
        { 
            Lato1 = l;
            Lato2 = l;
        }

        public override string ToString()
        {
            return string.Format("Quadrato di lato {0}", Lato1);
        }
    }
}
