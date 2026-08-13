using Estagio.Ticket1;
using Estagio.Ticket2;

namespace Estagio;

/// <summary>
/// 
/// </summary>
internal class Program
{
    private static void Main()
    {
        int n = -1;

        while (n != 0)
        {
            Console.WriteLine("1 - Acessar ticket 1 - Sistema de Contingência do Núcleo da Nave");
            Console.WriteLine("2 - Acessar ticket 2 - Comportamento Dinâmico da Tripulação");
            Console.WriteLine("3 - Acessar ticket 3 - Armamento Modular e Modificadores Piratas");
            Console.WriteLine("0 - Sair do jogo");
            Console.Write("> ");

            if(int.TryParse(Console.ReadLine(), out n) && n >= 0 && n <= 3)
            {
                Console.WriteLine();

                switch (n)
                {
                    case 1:
                        Ticket1();
                        break;
                    case 2:
                        Ticket2();
                        break;
                    case 3:
                        break;
                    case 0:
                        break;
                }

                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("Você digitou um número inválido!\n");
            }
        }

    }

    private static void Ticket1()
    {
        // Iniciar as classes
        Nucleo nucleo = new();
        OrquestradorCritico orqCrit = new();
        Escudo escudo = new();
        Painel painel = new();
        Luz luz = new();

        int n = -1;

        while (n != 0)
        {
            Console.WriteLine($"Energia do núcleo: {nucleo.Energia}");
            orqCrit.AtivarEstadoCritico(nucleo.EstadoCritico, escudo, painel, luz);
            Console.WriteLine($"Foco do escudo: {escudo.Foco}");
            Console.WriteLine($"Avisos do painel: {painel.Alertas}");
            Console.WriteLine($"Estado da luz: {(luz.LuzLigada ? "Ligada" : "Desligada")}");

            Console.WriteLine("1 - Perder 10 de energia");
            Console.WriteLine("2 - Ganhar 10 de energia");
            Console.WriteLine("0 - Voltar para o menu");
            Console.Write("> ");

            if(int.TryParse(Console.ReadLine(), out n) && n >= 0 && n <= 2)
            {
                switch (n)
                {
                    case 1:
                        nucleo.PerderEnergia(10);
                        break;
                    case 2:
                        nucleo.GanharEnergia(10);
                        break;
                    case 0:
                        break;
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Você digitou um número inválido!\n");
            }
        }

    }

    private static void Ticket2()
    {
        NPC npc = new();

        int n = -1;

        while (n != 0)
        {
            Console.WriteLine("4 - Trabalhar");
            Console.WriteLine("1 - Mudar emprego para Desempregado");
            Console.WriteLine("2 - Mudar emprego para Operador de canhões");
            Console.WriteLine("3 - Mudar emprego para Mecânico do motor");
            Console.WriteLine("0 - Voltar para o menu");
            Console.Write("> ");

            if(int.TryParse(Console.ReadLine(), out n) && n >= 0 && n <= 4)
            {
                switch (n)
                {
                    case 1:
                        npc.VirarDesempregado();
                        break;
                    case 2:
                        npc.VirarOperadorCanhao();
                        break;
                    case 3:
                        npc.VirarMecanicoMotor();
                        break;
                    case 4:
                        npc.Trabalhar();
                        break;
                    case 0:
                        break;
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Você digitou um número inválido!\n");
            }
        }


    }
}