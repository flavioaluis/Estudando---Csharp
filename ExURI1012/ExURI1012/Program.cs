using System;

namespace ExURI1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double A,B,C,triangulo,circulo,trapezio,quadrado,retangulo, pi;

            pi = 3.14159;
            string[] v = Console.ReadLine().Split(' ');
           
            A = double.Parse(v[0]);
            B = double.Parse(v[1]);
            C = double.Parse(v[2]);

            triangulo = A * C / 2;
            circulo = pi * Math.Pow(C, 2.0);
            trapezio = ((A + B) * C) / 2;
            quadrado = Math.Pow(B, 2.0);
            retangulo = A * B ;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3"));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3"));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3"));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3"));

        }
    }
}
