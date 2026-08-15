namespace Estagio.Ticket3.Desarmados;

public class Desarmado : IArma
{
    public virtual string Nome => "Desarmado";
    public virtual string NomeBase => "Desarmado";
    public int Dano => 0;
    public int Mult => 1;
    public int Bonus => 0;
    public string TipoDano => "";
}