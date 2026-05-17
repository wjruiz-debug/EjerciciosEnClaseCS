// 1. Inicialización
        string[] categorias = { "Ficción", "No Ficción", "Ciencia", "Infantil", "Historia" };
        int[] ventas = new int[5];
        int sumaTotal = 0;
        int indiceMayor = 0;

        Console.WriteLine("--- Registro de Ventas de Librería (Modo Seguro) ---");

        // 2. Captura de datos con validación
        for (int i = 0; i < ventas.Length; i++)
        {
            bool esValido = false;
            while (!esValido)
            {
                Console.Write($"Ingrese la cantidad vendida para {categorias[i]}: ");
                string entrada = Console.ReadLine()!;

                // Intentar convertir la entrada a entero
                esValido = int.TryParse(entrada, out ventas[i]);

                if (!esValido || ventas[i] < 0)
                {
                    Console.WriteLine(" Error: Por favor ingrese un número entero positivo.");
                    esValido = false; // Forzamos repetir si el número es negativo
                }
            }
            
            // Procesamiento de datos válidos
            sumaTotal += ventas[i];

            if (ventas[i] > ventas[indiceMayor])
            {
                indiceMayor = i;
            }
        }

        // 3. Cálculos y Salida
        double promedio = (double)sumaTotal / ventas.Length;

        Console.WriteLine("\n--- Resumen de Inventario ---");
        Console.WriteLine($"Total de libros vendidos: {sumaTotal}");
        Console.WriteLine($"Categoría con más ventas: {categorias[indiceMayor]} ({ventas[indiceMayor]} unidades)");
        Console.WriteLine($"Promedio de ventas: {promedio:N2}");
    