internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== CALCULADORA TRIG ===");

        Console.Write("Ángulo en grados: ");
        if (!double.TryParse(Console.ReadLine(), out double angulo))
        {
            Console.WriteLine("Error: ingrese un número válido.");
            return;
        }

        double rad = angulo * Math.PI / 180;

        Console.WriteLine("1 - Seno");
        Console.WriteLine("2 - Coseno");
        Console.WriteLine("3 - Tangente");
        Console.Write("Opción: ");

        if (!int.TryParse(Console.ReadLine(), out int op))
        {
            Console.WriteLine("Error: opción inválida.");
            return;
        }

        switch (op)
        {
            case 1:
                Console.WriteLine($"Sen({angulo}) = {Math.Sin(rad):F4}");
                break;

            case 2:
                Console.WriteLine($"Cos({angulo}) = {Math.Cos(rad):F4}");
                break;

            case 3:
                Console.WriteLine($"Tan({angulo}) = {Math.Tan(rad):F4}");
                break;

            default:
                Console.WriteLine("Opción no válida");
                break;
        }

        Console.WriteLine("\nPresione ENTER para salir...");
        Console.ReadLine();
    }
}