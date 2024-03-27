using System;
using System.Globalization;

namespace MyCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // principais operações = soma, subtração, divisão, multiplicação

            char operatorSum = '+';
            char operatorSub = '-';
            char operatorDiv = '/';
            char operatorMulti = '*';

            int count = 0;

            char inputOperator;
            double number;

            Console.WriteLine("Coloque a conta que você deseja realizar abaixo(com espaço separando operadores e números)");
            string[] input = Console.ReadLine().Split(' ');

            string inputLast = input[input.Length - 1];
            //-->  - 1 pois aqui é indice e o tamanho vem normal

            //resultado deve começar com o primeiro número colocado
            double result = double.Parse(input[0], CultureInfo.InvariantCulture);

            //quantas vezes o for deve ser executado
            int executionTimes = input.Length / 2;
            //isso porque a cada execução testarei dois números por isso a execução tem a metade do tamanho --> / 2;

            //teste se o último input é diferente de "=" e executa normalmente se for True
            if (inputLast != "=")  
            {
                for (int i = 0; i < executionTimes; i++)
                {
                    inputOperator = char.Parse(input[1 + count]);
                    number = double.Parse(input[2 + count], CultureInfo.InvariantCulture);

                    if (inputOperator == operatorSum)
                    {
                        result += number;
                    }
                    if (inputOperator == operatorSub)
                    {
                        result -= number;
                    }
                    if (inputOperator == operatorDiv)
                    {
                        result /= number;
                    }
                    if (inputOperator == operatorMulti)
                    {
                        result *= number;
                    }
                    count += 2;
                }
            }
            else //executa se a última coisa no input é um sinal de igual
            {
                executionTimes -= 1;
                //tiro 1 porque existe um sinal de igual no final que eu não quero executar, ou seja -->  - 1

                for (int i = 0; i < executionTimes; i++)
                {
                    inputOperator = char.Parse(input[1 + count]);
                    number = double.Parse(input[2 + count], CultureInfo.InvariantCulture);

                    if (inputOperator == operatorSum)
                    {
                        result += number;
                    }
                    if (inputOperator == operatorSub)
                    {
                        result -= number;
                    }
                    if (inputOperator == operatorDiv)
                    {
                        result /= number;
                    }
                    if (inputOperator == operatorMulti)
                    {
                        result *= number;
                    }
                    count += 2;
                }
            }
            Console.WriteLine(result.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Aperte enter para sair.");
            string end = Console.ReadLine();
        }
    }
}
