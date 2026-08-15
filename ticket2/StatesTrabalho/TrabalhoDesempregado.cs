namespace Estagio.Ticket2.StatesTrabalho;

/// <summary>
/// Representa o estado em que o NPC está desempregado
/// e não possui nenhuma ação.
/// Atua como um "Concrete State" do padrão.
/// </summary>
public class TrabalhoDesempregado : ITrabalho
{
    /// <summary>
    /// Retorna o título da função do NPC.
    /// </summary>
    public string Funcao => "Desempregado";

    /// <summary>
    /// Retorna a ação executada pelo NPC.
    /// Como está sem trabalho, ele não possui ação.
    /// </summary>
    public string Acao => "";
}