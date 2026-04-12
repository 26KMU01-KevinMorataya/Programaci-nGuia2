internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Pollos Hermanos");
        int opc;
        Console.WriteLine("Bienvenido al menu de Pollos Hermanos");
        Console.WriteLine("1 - Hambuerguesa.");
        Console.WriteLine("2 - Pizza");
        Console.WriteLine("3 - Pollo Frito");
        Console.WriteLine("4 - Ensalada");
        Console.WriteLine("Digite la Opcion");
        opc = Convert.ToInt32(Console.ReadLine());

        switch (opc)
        {
            case 1:
                Console.WriteLine("Su hambuerguesa esta en Camino .....");
                break;
            case 2:
                Console.WriteLine("Su pizza esta en camino .....");
                break;
            case 3:
                Console.WriteLine("Su pollo frito esta en camino ....");
                break;
            case 4:
                Console.WriteLine("La ensalada esta en camino....");
                break;
            default:
                Console.WriteLine("Esta comida no esta en servicio por el momento");
                break;
        }
        Console.WriteLine("Gracias por su compra, vuelva pronto");  
    }
}