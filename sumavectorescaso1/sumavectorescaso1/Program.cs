int[] vectores1 = new int[5];
int[] vectores2 = new int[5];
int[] sumaVector = new int[5];

Console.WriteLine("Ingrese los elementos del primer vector:");
for (int i = 0; i < vectores1.Length; i++)
{
    try
    {
        Console.Write($"Elemento {i + 1}: ");
        vectores1[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
       
        Console.ResetColor();
    }
}

Console.WriteLine("Ingrese los elementos del segundo vector:");
for (int i = 0; i < vectores2.Length; i++)
{
    try
    {
        Console.Write($"Elemento {i + 1}: ");
        vectores2[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
       
        Console.ResetColor();
    }
}

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("La suma de los vectores es:");

for (int i = 0; i < sumaVector.Length; i++)
{
    sumaVector[i] = vectores1[i] + vectores2[i];
}
Console.ResetColor();

for (int i = 0; i < sumaVector.Length; i++)
{
    Console.WriteLine($"Elemento {i + 1}: {sumaVector[i]}");
}