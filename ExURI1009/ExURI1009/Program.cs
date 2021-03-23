using System;

namespace ExURI1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string vendedor;
            double salariofixo,total, vendasefetuadas;
            

            vendedor = Console.ReadLine();
            salariofixo = double.Parse(Console.ReadLine());
            vendasefetuadas = double.Parse(Console.ReadLine());

            total = salariofixo + (vendasefetuadas * 15 / 100);

            Console.WriteLine("TOTAL = " + ("R$ ") + total.ToString("F2"));
        }
    }
}
