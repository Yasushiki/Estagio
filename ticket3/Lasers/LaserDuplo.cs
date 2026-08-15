namespace Estagio.Ticket3.Lasers;

public class LaserDuplo(IArma laser) : ArmaDecorator(laser)
{
    public override string Nome => $"{_arma.Nome} duplo";
    public override int Mult => 2;
}