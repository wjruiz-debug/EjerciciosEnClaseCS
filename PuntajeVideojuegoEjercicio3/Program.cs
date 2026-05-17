int[] puntos = new int [6];
Console.WriteLine("Registro de puntuacion de videojuegos.");

for (int i = 0; i < puntos.Length; i++)
{
    Console.Write($"Ingrese el puntaje obtenido por el jugador.");

    while (!int.TryParse(Console.ReadLine(), out puntos [i]))
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero positivo.");
        Console.Write($"Ingrese el puntaje obtenido por el jugador.");
    }
}

int puntosmaximos = puntos.Max();
Console.WriteLine($"\n El puntaje maximo obtenido por el jugador es: {puntosmaximos}");

Array.Sort(puntos);
Console.WriteLine("\n Puntajes obtenidos, de forma ascendente: ");
foreach (int punto in puntos)
{
    Console.Write($"[{punto}] ");
}
Console.WriteLine();
 int puntosmayores500 = puntos.Count(p => p > 500);
 Console.WriteLine($"\n Partidas con mas de 500 puntos: {puntosmayores500}");

 Console.WriteLine("\n Presione cualquier tecla para salir.");
 Console.ReadKey();