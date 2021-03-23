using System;

namespace ExURI1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c,MaiorAB,MaiorABC;

            string[] v = Console.ReadLine().Split(' ');

            a = int.Parse(v[0]);
            b = int.Parse(v[1]);
            c = int.Parse(v[2]);

            MaiorAB = (a + b + Math.Abs(a - b)) / 2;
            MaiorABC = (MaiorAB + c + Math.Abs(MaiorAB - c)) / 2;

            Console.WriteLine(MaiorABC + " eh o maior");


        }
    }
}
