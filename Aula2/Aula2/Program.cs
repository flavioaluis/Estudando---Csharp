using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, precoMetroQuadrado, area, preco;
            Console.WriteLine("Digite a largura");
            largura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o comprimento");
            comprimento = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Preço do Metro Quadrado");
            precoMetroQuadrado = double.Parse(Console.ReadLine());
            area = largura * comprimento;
            preco = area * precoMetroQuadrado;

            Console.WriteLine("AREA = " + area.ToString("F2"));
            Console.WriteLine("PREÇO = " + preco.ToString("F2"));
            Console.ReadLine();


        }
    }
}
