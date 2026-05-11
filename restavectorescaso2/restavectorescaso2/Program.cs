using System.Numerics;

int [] vector1 = new int [5];
int [] vector2 = new int [5];
int [] diferenciavector= new int[5];

Console.WriteLine("Ingrese los valores del primer vector: ");
for (int i = 0; i < vector1.Length; i++)
{
    try
    {
        Console.Write($"Elemento {i+1}: ");
        vector1[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.WriteLine("Entrada no valida, intente nuevamente.");
        return;
    }
}
    Console.WriteLine("Ingrese los valores del segundo vector: ");
    for (int i = 0; i < vector2.Length; i++)
    {
        try
        {
            Console.Write($"Elemento {i+1}: ");
            vector2[i] = int.Parse(Console.ReadLine()!);
        }
        catch(FormatException)
        {
            Console.WriteLine("Entrada no valida, intente nuevamente.");
            return; 
        }

}

    Console.WriteLine("La diferencia de los vectores, es de: ");
    for (int i= 0; i < diferenciavector.Length; i++)
    {
        diferenciavector[i] = vector1[i] - vector2[i];
    }
{
    for (int i = 0; i < diferenciavector.Length; i++)
    {
        Console.WriteLine($"Elemento {i+1}: {diferenciavector[i]}");
    }
}