internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== ENTRADAS ESTADIO ===");
        Console.WriteLine("1 - Palco");
        Console.WriteLine("2 - Tribuna");
        Console.WriteLine("3 - Preferencia");
        Console.WriteLine("4 - Generales");

        Console.Write("Sector: ");
        if (!int.TryParse(Console.ReadLine(), out int sector))
        {
            Console.WriteLine("Error: ingrese un número válido.");
            return;
        }

        Console.Write("Cantidad de entradas: ");
        if (!int.TryParse(Console.ReadLine(), out int cantidad))
        {
            Console.WriteLine("Error: ingrese una cantidad válida.");
            return;
        }

        double precio = 0;
        string nombre = "";

        switch (sector)
        {
            case 1:
                precio = 300.00;
                nombre = "Palco";
                break;

            case 2:
                precio = 112.50;
                nombre = "Tribuna";
                break;

            case 3:
                precio = 62.50;
                nombre = "Preferencia";
                break;

            case 4:
                precio = 40.00;
                nombre = "Generales";
                break;

            default:
                Console.WriteLine("Sector no válido");
                return;
        }

        double total = precio * cantidad;

        Console.WriteLine($"\nSector: {nombre}");
        Console.WriteLine($"Precio por entrada: Q{precio:F2}");
        Console.WriteLine($"Entradas: {cantidad}");
        Console.WriteLine($"Total a pagar: Q{total:F2}");

        Console.WriteLine("\nPresione ENTER para salir...");
        Console.ReadLine();
    }
}