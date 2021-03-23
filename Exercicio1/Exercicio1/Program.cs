using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem a sua casa?");
            int quarto = int.Parse (Console.ReadLine());

            Console.WriteLine("Entre com o preço do produto:");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o seu último nome, idade e altura (mesma linha)");
            string[] v = Console.ReadLine().Split(' ');
            string ultimoNome = v[0];
            int idade = int.Parse(v[1]);
            double altura = double.Parse(v[2]);

            Console.WriteLine(nome);
            Console.WriteLine(quarto);
            Console.WriteLine(preco);
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}
