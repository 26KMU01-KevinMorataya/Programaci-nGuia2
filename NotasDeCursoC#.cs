internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Calculadora Basica");
        string opc;
        Console.WriteLine("A - Excelente.");
        Console.WriteLine("B - Bueno");
        Console.WriteLine("C - Regular");
        Console.WriteLine("D - Deficiente");
        Console.WriteLine("F - Reprobado");
        Console.WriteLine("Digite la Opcion");
        opc = Console.ReadLine();


        switch (opc)
        {
            case "A":
                Console.WriteLine("Tubo una calificación Excelente");
                break;
            case "B":
                Console.WriteLine("Tubo una calificaion Bueno");
                break;
            case "C":
                Console.WriteLine("Tubo una calificacion Regaluar");
                break;
            case "D":
                Console.WriteLine("Tubo una calificacion Deficiente");
                break;
            case "F":
                Console.WriteLine("Tubo una calificacion Reprobado");
                break;
            default:
                Console.WriteLine("Digite un numero valido");
                break;
        }
    }
}