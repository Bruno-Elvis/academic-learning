using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        // Definição de variavéis
        static String op;
        static Double valor1, valor2, Resultado;

        static void Main(string[] args)
        {
            


            Console.WriteLine("||||| Calculadora sem OO |||||");
            while (true)
            {
                Console.WriteLine("Para sair do Aplicativo digite [S]:");
                op = Console.ReadLine();
                if (op.Equals("S") ||  op.Equals("s"))
                {
                    break;
                }

                Console.Write("Digite o Primeiro Número : ");
                valor1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o Segundo Número : ");
                valor2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Escolha a Operação [+] [-] [*] [/] ->");
                op = Console.ReadLine();

                switch (op)
                {
                    case "+": Resultado = valor1 + valor2;
                        Console.Clear();
                        Console.WriteLine("A soma é :{0}",Resultado);
                        break;
                    case "-":
                        Resultado = valor1 - valor2;
                        Console.Clear();
                        Console.WriteLine("A subtração é :{0}", Resultado);
                        break;
                    case "/":
                        Resultado = valor1 / valor2;
                        Console.Clear();
                        Console.WriteLine("A divisão é :{0}", Resultado);
                        break;
                    case "*":
                        Resultado = valor1 * valor2;
                        Console.Clear();
                        Console.WriteLine("A multiplicação é :{0}", Resultado);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Operação Inválida.");
                        break;
                }


            }

        }
    }
}
