using System;

namespace ExURI1018
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota100, resto100, nota50, resto50, nota20, resto20, nota10, resto10, nota5, resto5, nota2, N, moeda1, moeda50, moeda25, moeda10, moeda5, moeda01, resto1;

            N = double.Parse(Console.ReadLine());

            nota100 =  N / 100;
            resto100 = N % 100;
            nota50 = resto100 / 50;
            resto50 = resto100 % 50;
            nota20 =  resto50 / 20;
            resto20 = resto50 % 20;
            nota10 =  resto20 / 10;
            resto10 = resto20 % 10;
            nota5 =  resto10 / 5;
            resto5 = resto10 % 5;
            nota2 = resto5 / 2;

            moeda1 =  resto5 % 2;
            moeda50 = moeda1 / 2;
            resto1 = moeda1 % 2;

            Console.WriteLine("NOTAS:");
            Console.WriteLine(nota100 + (" nota(s) de R$ 100,00"));
            Console.WriteLine(nota50 + (" nota(s) de R$ 50,00"));
            Console.WriteLine(nota20+ (" nota(s) de R$ 20,00"));
            Console.WriteLine(nota10 + (" nota(s) de R$ 10,00"));
            Console.WriteLine(nota5 + (" nota(s) de R$ 5,00"));
            Console.WriteLine(nota2 + (" nota(s) de R$ 2,00"));
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(moeda1 + (" moeda(s) de R$ 1,00"));
            Console.WriteLine(moeda50 + (" moeda(s) de R$ 0,50"));
            Console.WriteLine(moeda25 + (" moeda(s) de R$ 0,25"));
            Console.WriteLine(moeda10 + (" moeda(s) de R$ 0,10"));
            Console.WriteLine(moeda5 + (" moeda(s) de R$ 0,05"));
            Console.WriteLine(moeda01 + (" moeda(s) de R$ 0,01"));



        }
    }
}
