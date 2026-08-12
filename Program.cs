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
        Escudo escudo = new Escudo();
        Painel painel = new Painel();
        Luz luz = new Luz();

        
        Console.WriteLine($"Energia do núcleo: {nucleo.Energia}");
        orqCrit.AtivarEstadoCritico(nucleo.EstadoCritico, escudo, painel, luz);
        Console.WriteLine($"Foco do escudo: {escudo.Foco}");
        Console.WriteLine($"Avisos do painel: {painel.Alertas}");
        Console.WriteLine($"Estado da luz: {(luz.LuzLigada ? "Ligada" : "Desligada")}");

        Console.WriteLine("\n");
        nucleo.PerderEnergia(10);
        
        Console.WriteLine($"Energia do núcleo: {nucleo.Energia}");
        orqCrit.AtivarEstadoCritico(nucleo.EstadoCritico, escudo, painel, luz);
        Console.WriteLine($"Foco do escudo: {escudo.Foco}");
        Console.WriteLine($"Avisos do painel: {painel.Alertas}");
        Console.WriteLine($"Estado da luz: {(luz.LuzLigada ? "Ligada" : "Desligada")}");

        Console.WriteLine("\n");
        nucleo.PerderEnergia(70);
        
        Console.WriteLine($"Energia do núcleo: {nucleo.Energia}");
        orqCrit.AtivarEstadoCritico(nucleo.EstadoCritico, escudo, painel, luz);
        Console.WriteLine($"Foco do escudo: {escudo.Foco}");
        Console.WriteLine($"Avisos do painel: {painel.Alertas}");
        Console.WriteLine($"Estado da luz: {(luz.LuzLigada ? "Ligada" : "Desligada")}");

        Console.WriteLine("\n");
        nucleo.GanharEnergia(10);
        
        Console.WriteLine($"Energia do núcleo: {nucleo.Energia}");
        orqCrit.AtivarEstadoCritico(nucleo.EstadoCritico, escudo, painel, luz);
        Console.WriteLine($"Foco do escudo: {escudo.Foco}");
        Console.WriteLine($"Avisos do painel: {painel.Alertas}");
        Console.WriteLine($"Estado da luz: {(luz.LuzLigada ? "Ligada" : "Desligada")}");

        
        
    }
}