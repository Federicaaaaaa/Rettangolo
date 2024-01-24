using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rettangolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rettangolo r = new Rettangolo();
            r.Lato1 = float.Parse(Console.ReadLine());
            r.Lato2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Area:{0}", r.Area());
            Console.WriteLine("Perimetro:{0}", r.Perimetro());
            Console.WriteLine(r.ToString());
            
            Console.WriteLine();

            float l1 = float.Parse(Console.ReadLine());
            Quadrato q = new Quadrato(l1);
            Console.WriteLine("Area:{0}", q.Area());
            Console.WriteLine("Perimetro:{0}", q.Perimetro());
            Console.WriteLine(q.ToString());

            Console.ReadLine();
        }
    }
}
