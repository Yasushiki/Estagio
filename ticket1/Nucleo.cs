namespace Estagio.Ticket1;

/// <summary>
/// 
/// </summary>
public class Nucleo
{
    public int Energia { get; private set; } = 100;
    private const int EnergiaCritica = 20;

    public bool EstadoCritico { get; set; } = false;

    
    public void PerderEnergia(int q)
    {
        Energia -= q;
        EstadoCritico = Energia <= EnergiaCritica;
    }

    public void GanharEnergia(int q)
    {
        Energia += q;
        EstadoCritico = Energia <= EnergiaCritica;
    }

    

}