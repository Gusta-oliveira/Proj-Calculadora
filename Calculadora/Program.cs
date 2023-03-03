double num1, num2;
int op = 0;
void Menu()
{
    Console.Clear();
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção:  ");
    op = int.Parse(Console.ReadLine());
    switch (op)
    {

        default:
            Console.WriteLine("Opção inválida!!");
            Console.ReadLine();
            break;
        case 1: 
            Console.WriteLine($"A soma dos números é: {num1 + num2}");
            Console.ReadLine();
            break;
        case 2:
            Console.WriteLine($"A subtração dos números é: {num1 - num2}");
            Console.ReadLine();
            break;

        case 3:
            Console.WriteLine($"A multiplicação dos números é: {num1 * num2}");
            Console.ReadLine();
            break;

        case 4:
            Console.WriteLine($"A divisão dos números é: {num1 / num2}");
            Console.ReadLine();
            break;

        case 5:
            Console.WriteLine($"Opção sair selecionada");
            Console.ReadLine();
            break;


    }
}

Console.Write("Informe o primeiro número: ");
num1 = double.Parse(Console.ReadLine());
Console.Write("Informe o segundo número: ");
num2 = double.Parse(Console.ReadLine());


while(op != 5)
{
    Menu();
}