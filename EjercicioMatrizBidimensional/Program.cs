double [,] matriz = new double [3,3];

Console.WriteLine("Temperaturas, con matrices bidimensionales.");
Console.WriteLine("Estimado usuario, por favor ingrese el valor de las temperaturas.");
int contadorTemperaturas = 1;
for (int i = 0; i<3; i++)
{
    for (int j = 0; j<3; j++)
    {
        Console.WriteLine($"Dime la temperatura #{contadorTemperaturas++}");

        try
        {
            matriz[i,j] = Convert.ToDouble(Console.ReadLine());
        }
        catch(FormatException)
        {
            Console.WriteLine("Formato Incompatible, por favor ingresa un valor valido.");
            contadorTemperaturas--;
            j--;
        }
    }
}

Console.Clear();
Console.WriteLine("Valores de temperaturas registradas");
for (int k = 0; k<3; k++)
{
    for (int l = 0; l<3; l++)
    {
        if (matriz[k,l]< 35) Console.ForegroundColor = ConsoleColor.Green;
        else if(matriz [k,l] >=35 && matriz[k,l] <= 39)  Console.ForegroundColor = ConsoleColor.Yellow;
        else Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"{matriz[k,l]}");
        Console.ResetColor();
    }
    Console.WriteLine();
}