using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios03
{
    class Program
    {
        static List<Evento> ListaEvento = new List<Evento>();
        static void Main(string[] args)
        {
            Console.Title = "Gerenciador de Eventos";
            char op;
            do
            {
                Console.Clear();
                Console.WriteLine(" -SISTEMA DE EVENTOS- ");
                Console.WriteLine("1 - CADASTRAR EVENTO");
                Console.WriteLine("2 - EDITAR EVENTO");
                Console.WriteLine("3 - LISTAR EVENTOS");
                Console.WriteLine("4 - EXCLUIR EVENTO");
                Console.WriteLine("5 - SAIR DO PROGRAMA");
                Console.Write("Digite sua opção:");
                op = Convert.ToChar(Console.ReadLine());

                if (op.Equals('5'))
                {
                    Console.WriteLine("\n\n");
                    Console.WriteLine("OK entao, Bye!");
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Pressione qualquer tecla para sair...");
                    Console.ReadKey();
                    break;
                }

                switch (op)
                {
                    case '1':
                        Cadastrar();
                        break;
                    case '2':
                        Editar();
                        break;
                    case '3':
                        Listar();
                        break;
                    case '4':
                        Excluir();
                        break;
                    default:
                        Console.WriteLine("Opção invalida!");
                        Console.ReadKey();
                        break;
                }
            } while (true);

        }

        private static void Cadastrar()
        {
            Evento evento = new Evento();
            Console.Clear();
            Console.WriteLine("CADASTRO DE EVENTO:");
            Console.WriteLine("\n");
            Console.Write("Titulo Evento: ");
            evento.Titulo = Console.ReadLine();
            Console.Write("Data Evento: ");
            evento.Data = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Hora inicio: ");
            evento.HoraInicio = TimeSpan.Parse(Console.ReadLine());
            Console.Write("Hora Termino: ");
            evento.HoraFim = TimeSpan.Parse(Console.ReadLine());
            Console.Write("Descrição Evento: ");
            evento.Descricao = Console.ReadLine();
            evento.Id = ListaEvento.Count + 1;

            ListaEvento.Add(evento);

            Console.WriteLine("\n\n");
            Console.WriteLine("Evento cadastrado com Sucesso!");
            Console.WriteLine("\n\n");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();

        }
        private static void Editar()
        {
            Evento evento = new Evento();
            Console.Clear();
            Console.WriteLine("EDITAR EVENTO:");
            Console.WriteLine("\n");
            Console.WriteLine("Digite o Código do evento: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            if (ListaEvento.Count > 0)
            {
                for (int i = 0; i < ListaEvento.Count; i++)
                {
                    if (ListaEvento[i].Id == codigo)
                    {
                        Console.Write("Titulo Evento: ");
                        evento.Titulo = Console.ReadLine();
                        Console.Write("Data Evento: ");
                        evento.Data = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Hora inicio: ");
                        evento.HoraInicio = TimeSpan.Parse(Console.ReadLine());
                        Console.Write("Hora Termino: ");
                        evento.HoraFim = TimeSpan.Parse(Console.ReadLine());
                        Console.Write("Descrição Evento: ");
                        evento.Descricao = Console.ReadLine();
                        evento.Id = ListaEvento[i].Id;

                        ListaEvento[i] = evento;

                        Console.WriteLine("\n\n");
                        Console.WriteLine("Evento alterado com Sucesso!");
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Pressione qualquer tecla para sair...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Código inexistente!");
                        Console.WriteLine("Pressione qualquer tecla para sair...");
                        Console.ReadKey();
                    }
                }
            }
            else
            {
                Console.WriteLine("Não exite nenhum evento cadastrado para ser alterado!");
                Console.WriteLine("Pressione qualquer tecla para sair...");
                Console.ReadKey();
            }

        }
        private static void Listar()
        {
            Console.Clear();
            Console.WriteLine("LISTA DE EVENTOS:");
            Console.WriteLine("\n");
            Console.WriteLine("[1] - LISTAR TODOS OS EVENTOS, [2] - FILTRAR EVENTOS POR DATA");
            Console.Write("Digite a opção: ");
            char op = Convert.ToChar(Console.ReadLine());
            Console.Write("\n");

            if (ListaEvento.Count > 0)
            {
                switch (op)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine("LISTA DE TODOS OS EVENTOS: ");
                        Console.WriteLine("________________________________________________");
                        for (int i = 0; i < ListaEvento.Count; i++)
                        {
                            Console.WriteLine("CÓDIGO DO EVENTO: " + ListaEvento[i].Id);
                            Console.WriteLine("TÍTULO DO EVENTO: " + ListaEvento[i].Titulo);
                            Console.WriteLine("DATA DO EVENTO: " + ListaEvento[i].Data.ToShortDateString());
                            Console.WriteLine("HORARIO DE INICIO: " + ListaEvento[i].HoraInicio);
                            Console.WriteLine("HORARIO FIM: " + ListaEvento[i].HoraFim);
                            Console.WriteLine("DESCRIÇÃO: " + ListaEvento[i].Descricao);
                            Console.WriteLine("________________________________________________");
                        }
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Pressione qualquer tecla para sair...");
                        Console.ReadKey();
                        break;
                    case '2':
                        Console.Write("Data de: ");
                        DateTime dataDe = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Data ate: ");
                        DateTime dataAte = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("\n");
                        Console.WriteLine("Lista de eventos de {0} até {1}.", dataDe.ToShortDateString(), dataAte.ToShortDateString());
                        Console.WriteLine("________________________________________________");
                        List<Evento> lstfiltro = ListaEvento.Where(x => x.Data >= dataDe && x.Data <= dataAte).ToList();

                        if (lstfiltro.Count > 0)
                        {
                            for (int i = 0; i < lstfiltro.Count; i++)
                            {
                                Console.WriteLine("CÓDIGO DO EVENTO: " + lstfiltro[i].Id);
                                Console.WriteLine("TÍTULO DO EVENTO: " + lstfiltro[i].Titulo);
                                Console.WriteLine("DATA DO EVENTO: " + lstfiltro[i].Data.ToShortDateString());
                                Console.WriteLine("HORARIO DE INICIO: " + lstfiltro[i].HoraInicio);
                                Console.WriteLine("HORARIO FIM: " + lstfiltro[i].HoraFim);
                                Console.WriteLine("DESCRIÇÃO: " + lstfiltro[i].Descricao);
                                Console.WriteLine("________________________________________________");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Nenhum evento encontrado dentro do tempo indicado!");
                        }

                        Console.WriteLine("\n\n");
                        Console.WriteLine("Pressione qualquer tecla para sair...");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }

            }
            else
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("Nenhum evento cadastrado!");
                Console.WriteLine("\n\n");
                Console.WriteLine("Pressione qualquer tecla para sair...");
                Console.ReadKey();
            }


        }
        private static void Excluir()
        {
            Console.Clear();
            Evento evento = new Evento();
            Console.Clear();
            Console.WriteLine("EXCLUIR EVENTO:");
            Console.WriteLine("\n");
            Console.WriteLine("Digite o Código do evento: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < ListaEvento.Count; i++)
            {
                if (ListaEvento[i].Id == codigo)
                {
                    ListaEvento.Remove(ListaEvento[i]);
                }
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("Evento excluido com Sucesso!");
            Console.WriteLine("\n\n");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
