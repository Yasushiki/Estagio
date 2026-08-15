namespace Estagio.Ticket3.Desarmados;

/// <summary>
/// Atua como "Concrete State" no padrão State, alterando
/// o comportamento da nave.
/// Não pode ser decorado.
/// </summary>
public class Desarmado : IArma
{
    public virtual string Nome => "Desarmado";
    public virtual string NomeBase => "Desarmado";
    public int Dano => 0;
    public int Mult => 1;
    public int Bonus => 0;
    public string TipoDano => "";
}