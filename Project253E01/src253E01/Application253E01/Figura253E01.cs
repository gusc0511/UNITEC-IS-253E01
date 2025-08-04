namespace Application253E01;

public class Figura253E01
{
    public static double Perimetro(double ladoA, double ladoB, double ladoC)
    {
        double perimetro = ladoA + ladoB + ladoC;
        return perimetro;
    }

    public static double Area(double @base, double altura)
    {
        double area = (@base * altura) / 2;
        return area;
    }

    public static double Volumen(double area, double ALTURA)
    {
        double volumen = area * ALTURA;
        return volumen;
    }
}
