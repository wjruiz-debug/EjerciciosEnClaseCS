//Leer un numero entero y mostrarl el cuadrado de sus antecesores.

using System;

int Numero;

while (true)
{
    Console.Write("Ingrese un numero entero:");
    if (int.TryParse(Console.ReadLine(), out Numero))
    {
        break ;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no valida. Por favor, ingrese un numero entero.");
        Console.ResetColor();
    }
}

Console.WriteLine($"Mostrando el cuadrado de los antecesores de " + Numero + ":");
int cont = 1;
while (cont < Numero)
{
    Console.WriteLine("El cuadrado de  " + cont + " es: " + Math.Pow(cont, 2));
    cont++;
}