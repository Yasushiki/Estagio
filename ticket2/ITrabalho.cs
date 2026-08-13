namespace Estagio.Ticket2;

/// <summary>
/// 
/// </summary>
public interface ITrabalho
{
    string Funcao { get; }
    string Acao { get; }
}

public class TrabalhoDesempregado : ITrabalho
{
    public string Funcao => "Desempregado";
    public string Acao => "";
}

public class TrabalhoOperadorCanhao : ITrabalho
{
    public string Funcao => "Operador de canhões";
    public string Acao => "Mirando canhões nos inimigos...";
}

public class TrabalhoMecanicoMotor : ITrabalho
{
    public string Funcao => "Mecânico do motor";
    public string Acao => "Apertando parafusos do motor...";
}