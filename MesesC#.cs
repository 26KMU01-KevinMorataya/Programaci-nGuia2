internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Meses");
        int opc;
        Console.WriteLine("Digite el numero del mes que quiera buscar");

        Console.WriteLine("Digite la Opcion");
        opc = Convert.ToInt32(Console.ReadLine());

        switch (opc)
        {
            case 1:
                Console.WriteLine("Mes: Enero Dias:31");
                break;
            case 2:
                Console.WriteLine("Mes: Febrero Dias:28");
                break;
            case 3:
                Console.WriteLine("Mes: Marzo Dias:31");
                break;
            case 4:
                Console.WriteLine("Mes: Abril Dias:30");
                break;
            case 5:
                Console.WriteLine("Mes: Mayo Dias:30");
                break;
            case 6:
                Console.WriteLine("Mes: Junio Dias:30");
                break;
            case 7:
                Console.WriteLine("Mes: Julio Dias:31");
                break;
            case 8:
                Console.WriteLine("Mes: Agosto Dias:31");
                break;
            case 9:
                Console.WriteLine("Mes: Septiembre Dias:30");
                break;
            case 10:
                Console.WriteLine("Mes: Octubre Dias:31");
                break;
            case 11:
                Console.WriteLine("Mes: Noviembre Dias:30");
                break;
            case 12:
                Console.WriteLine("Mes: Diciembre Dias:31");
                break;
            default:
                Console.WriteLine("No hay 13 meses solo hay 12 que te pasa?");
                break;
        }
        Console.WriteLine("Feliz año");
    }
}