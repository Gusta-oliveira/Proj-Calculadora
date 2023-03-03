internal class Program
{
    private static void Main(string[] args)
    {
        float dig_um, dig_dois;
        Console.WriteLine("Informe primeiro digito: ");
        dig_um = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe segundo digito: ");
        dig_dois = float.Parse(Console.ReadLine());

        Console.WriteLine("Soma: " + dig_um + " + " + dig_dois + " = " + (dig_um + dig_dois));
        Console.WriteLine("Subtração: " + dig_um + " - " + dig_dois + " = " + (dig_um - dig_dois));
        Console.WriteLine("Multiplicação: " + dig_um + " * " + dig_dois + " = " + (dig_um * dig_dois));

        if (dig_dois == 0)
        {
            Console.WriteLine("Não existe divisão por ZERO!");
        }
        else
        {
            Console.WriteLine("Divisão: " + dig_um + " / " + dig_dois + " = " + (dig_um / dig_dois));
        }
        Console.ReadLine();
    }
}