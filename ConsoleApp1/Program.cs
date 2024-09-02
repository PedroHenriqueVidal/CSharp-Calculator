using System.ComponentModel;
int operador;
do{ 
    Console.WriteLine("Escolha entre 1 - Somar, 2 - Subtrair, 3 - Multiplicar, 4 - Dividir, 5 - Resto, 6 - Potência e 0 - Sair");
    operador = int.Parse(Console.ReadLine());
    Console.WriteLine("Escolha o primeiro valor");
    double n1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Escolha o segundo valor");
    double n2 = double.Parse(Console.ReadLine());

    double resultado;
    switch (operador)
    {
        case 1:
            resultado = n1 + n2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            break;
        case 2:
            resultado = n1 - n2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
        break;
        case 3:
            resultado = n1 * n2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            break;
        case 4:
            if( n1 == 0 || n2 == 0)
            {
            Console.WriteLine("Divisão com zero é impossível");
            } 
            else
            {   
                resultado = n1 / n2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
        }
            break;
        case 5:
            if (n1 == 0 || n2 == 0)
            {
                Console.WriteLine("Divisão com zero é impossível");
            }
            else
            {
                resultado = n1 % n2;
                Console.WriteLine($"O resultado do resto da divisão é: {resultado}");
            }
            break;
        case 6:
            resultado = Math.Pow(n1, n2);
            Console.WriteLine($"O resultado da potenciação é: {resultado}");
            break;
        case 0:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida. Pressione Enter para tentar novamente.");
            Console.ReadLine();
            break;
    }
}while (operador != 0);
