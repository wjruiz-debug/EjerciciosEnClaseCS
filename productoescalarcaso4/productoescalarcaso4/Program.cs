using System.Numerics;

int [] vectores1 = new int [5];
int [] vectores2 = new int [5];
int multiplicacionvectores = 0;
int productoescalar = 0;

Console.WriteLine("Ingrese los valores del primer vector: ");

try
{
    for (int i = 0; i < vectores1.Length; i++)
    {
        Console.WriteLine( $"valor: {i + 1}: ->multiplicacion: {multiplicacionvectores} ");
        vectores1 [i] = int.Parse(Console.ReadLine()!);
        multiplicacionvectores = vectores1 [i] * vectores2[i];
        productoescalar += multiplicacionvectores;
    }
}
catch (FormatException)
{
    Console.WriteLine("Error: Ingrese solo números enteros.");
    return;
}

Console.WriteLine("Ingrese los valores del segundo vector: ");

try
{
   for (int i = 0; i <vectores2.Length; i++)
   {
        Console.WriteLine( $"valor: {i + 1}: ->multiplicacion: {multiplicacionvectores} ");
        vectores2 [i] = int.Parse(Console.ReadLine()!);
        multiplicacionvectores = vectores2 [i] * vectores1[i];
        productoescalar += multiplicacionvectores;
   }
}
catch (FormatException)
{
    Console.WriteLine("Error: Ingrese solo números enteros.");
    return;
}

Console.WriteLine($"El resultado de la multiplicación escalar de los vectores es: {productoescalar}");