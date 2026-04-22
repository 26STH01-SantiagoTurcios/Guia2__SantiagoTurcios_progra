internal class Program
{
    private static void Main(string[] args)
    {
        const double precioUnit = 650;
        double precioIVA = precioUnit * 1.12;

        Console.WriteLine("=== VENTA DE IMPRESORAS T&S ===");
        Console.WriteLine($"Precio unitario sin IVA: Q{precioUnit:F2}");
        Console.WriteLine($"Precio unitario con IVA: Q{precioIVA:F2}");

        Console.Write("Cantidad de impresoras: ");
        if (!int.TryParse(Console.ReadLine(), out int cantidad))
        {
            Console.WriteLine("Error: cantidad inválida.");
            return;
        }

        Console.WriteLine("\nFormas de pago:");
        Console.WriteLine("1 - Efectivo (10%)");
        Console.WriteLine("2 - Tarjeta de crédito (5%)");
        Console.WriteLine("3 - Vale de regalo (15%)");
        Console.Write("Seleccione opción: ");

        if (!int.TryParse(Console.ReadLine(), out int pago))
        {
            Console.WriteLine("Error: opción inválida.");
            return;
        }

        double subtotal = precioIVA * cantidad;
        double descuento = 0;
        string nombrePago = "";

        switch (pago)
        {
            case 1:
                descuento = subtotal * 0.10;
                nombrePago = "Efectivo";
                break;

            case 2:
                descuento = subtotal * 0.05;
                nombrePago = "Tarjeta de crédito";
                break;

            case 3:
                descuento = subtotal * 0.15;
                nombrePago = "Vale de regalo";
                break;

            default:
                Console.WriteLine("Forma de pago inválida.");
                return;
        }

        double total = subtotal - descuento;

        Console.WriteLine("\n=== DETALLE DE COMPRA ===");
        Console.WriteLine($"Cantidad: {cantidad}");
        Console.WriteLine($"Precio unitario (IVA incluido): Q{precioIVA:F2}");
        Console.WriteLine($"Subtotal: Q{subtotal:F2}");
        Console.WriteLine($"Forma de pago: {nombrePago}");
        Console.WriteLine($"Descuento: Q{descuento:F2}");
        Console.WriteLine($"Total a pagar: Q{total:F2}");

        Console.WriteLine("\nPresione ENTER para salir...");
        Console.ReadLine();
    }
}