namespace Estagio.Ticket3;

/// <summary>
/// Classe base para os decoradores de armas.
/// Atua como "Decorator" no padrão estrutural Decorator.
/// </summary>
public abstract class ArmaDecorator(IArma arma) : IArma
{
    /// <summary>
    /// Arma que está sendo decorada.
    /// </summary>
    protected readonly IArma _arma = arma;

    /// <summary>
    /// Extende os campos de IArma para que os decoradores
    /// possam alterá-los.
    /// </summary>
    public virtual string Nome => _arma.Nome;
    public virtual string NomeBase => _arma.NomeBase;
    public virtual int Dano => _arma.Dano;
    public virtual int Mult => _arma.Mult;
    public virtual int Bonus => _arma.Bonus;
    public virtual string TipoDano => _arma.TipoDano;
}