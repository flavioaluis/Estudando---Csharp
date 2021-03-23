using System;

namespace ExURI1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int pedido = int.Parse(Console.ReadLine());
            int quantidade = int.Parse(Console.ReadLine());

            double pedidovalor, valortotal;
            
            pedidovalor = 0;


            switch (pedido)
            {
                case 1:

                    pedidovalor = 4.00;
                    break;

                case 2:

                    pedidovalor = 4.50;
                    break;
                case 3:

                    pedidovalor = 5.00;
                    break;
                case 4:

                    pedidovalor = 2.00;
                    break;
                case 5:

                    pedidovalor = 1.50;
                    break;
                default:
                    
                    break;
            }

            valortotal = pedidovalor * quantidade;
            Console.WriteLine("Total: R$ " + valortotal.ToString("F2"));
           

        }
    }
}


