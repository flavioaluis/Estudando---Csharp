using System;

namespace ExURI1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, MEDIA;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());
            A = A * 2;
            B = B * 3;
            C = C * 5;
            MEDIA = (A + B + C) / 10;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1"));
        }
    }
}
