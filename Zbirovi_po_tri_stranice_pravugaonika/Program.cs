using System;

namespace Zbirovi_po_tri_stranice_pravugaonika
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, m, n, O, P;

            m = double.Parse(Console.ReadLine());
            n = double.Parse(Console.ReadLine());

            b = ((2 * m) - n) / 3;
            a = m - (2 * b);

            O = (2 * a) + (2 * b);
            P = a * b;

            Console.WriteLine(Math.Round(O, 2));
            Console.WriteLine(Math.Round(P, 2));
        }
    }
}
