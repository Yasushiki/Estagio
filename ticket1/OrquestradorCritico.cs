namespace Estagio.Ticket1;

/// <summary>
/// Implementa o padrão estrutural Facade.
/// Centraliza e unifica a interface de comunicação com
/// os subsistemas para simplificar a ativação do modo crítico.
/// </summary>
public class OrquestradorCritico
{
    /// <summary>
    /// Coordena a ativação e desativação do estado de emergência
    /// em todos os subsistemas dependentes.
    /// </summary>
    /// <param name="flag">true = ativa o estado crítico, false = desativa o estado crítico.</param>
    /// <param name="escudo">Instância do subsistema de escudos.</param>
    /// <param name="painel">Instância do subsistema do painel.</param>
    /// <param name="luz">Instância do subsistema de luz.</param>
    public void AtivarEstadoCritico(bool flag, Escudo escudo, Painel painel, Luz luz)
    {
        if(flag)
        {
            escudo.AtivarCritico();
            painel.AtivarCritico();
            luz.AtivarCritico();
            Console.WriteLine("Modo crítico ativado!");
        }
        else
        {
            escudo.DesativarCritico();
            painel.DesativarCritico();
            luz.DesativarCritico();
        }
    }
}