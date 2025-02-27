using System.Data;
using System.Diagnostics.Metrics;
using System.Runtime.Serialization;

namespace Calculadora_simples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1, num2, opcao, soma, divisao, multiplicacao, subtracao;

            Console.WriteLine("Olá, estamos aqui para te ajudar com as 4 opreções matemáticas simples. :D ");
            Console.WriteLine("Por favor, digite o primeiro número da operação: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor, digite o segundo número da operação: ");
            num2 = int.Parse(Console.ReadLine());

            soma = num1 + num2;
            subtracao = num1 - num2;
            multiplicacao = num1 * num2;
            divisao = num1 / num2;


            Console.WriteLine("Qual operação deseja realizar?");
            Console.WriteLine(" 1 - Soma \n 2 - Subtração \n 3 - Multiplicação \n 4 - Divião:");
            opcao = int.Parse(Console.ReadLine());


            switch (opcao)
            {
                case 1:
                    Console.WriteLine($"A soma dos números digitados é {soma}");
                    break;

                case 2:
                    Console.WriteLine($"A subtração dos números digitados é {subtracao}");
                    break;

                case 3:
                    Console.WriteLine($"A multiplicação dos números digitados é {multiplicacao}");
                    break;
                case 4:
                    Console.WriteLine($"A divisão dos números digitados é {divisao}");
                    break;
            }





            }
    }
}
