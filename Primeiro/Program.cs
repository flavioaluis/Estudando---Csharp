using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            //string frase = Console.ReadLine();
            //string x = Console.ReadLine();
            // string y = Console.ReadLine();
            // string z = Console.ReadLine();
            // string[] vet = Console.ReadLine().Split(' ');
            // string a = vet[0];
            // string b = vet[1];
            // string c = vet[2];


            //Console.WriteLine("Você digitou " + frase);
            // Console.WriteLine("Você digitou " + x);
            // Console.WriteLine("Você digitou " + y);
            // Console.WriteLine("Você digitou " + z);
            // Console.WriteLine("Você digitou " + a);
            // Console.WriteLine("Você digitou " + b);
            // Console.WriteLine("Você digitou " + c);

            // int n1 = int.Parse(Console.ReadLine());
            // char ch = char.Parse(Console.ReadLine());
            // double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Você Digitou: " + n1);
            Console.WriteLine("Você Digitou: " + ch);
            Console.WriteLine("Você Digitou: " + n2);

            string[] v2 = Console.ReadLine().Split(' ');
            string nome = v2[0];
            char sexo = char.Parse(v2[1]);
            int idade = int.Parse(v2[2]);
          double altura = double.Parse(v2[3], CultureInfo.InvariantCulture);

             Console.WriteLine("Você Digitou: " + nome);
             Console.WriteLine("Você Digitou: " + sexo);
            Console.WriteLine("Você Digitou: " + idade);
            Console.WriteLine("Você Digitou: " + altura);
        }      }
}
