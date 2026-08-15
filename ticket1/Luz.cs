namespace Estagio.Ticket1;

/// <summary>
/// Representa o subsistema de iluminação.
/// Reage ao estado crítico do sistema, apagando
/// as luzes para poupar energia.
/// </summary>
public class Luz
{
    /// <summary>
    /// Flag que indica se a luz está ligada ou desligada.
    /// </summary>
    public bool LuzLigada { get; private set; } = true;

    /// <summary>
    /// Desliga a luz quando o estado crítico é ativado.
    /// </summary>
    public void AtivarCritico()
    {
        LuzLigada = false;
    }

    /// <summary>
    /// Liga a luz quando o estado crítico é desativado.
    /// </summary>
    public void DesativarCritico()
    {
        LuzLigada = true;
    }   
}