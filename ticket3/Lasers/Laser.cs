namespace Estagio.Ticket3.Lasers;

public class Laser : IArma
{
    public virtual string Nome => "Laser";
    public virtual string NomeBase => "Laser";
    public int Dano => 5;
    public int Mult => 1;
    public int Bonus => 0;
    public string TipoDano => "Contínuo (por segundo)";
}