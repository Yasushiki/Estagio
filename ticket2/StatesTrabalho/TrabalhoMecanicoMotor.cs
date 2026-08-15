namespace Estagio.Ticket2.StatesTrabalho;

/// <summary>
/// Representa o estado em que o NPC é um Operador de Canhões.
/// Atua como um "Concrete State" do padrão.
/// </summary>
public class TrabalhoMecanicoMotor : ITrabalho
{
    /// <summary>
    /// Retorna o título da função do NPC.
    /// </summary>
    public string Funcao => "Mecânico do motor";

    /// <summary>
    /// Retorna a ação do mecânico do motor.
    /// </summary>
    public string Acao => "Apertando parafusos do motor...";
}