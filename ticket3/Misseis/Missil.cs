namespace Estagio.Ticket3.Misseis;

public class Missil : IArma
{
    public virtual string Nome => "Míssil";
    public virtual string NomeBase => "Míssil";
    
    public int Dano => 20;
    public int Mult => 1;
    public int Bonus => 0;
    public string TipoDano => "Unitário";
}