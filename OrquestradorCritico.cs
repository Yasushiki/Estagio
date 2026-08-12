namespace Estagio;

public class OrquestradorCritico
{
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