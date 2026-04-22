internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== CONVERSOR LONGITUD ===");
        Console.WriteLine("1 - Metros");
        Console.WriteLine("2 - Pies");
        Console.WriteLine("3 - Centímetros");
        Console.WriteLine("4 - Pulgadas");

        Console.Write("Unidad origen: ");
        if (!int.TryParse(Console.ReadLine(), out int origen))
        {
            Console.WriteLine("Error: ingrese un número válido.");
            return;
        }

        Console.Write("Valor: ");
        if (!double.TryParse(Console.ReadLine(), out double valor))
        {
            Console.WriteLine("Error: ingrese un valor numérico válido.");
            return;
        }

        Console.Write("Unidad destino: ");
        if (!int.TryParse(Console.ReadLine(), out int destino))
        {
            Console.WriteLine("Error: ingrese un número válido.");
            return;
        }

        // Convertir a metros
        double metros = origen switch
        {
            1 => valor,
            2 => valor * 0.3048,
            3 => valor / 100,
            4 => valor * 0.0254,
            _ => -1
        };

        if (metros < 0)
        {
            Console.WriteLine("Unidad de origen inválida.");
            return;
        }

        // Convertir desde metros a destino
        (double res, string unidad) = destino switch
        {
            1 => (metros, "metros"),
            2 => (metros / 0.3048, "pies"),
            3 => (metros * 100, "cm"),
            4 => (metros / 0.0254, "pulgadas"),
            _ => (-1, "")
        };

        if (res < 0)
        {
            Console.WriteLine("Unidad de destino inválida.");
            return;
        }

        Console.WriteLine($"\nResultado: {res:F4} {unidad}");

        Console.WriteLine("\nPresione ENTER para salir...");
        Console.ReadLine();
    }
}