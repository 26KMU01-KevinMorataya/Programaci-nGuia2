internal class Program
{
    private static void Main()
    {
        int s, c;
        double p = 0, total;

        Console.WriteLine("Entradas);
        Console.WriteLine("1. Palco (Q300)");
        Console.WriteLine("2. Tribuna (Q100 - Q125)");
        Console.WriteLine("3. Preferencia (Q50 - Q75)");
        Console.WriteLine("4. Generales (Q30 - Q50)");
        Console.Write("Seleccione el sector: ");
        s = int.Parse(Console.ReadLine());

        Console.Write("¿Cuantas entradas?");
        c = int.Parse(Console.ReadLine());

        switch (s)
        {
            case 1:
                p = 300;
                break;

            case 2:
                Console.Write("Ingrese el precio: ");
                p = double.Parse(Console.ReadLine());
                if (p < 100 || p > 125)
                {
                    Console.WriteLine("Precio no disponible");
                    return;
                }
                break;

            case 3:
                Console.Write("Ingrese el precio: ");
                p = double.Parse(Console.ReadLine());
                if (p < 50 || p > 75)
                {
                    Console.WriteLine("Precio no disponible");
                    return;
                }
                break;

            case 4:
                Console.Write("Ingrese el precio: ");
                p = double.Parse(Console.ReadLine());
                if (p < 30 || p > 50)
                {
                    Console.WriteLine("Precio no disponible");
                    return;
                }
                break;

            default:
                Console.WriteLine("Digite otra opcion");
                return;
        }

        total = p * c;

        Console.WriteLine("Detalles");
        Console.WriteLine("Cantidad de entradas: " + c);
        Console.WriteLine("Precio por entrada: Q" + p);
        Console.WriteLine("Total a pagar: Q" + total);

        Console.ReadKey();
    }
}