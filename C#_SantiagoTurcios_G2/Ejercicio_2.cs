

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese un caracter: ");
        char c = Console.ReadKey().KeyChar;
        Console.WriteLine();

        // Convertir a minúscula para simplificar la comparación
        char lower = char.ToLower(c);

        // Evaluar el tipo de caracter
        switch (lower)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("Es una VOCAL");
                break;

            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
                Console.WriteLine("Es un DIGITO");
                break;

            default:
                Console.WriteLine("No es vocal ni digito");
                break;
        }

        Console.WriteLine("\nPresione ENTER para salir...");
        Console.ReadLine();
    }
}
