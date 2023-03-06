namespace Calculadora
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double num1 = 0, num2 = 0;
            int op = 0;

            int Menu()
            {
                Console.Clear();
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");
                op = int.Parse(Console.ReadLine());

                return op;
            }

            double Soma()
            {
                double soma;
                soma = num1 + num2;
                return soma;
            }
            double Subtracao()
            {
                double sub;
                sub = num1 - num2;
                return sub;
            }
            double Mult()
            {
                double mult;
                mult = num1 * num2;
                return mult;
            }
            double Divisao()
            {
                double div = 0;
                div = num1 / num2;

                return div;
            }

            while (op != 5)
            {
                Menu();
                Console.Clear();
                if (op != 5)
                {      
                    Console.Write("Informe o primeiro número: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Informe o segundo número: ");
                    num2 = double.Parse(Console.ReadLine());
                }
                
                switch (op)
                {

                    default:
                        Console.WriteLine("Opção inválida!!");
                        Console.ReadLine();
                        break;
                    case 1:
                        Console.WriteLine($"A soma dos números é: {Soma()}");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine($"A subtração dos números é: {Subtracao()}");
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine($"A multiplicação dos números é: {Mult()}");
                        Console.ReadLine();
                        break;

                    case 4:
                        if(num2 != 0){
                            Console.WriteLine($"A divisão dos números é: {Divisao()}");
                            Console.ReadLine();
                        }
                        else {
                            Console.WriteLine("Imposivel divisão por ZERO!");
                            Console.ReadLine();
                        }
                        break;

                    case 5:
                        Console.WriteLine($"Opção sair selecionada");
                        Console.ReadLine();
                        break;

                }
            }
        }
    }
}