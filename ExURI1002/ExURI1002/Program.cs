using System;

namespace ExURI1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, area, raio;

            n = 3.14159;

            raio = double.Parse(Console.ReadLine());

            area = n * (Math.Pow(raio, 2));

            Console.WriteLine("A=" + area.ToString("F4"));

        }
    }
}
