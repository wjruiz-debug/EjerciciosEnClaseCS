// 1. Inicialización de variables
        int[] notasEstudiantes = new int[8];
        int notasAprobadas = 0;
        int notasReprobadas = 0;
        int sumaNotas = 0;
        int notaAprobatoria = 60;

        Console.WriteLine("--- Aprobados, reprobados y promedio de notas estudiantiles ---");

        // 2. Captura de datos (Corregido a i = 0)
        for (int i = 0; i < notasEstudiantes.Length; i++)
        {
            bool esValido = false;
            while (!esValido)
            {
                Console.Write($"Ingrese la nota del estudiante {i + 1}: ");
                
                if (int.TryParse(Console.ReadLine(), out notasEstudiantes[i]) && 
                    notasEstudiantes[i] >= 0 && notasEstudiantes[i] <= 100)
                {
                    esValido = true;
                }
                else
                {
                    Console.WriteLine("Error: Valor inválido. Ingrese un número entre 0 y 100.");
                }
            }
            sumaNotas += notasEstudiantes[i];
        }

        // 3. Procesamiento y salida (Fuera del bucle for)
        Console.WriteLine("\n--- Notas Aprobadas ---");
        foreach (int nota in notasEstudiantes)
        {
            if (nota >= notaAprobatoria)
            {
                Console.WriteLine($"Nota: {nota}");
                notasAprobadas++;
            }
            else
            {
                notasReprobadas++;
            }
        }

        // 4. Cálculos finales y Resumen
        double promedioNotas = (double)sumaNotas / notasEstudiantes.Length;

        Console.WriteLine("\n--- Resumen de notas estudiantiles ---");
        Console.WriteLine($"Cantidad de notas aprobadas: {notasAprobadas}");
        Console.WriteLine($"Cantidad de notas reprobadas: {notasReprobadas}");
        Console.WriteLine($"Promedio de notas: {promedioNotas:N2}");