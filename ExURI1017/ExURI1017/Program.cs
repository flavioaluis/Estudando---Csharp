using System;

namespace ExURI1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempogasto, velocidademedia;
            double litrosgasto, distanciapercorrida;

            tempogasto = int.Parse(Console.ReadLine());
            velocidademedia = int.Parse(Console.ReadLine());
            distanciapercorrida = tempogasto * velocidademedia;
            litrosgasto = distanciapercorrida / 12;

            Console.WriteLine(litrosgasto.ToString("F3"));
        }
    }
}
