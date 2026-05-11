using System.Numerics;

int [] vector1 = new int [5];
double sumacuadrados = 0;
double vectorcuadrado;
double magnitudvectores;

Console.WriteLine("Ingrese los elementos del vector: ");

try
{
    for (int i = 0; i<vector1.Length;i++)
    {
        vector1[i]= int.Parse(Console.ReadLine()!);
        vectorcuadrado =  Math.Pow(vector1[i],2);

        sumacuadrados += vectorcuadrado;

        Console.WriteLine($"Elemento {i +1 }: {vector1[i]} -> cuadrado: {vectorcuadrado} ");
    }

}
catch (FormatException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}

magnitudvectores = Math.Sqrt(sumacuadrados);
Console.WriteLine($"Magnitud del vector: {magnitudvectores}");

