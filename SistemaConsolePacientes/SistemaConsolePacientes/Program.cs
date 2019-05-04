using System;
using System.Collections.Generic;

//      # TRABALHO AVALIATIVO DE CODIFICAÇÃO DE UM SISTEMA CONSOLE - 2º BIMESTRE/2019-1 - FACULDADE MULTIVIX #
//      # TURMA DE DEPENDÊNCIA DE SISTEMAS DE INFORMAÇÃO - ALUNO: BRUNO ELVIS Nº MATRICULA: 1429719 #

namespace SistemaConsolePacientes
{
    class Program
    {
        static List<Paciente> listaDePacientes = new List<Paciente>();

        static private int codFila = 0;

        public static void Main(string[] args)
        {
            Console.Title = "► SISTEMA DE CONTROLE DE PACIENTES ◄";

            char op = '0';
            while (!op.Equals('4'))
            {
                Console.Clear();
                Console.WriteLine("     + SISTEMA DE CONTROLE DE ATENDIMENTO A PACIENTES +");
                Console.WriteLine("***************************************************\n");
                Console.WriteLine("|     1 >> * CADASTRAR PACIENTE * |");
                Console.WriteLine("|     2 >> * LISTAR PACIENTES   * |");
                Console.WriteLine("|     3 >> * EXCLUIR PACIENTE   * |");
                Console.WriteLine("|     4 >> * SAIR               * |");
                Console.WriteLine("");
                Console.Write(" -> Digite sua opção: ");

                op = Console.ReadLine()[0];


                switch (op)
                {
                    case '1':
                        Cadastrar();
                        break;
                    case '2':
                        Listar();
                        break;
                    case '3':
                        Excluir();
                        break;
                    case '4':
                        Sair();
                        break;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine(" -> ESTA OPÇÃO NÃO EXISTE, TENTE NOVAMENTE !!!");
                        Console.ReadKey();
                        break;
                }
            }
        }


        private static void Cadastrar()
        {
            Paciente p = new Paciente();

            Console.Clear();

            Console.WriteLine("     +CADASTRO DE PACIENTES+");
            Console.WriteLine("*********************************\n");
            Console.Write(" Digite o Nome do Paciente: ");
            p.Nome = Console.ReadLine();

            Console.Write(" Digite a Idade do Paciente: ");
            p.Idade = Convert.ToInt32(Console.ReadLine());

            p.Cod_Chegada = codFila = ++codFila;

            //Forma manual de se atribuir o numero de chegada ao paciente.
            //Console.WriteLine(" Digite o Código de Chegada do Paciente: ");
            //p.Cod_Chegada = int.Parse(Console.ReadLine());

            listaDePacientes.Add(p);

            Console.WriteLine("\n\n");
            Console.WriteLine(" O PACIENTE NÚMERO: (" + p.Cod_Chegada.ToString() + ") COM NOME: (" + p.Nome.ToString() + ") E IDADE: (" + p.Idade.ToString() + ") ANOS, FOI ADICIONADO A FILA DE ATENDIMENTO COM SUCESSO !!!");
            Console.WriteLine("\n");
            Console.WriteLine(" Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }


        private static void Listar()
        {
            Console.Clear();

            Console.WriteLine("       +LISTA DE PACIENTES+");
            Console.WriteLine("*********************************\n");

            for (int i = 0; i < listaDePacientes.Count; i++)
            {
                Console.WriteLine("     Nome: {0}", listaDePacientes[i].Nome);
                Console.WriteLine("     Idade: {0}", listaDePacientes[i].Idade);
                Console.WriteLine("     Código de Chegada: {0}", listaDePacientes[i].Cod_Chegada);
                Console.WriteLine("*********************************");
            }

            Console.WriteLine("\n\n");
            Console.WriteLine(" Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }


        private static void Excluir()
        {
            Console.Clear();

            Console.WriteLine("       +EXCLUIR PACIENTES+");
            Console.WriteLine("*********************************\n");
            Console.Write(" Digite o Código de Chegada do paciente para Exclusão da fila de atendimento: ");
            
            int _cod_chegada = int.Parse(Console.ReadLine());

            for (int i = 0; i < listaDePacientes.Count; i++)
            {
                if (listaDePacientes[i].Cod_Chegada == _cod_chegada)
                {
                    listaDePacientes.Remove(listaDePacientes[i]);
                }
            }
            Console.WriteLine("\n\n");
            Console.WriteLine(" Paciente removido da fila com sucesso!");
            Console.WriteLine("\n");
            Console.WriteLine(" Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }


        private static void Sair()
        {
            Console.Clear();
            Console.WriteLine("*************************************************\n");
            Console.WriteLine("     # OBRIGADO POR UTILIZAR NOSSO SISTEMA #");
            Console.WriteLine("\n\n\n");
            Console.WriteLine(" Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
