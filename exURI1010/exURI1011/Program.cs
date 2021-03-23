using System;

namespace exURI1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorapagar, itempreco1, itempreco2;

            string[] v1 = Console.ReadLine().Split(' ');
            int codigopeca1 = int.Parse(v1[0]);
            int quantidadepeca1 = int.Parse(v1[1]);
            double valorunitario1 = double.Parse(v1[2]);

            string[] v2 = Console.ReadLine().Split(' ');
            int codigopeca2 = int.Parse(v2[0]);
            int quantidadepeca2 = int.Parse(v2[1]);
            double valorunitario2 = double.Parse(v2[2]);

            itempreco1 = (quantidadepeca1) * valorunitario1;
            itempreco2 = (quantidadepeca2) * valorunitario2;
            valorapagar = itempreco1 + itempreco2;

            Console.WriteLine("VALOR A PAGAR: " + "R$ " + valorapagar.ToString("F2"));
 


        }
    }
}
