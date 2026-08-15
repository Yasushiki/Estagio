namespace Estagio.Ticket2;

/// <summary>
/// Implementa o padrão comportamental State.
/// Atua como a "State Interface" do padrão.
/// Define a interface comum para todos os estados de
/// trabalho do NPC.
/// </summary>
public interface ITrabalho
{
    /// <summary>
    /// O nome da profissão atual.
    /// </summary>
    string Funcao { get; }

    /// <summary>
    /// A descrição do que o NPC faz na profissão atual.
    /// </summary>
    string Acao { get; }
}