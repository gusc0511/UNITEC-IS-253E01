using System;
using Application253E01;

double ladoA = 5;
double ladoB = 5;
double ladoC = 5;
double alturaBase = 4; 
double ALTURA = 10; 

double perimetro = Figura253E01.Perimetro(ladoA, ladoB, ladoC);
double area = Figura253E01.Area(ladoA, alturaBase); // ladoA como base
double volumen = Figura253E01.Volumen(area, ALTURA);

Console.WriteLine($"El perímetro de la base de un Prisma Triangular de lados {ladoA}, {ladoB} y {ladoC} cm es {perimetro} cm");
Console.WriteLine($"El área de la base del triángulo (base={ladoA} cm, altura={alturaBase} cm) es {area} cm²");
Console.WriteLine($"El volumen del prisma triangular con base de área {area} cm² y altura {ALTURA} cm es {volumen} cm³");
