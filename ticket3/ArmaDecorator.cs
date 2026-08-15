namespace Estagio.Ticket3;

public abstract class ArmaDecorator : IArma
{
    protected readonly IArma _arma;

    protected ArmaDecorator(IArma arma)
    {
        _arma = arma;
    }

    public virtual string Nome => _arma.Nome;
    public virtual string NomeBase => _arma.NomeBase;
    public virtual int Dano => _arma.Dano;
    public virtual int Mult => _arma.Mult;
    public virtual int Bonus => _arma.Bonus;
    public virtual string TipoDano => _arma.TipoDano;
}