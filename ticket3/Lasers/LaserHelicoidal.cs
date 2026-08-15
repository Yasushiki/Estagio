namespace Estagio.Ticket3.Lasers;

public class LaserHelicoidal(IArma laser) : ArmaDecorator(laser)
{
    public override string Nome => $"{_arma.Nome} helicoidal";
    public override int Bonus => 3;
    public override string TipoDano => $"{_arma.TipoDano}, em área";
}