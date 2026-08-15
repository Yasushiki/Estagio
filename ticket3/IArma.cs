namespace Estagio.Ticket3;

public interface IArma
{
    public string Nome { get; }
    public string NomeBase { get; }
    public int Dano { get; }
    public int Mult { get; }
    public int Bonus { get; }
    public string TipoDano { get; }
}