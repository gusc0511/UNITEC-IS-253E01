using System;
using Application253E01;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Sistema de Cálculo ===");

        Console.Write("Lado A: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Lado B: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Lado C: ");
        double c = Convert.ToDouble(Console.ReadLine());

        Console.Write("Altura del triángulo: ");
        double h = Convert.ToDouble(Console.ReadLine());

        double perimetro = Figura253E01.Perimetro(a, b, c);
        double area = Figura253E01.Area(a, h);
        double volumen = Figura253E01.Volumen(area, h);

        Console.WriteLine($"\nPerímetro: {perimetro}");
        Console.WriteLine($"Área: {area}");
        Console.WriteLine($"Volumen: {volumen}");
    }
}