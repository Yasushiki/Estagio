namespace Estagio.Ticket1;

/// <summary>
/// Representa o subsistema do painel.
/// Mostra mensagens de alerta durante o estado crítico.
/// </summary>
public class Painel
{
    /// <summary>
    /// Obtém os alertas atuais do painel.
    /// </summary>
    public string Alertas { get; private set; } = "";

    /// <summary>
    /// Mostra alertas críticos durante o estado crítico.
    /// </summary>
    public void AtivarCritico()
    {
        Alertas = "Alertas Críticos!";
    }

    /// <summary>
    /// Remove os alertas quando o estado crítico acaba.
    /// </summary>
    public void DesativarCritico()
    {
        Alertas = "";
    }
}