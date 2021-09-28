using System;

namespace DesTiposTriang
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split(' ');

            double a = double.Parse(s[0]);
            double b = double.Parse(s[1]);
            double c = double.Parse(s[2]);
            double auxiliar;

            if (a < b)
            {
                auxiliar = a;
                a = b;
                b = auxiliar;
            }

            if (a < c)
            {
                auxiliar = a;
                a = c;
                c = auxiliar;
            }

            if (b < c)
            {
                auxiliar = b;
                b = c;
                c = auxiliar;
            }

            if (a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if (Math.Pow(a, 2) == (Math.Pow(b, 2) + Math.Pow(c, 2)))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (Math.Pow(a, 2) > (Math.Pow(b, 2) + Math.Pow(c, 2)))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if (Math.Pow(a, 2) < (Math.Pow(b, 2) + Math.Pow(c, 2)))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }

            if (a == b && a == c && b == c)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}
