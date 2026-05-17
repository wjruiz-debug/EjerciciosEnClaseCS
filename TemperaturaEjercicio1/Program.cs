try
        {
            double[] temperaturas = new double[7];
            double suma = 0;

            Console.WriteLine("--- Registro de Temperaturas (Modo Seguro) ---");

            for (int i = 0; i < temperaturas.Length; i++)
            {
                bool entradaValida = false;

                while (!entradaValida)
                {
                    Console.Write($"Día {i + 1} - Ingrese la temperatura: ");
                    string entrada = Console.ReadLine()!;

                    // Intentamos convertir la entrada a double
                    if (double.TryParse(entrada, out double tempValida))
                    {
                        temperaturas[i] = tempValida;
                        suma += tempValida;
                        entradaValida = true; // Salimos del while
                    }
                    else
                    {
                        Console.WriteLine("¡Error! Por favor, ingrese un número válido.");
                    }
                }
            }

            // Cálculos
            double promedio = suma / temperaturas.Length;

            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"Promedio: {promedio:F2}°C");
            Console.WriteLine($"Máxima: {temperaturas.Max()}°C");
            Console.WriteLine($"Mínima: {temperaturas.Min()}°C");
        }
        catch (Exception ex)
        {
            // Captura errores críticos no previstos
            Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("\nProceso finalizado.");
        }