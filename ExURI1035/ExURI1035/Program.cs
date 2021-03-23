using System;

namespace ExURI1035
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, soma1, soma2;

            string[] v = Console.ReadLine().Split(' ');
            A = int.Parse(v[0]);
            B = int.Parse(v[1]);
            C = int.Parse(v[2]);
            D = int.Parse(v[3]);

            soma1 = C + D;
            soma2 = A + B;

            if (B > C && D > A && soma1 > soma2 && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");

            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
