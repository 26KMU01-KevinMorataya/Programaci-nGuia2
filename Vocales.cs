internal class Program
{
    private static void Main()
    {
        char c;

        Console.Write("Ingrese un caracter: ");
        c = Convert.ToChar(Console.ReadLine());

        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
            c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
        {
            Console.WriteLine("Vocal");
        }
        else if (c >= '0' && c <= '9')
        {
            Console.WriteLine("Digito");
        }
        else
        {
            Console.WriteLine("No es vocal ni digito");
        }

        Console.ReadKey();
    }
}