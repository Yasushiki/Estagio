namespace Estagio.Ticket3.Misseis;

public class MissilMultiplo(IArma missil) : ArmaDecorator(missil)
{
    public override string Nome => $"{_arma.Nome} múltiplo";
    public override int Mult => 5;
    public override string TipoDano => $"{_arma.TipoDano}, em área";
}