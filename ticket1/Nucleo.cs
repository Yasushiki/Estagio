namespace Estagio.Ticket1;

/// <summary>
/// Representa o núcleo de energia do sistema.
/// Monitora os níveis de energia e define quando o
/// sistema entra em estado crítico.
/// </summary>
public class Nucleo
{
    /// <summary>
    /// Nível atual de energia do núcleo.
    /// </summary>
    public int Energia { get; private set; } = 100;

    /// <summary>
    /// Nível mínimo de energia do núcleo antes de entrar no estado crítico.
    /// </summary>
    private const int EnergiaCritica = 20;

    /// <summary>
    /// Flag que indica se o núcleo está em estado crítico.
    /// </summary>
    public bool EstadoCritico { get; private set; } = false;

    /// <summary>
    /// Remove uma quantidade específica de energia do núcleo.
    /// </summary>
    /// <param name="q">Quantidade de energia a ser removida.</param>
    public void PerderEnergia(int q)
    {
        Energia -= q;
        EstadoCritico = Energia <= EnergiaCritica;
    }

    /// <summary>
    /// Restaura uma quantidade específica de energia para o núcleo.
    /// </summary>
    /// <param name="q">Quantidade de energia a ser recuperada.</param>
    public void GanharEnergia(int q)
    {
        Energia += q;
        EstadoCritico = Energia <= EnergiaCritica;
    }
}