internal class Program
{
    private static void Main(string[] args)
    {
        int d;
        double n1, n2;
        Console.WriteLine("Ingrese el primer numero: ");
        n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero: ");
        n2 = double.Parse(Console.ReadLine());
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicacion");
        Console.WriteLine("4. Division");

        Console.WriteLine("Ingrese un numero: ");
        d = int.Parse(Console.ReadLine());
        switch (d)
        {
            case 1:
                Console.WriteLine("Suma");
                Console.WriteLine("El resultado es: " + (n1 + n2));
                break;
            case 2:
                Console.WriteLine("Resta");
                Console.WriteLine("El resultado es: " + (n1 - n2));
                break;
            case 3:
                Console.WriteLine("Multiplicacion");
                Console.WriteLine("El resultado es: " + (n1 * n2));
                break;
            case 4:
                Console.WriteLine("Division");
                if (n2 != 0)
                {
                    Console.WriteLine("El resultado es: " + (n1 / n2));
                }
                else
                {
                    Console.WriteLine("No se puede dividir por cero.");
                }
                break;
        }

    }
}