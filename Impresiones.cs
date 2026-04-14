internal class Program
{
    static void Main()
    {
        int c, o;
        double precioU = 650;
        double iva = 0.12;
        double precioCIVA, totalSinDescuento, d = 0, totalPagar;

        Console.WriteLine("Ventas");

        Console.Write("Ingrese la cantidad: ");
        c = int.Parse(Console.ReadLine());

        Console.WriteLine("Forma de pago:");
        Console.WriteLine("1. Efectivo (10%)");
        Console.WriteLine("2. Tarjeta de crédito (5%)");
        Console.WriteLine("3. Vale de regalo (15%)");
        Console.Write("Seleccione una opción: ");
        o = int.Parse(Console.ReadLine());

        precioCIVA = precioU + (precioU * iva);

        totalSinDescuento = c * precioCIVA;
        string formaPago = "";

        switch (o)
        {
            case 1:
                d = totalSinDescuento * 0.10;
                formaPago = "Efectivo";
                break;
            case 2:
                d = totalSinDescuento * 0.05;
                formaPago = "Tarjeta de crédito";
                break;
            case 3:
                d = totalSinDescuento * 0.15;
                formaPago = "Vale de regalo";
                break;
            default:
                Console.WriteLine("Digite otra opcion");
                return;
        }

        totalPagar = totalSinDescuento - d;

        Console.WriteLine("\nDetalles");
        Console.WriteLine("Cantidad de impresoras: " + c);
        Console.WriteLine("Precio unitario con IVA: Q" + precioCIVA);
        Console.WriteLine("Total sin descuento: Q" + totalSinDescuento);
        Console.WriteLine("Forma de pago: " + formaPago);
        Console.WriteLine("Descuento: Q" + d);
        Console.WriteLine("Total a pagar: Q" + totalPagar);

        Console.ReadKey();
    }
}