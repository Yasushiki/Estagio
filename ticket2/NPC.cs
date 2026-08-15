using Estagio.Ticket2.StatesTrabalho;

namespace Estagio.Ticket2;

/// <summary>
/// Representa um NPC que pode mudar de profissão.
/// Atua como o "Context" do padrão comportamental State,
/// alterando o comportamento conforme o estado atual.
/// </summary>
class NPC
{
    /// <summary>
    /// Implementação do padrão estrutural Flyweight.
    /// Utiliza instâncias estáticas compartilhadas de cada
    /// estado entre todos os NPCs, economizando memória.
    /// </summary>
    private static readonly ITrabalho _trabalhoDesempregado = new TrabalhoDesempregado();
    private static readonly ITrabalho _trabalhoOperadorCanhao = new TrabalhoOperadorCanhao();
    private static readonly ITrabalho _trabalhoMecanicoMotor = new TrabalhoMecanicoMotor();
    
    /// <summary>
    /// Obtém o estado atual do trabalho do NPC.
    /// </summary>
    public ITrabalho TrabalhoAtual { get; private set; } = _trabalhoDesempregado;

    /// <summary>
    /// Altera o estado do NPC para Desempregado.
    /// </summary>
    public void VirarDesempregado()
    {
        TrabalhoAtual = _trabalhoDesempregado;
        Console.WriteLine($"Trabalho atual: {TrabalhoAtual.Funcao}");
    }

    /// <summary>
    /// Altera o estado do NPC para Operador de Canhão.
    /// </summary>
    public void VirarOperadorCanhao()
    {
        TrabalhoAtual = _trabalhoOperadorCanhao;
        Console.WriteLine($"Trabalho atual: {TrabalhoAtual.Funcao}");
    }

    /// <summary>
    /// Altera o estado do NPC para Mecânico do Motor.
    /// </summary>
    public void VirarMecanicoMotor()
    {
        TrabalhoAtual = _trabalhoMecanicoMotor;
        Console.WriteLine($"Trabalho atual: {TrabalhoAtual.Funcao}");
    }

    /// <summary>
    /// Executa a ação correspondente ao trabalho atual do NPC.
    /// O comportamento muda de acordo com o estado do trabalho.
    /// </summary>
    public void Trabalhar()
    {
        Console.WriteLine($"Trabalho atual: {TrabalhoAtual.Funcao}");
        Console.WriteLine($"{TrabalhoAtual.Acao}");
    }
}