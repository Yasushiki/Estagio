namespace Estagio.Ticket2.StatesTrabalho;

/// <summary>
/// Representa o estado em que o NPC é um Operador de Canhões.
/// Atua como um "Concrete State" do padrão.
/// </summary>
public class TrabalhoOperadorCanhao : ITrabalho
{
    /// <summary>
    /// Retorna o título da função do NPC.
    /// </summary>
    public string Funcao => "Operador de canhões";

    /// <summary>
    /// Retorna a ação do operador de canhões.
    /// </summary>
    public string Acao => "Mirando canhões nos inimigos...";
}