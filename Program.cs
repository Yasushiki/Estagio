namespace Estagio;

/// <summary>
/// 
/// </summary>
internal class Program
{
    private static void Main()
    {
        // Iniciar as classes
        Nucleo nucleo = new Nucleo();
        OrquestradorCritico orqCrit = new OrquestradorCritico();
        
        Console.WriteLine($"Energia original: {nucleo.Energia}");
        if(nucleo.EstadoCritico)
        {
            orqCrit.IniciarEstadoCritico();
        }
        else
        {
            orqCrit.EncerrarEstadoCritico();
        }

        Console.WriteLine("\n");
        nucleo.PerderEnergia(10);
        
        Console.WriteLine($"Energia original: {nucleo.Energia}");
        if(nucleo.EstadoCritico)
        {
            orqCrit.IniciarEstadoCritico();
        }
        else
        {
            orqCrit.EncerrarEstadoCritico();
        }

        Console.WriteLine("\n");
        nucleo.PerderEnergia(70);
        
        Console.WriteLine($"Energia original: {nucleo.Energia}");
        if(nucleo.EstadoCritico)
        {
            orqCrit.IniciarEstadoCritico();
        }
        else
        {
            orqCrit.EncerrarEstadoCritico();
        }

        
    }
}