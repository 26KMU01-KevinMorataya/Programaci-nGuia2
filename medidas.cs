internal class Program
{
    private static void Main()
    {
        int origen, destino;
        double valor, metros = 0, resultado = 0;

        Console.WriteLine("Conversor");
        Console.WriteLine("1. Metros");
        Console.WriteLine("2. Pies");
        Console.WriteLine("3. Centimetros");
        Console.WriteLine("4. Pulgadas");

        Console.Write("Seleccione la unidad de origen: ");
        origen = int.Parse(Console.ReadLine());

        Console.Write("Seleccione la unidad de destino: ");
        destino = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor: ");
        valor = double.Parse(Console.ReadLine());

        switch (origen)
        {
            case 1:
                metros = valor;
                break;
            case 2:
                metros = valor * 0.3048;
                break;
            case 3:
                metros = valor / 100;
                break;
            case 4:
                metros = valor * 0.0254;
                break;
            default:
                Console.WriteLine("Unidad no valida");
                return;
        }

        switch (destino)
        {
            case 1:
                resultado = metros;
                break;
            case 2:
                resultado = metros / 0.3048;
                break;
            case 3:
                resultado = metros * 100;
                break;
            case 4:
                resultado = metros / 0.0254;
                break;
            default:
                Console.WriteLine("Unidad no valida");
                return;
        }

        Console.WriteLine("\nResultado: " + resultado);
        Console.ReadKey();
    }
}