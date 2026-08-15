namespace Estagio.Ticket1;

/// <summary>
/// Representa o subsistema de escudos.
/// Reage ao estado crítico do sistema.
/// </summary>
public class Escudo
{
    /// <summary>
    /// Obtém o foco atual do escudo.
    /// </summary>
    public string Foco { get; private set; } = "Foco padrão";

    /// <summary>
    /// Altera o foco do escudo para defesa crítica.
    /// </summary>
    public void AtivarCritico()
    {
        Foco = "Foco Crítico!";
    }

    /// <summary>
    /// Altera o foco do escudo para defesa padrão.
    /// </summary>
    public void DesativarCritico()
    {
        Foco = "Foco padrão";
    }
}