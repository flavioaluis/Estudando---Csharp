﻿using System;

namespace ExURI1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double  R, pi, volume;
            pi = 3.14159;
            R = double.Parse(Console.ReadLine());

            volume = (4 / 3.0) * pi * Math.Pow(R, 3);

            Console.WriteLine("VOLUME = " + volume.ToString("F3") );
        }
    }
}
