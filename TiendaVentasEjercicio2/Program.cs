string [] dias = {"lunes", "martes", "miercoles", "jueves", "viernes,", "sabado", "domingo"};
double []ventas = new double [7];
double totalventas = 0;
int diassuperioresa150 = 0;
double ventabaja = 0;

Console.WriteLine("Tienda en Linea: Resumen de ventas semanales: ");

for (int i = 0; i < dias.Length; i++)
{
    Console.Write($"Ingrese las ventas del dia {dias[i]}: ");
    while (!double.TryParse(Console.ReadLine(), out ventas[i]) || ventas[i] < 0)
    {
        Console.Write("Por favor, ingrese un monto válido: ");
    }
}

ventabaja = ventas [0];

foreach (double venta in ventas)
{
    totalventas += venta;
    {
        if (venta > 150 )
        {
            diassuperioresa150++;
        }
        if (venta < ventabaja)
        {
            ventabaja = venta;
        }
    }
}

Console.WriteLine("\nResumen de ventas de la semana: ");
Console.WriteLine($"Total de ventas: {totalventas:c}");
Console.WriteLine($"Dias que excedieron 150 de ganancias: {diassuperioresa150:c}");
Console.WriteLine($"Venta mas baja registrada: {ventabaja:c}");

Console.Write("\n Presione cualquier tecla para salir...");
Console.ReadKey();