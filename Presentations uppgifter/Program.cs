using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        double[] temperatur = { 4.5, 3.2, 6.7, 6.1, 2.1, 1.6, 2.9 };
        Medel(temperatur);
       

    }

    static void Medel(double[] temperatur)
    {
        double sum = 0;
        for (int i = 0; i < temperatur.Length; i++)
        {
            sum += temperatur[i];
        }
        double medel = 0;
        for (int i = 0; i < temperatur.Length; i++)
        {
            medel = sum / temperatur.Length;
        }
        double medelvärdet = Math.Round(medel, 2);

        Console.WriteLine($"Medelvärdet är {medelvärdet}");
    }
}

