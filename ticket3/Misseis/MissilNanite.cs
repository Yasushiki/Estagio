namespace Estagio.Ticket3.Misseis;

public class MissilNanite(IArma missil) : ArmaDecorator(missil)
{
    public override string Nome => $"{_arma.Nome} de nanite";
    public override int Bonus => 300;
}