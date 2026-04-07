internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Calculadora Basica");
        int opc;
        int num1;
        int num2;
        Console.WriteLine("1 - Suma.");
        Console.WriteLine("2 - Resta");
        Console.WriteLine("3 - Multiplicacion");
        Console.WriteLine("4 - Division");
        Console.WriteLine("Digite la Opcion");
        opc = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite un numero");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite el segundo numero");
        num2 = Convert.ToInt32(Console.ReadLine());

        switch (opc)
        {
            case 1:
                Console.WriteLine("La suma es " + (num1 + num2));
                break;
            case 2:
                Console.WriteLine("La resta es " + (num1 - num2));
                break;
            case 3:
                Console.WriteLine("La multiplicacion es " + (num1 * num2));
                break;
            case 4:
                Console.WriteLine("La division es " + (num1 / num2));
                break;
            default:
                Console.WriteLine("Digite un numero valido");
                break;
        }



        }
}