namespace Estagio.Ticket2;

/// <summary>
/// 
/// </summary>
class NPC
{
    private static readonly ITrabalho _trabalhoDesempregado = new TrabalhoDesempregado();
    private static readonly ITrabalho _trabalhoOperadorCanhao = new TrabalhoOperadorCanhao();
    private static readonly ITrabalho _trabalhoMecanicoMotor = new TrabalhoMecanicoMotor();
    
    public ITrabalho TrabalhoAtual { get; private set; } = _trabalhoDesempregado;

    public void VirarDesempregado()
    {
        TrabalhoAtual = _trabalhoDesempregado;
    }
    public void VirarOperadorCanhao()
    {
        TrabalhoAtual = _trabalhoOperadorCanhao;
    }

    public void VirarMecanicoMotor()
    {
        TrabalhoAtual = _trabalhoMecanicoMotor;
    }

    

    public void Trabalhar()
    {
        Console.WriteLine($"Trabalho atual: {TrabalhoAtual.Funcao}");
        Console.WriteLine($"{TrabalhoAtual.Acao}");
    }
}