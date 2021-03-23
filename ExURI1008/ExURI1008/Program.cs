using System;

namespace ExURI1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUMBER, HOUR;
            double SALARY, SalaryHOUR;

            NUMBER = int.Parse(Console.ReadLine());
            HOUR = int.Parse(Console.ReadLine());
            SalaryHOUR = double.Parse(Console.ReadLine());

            SALARY = SalaryHOUR * HOUR;

            Console.WriteLine("NUMBER = " + NUMBER);
            Console.WriteLine("SALARY = " + ("U$ ") + SALARY.ToString("F2"));

        }
    }
}
