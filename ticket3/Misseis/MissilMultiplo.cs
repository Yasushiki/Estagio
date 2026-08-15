namespace Estagio.Ticket3.Misseis;

/// <summary>
/// Adiciona o efeito de "Múltiplo" para o míssil,
/// aumentando o multiplicador de dano.
/// Atua como "Concrete Decorator" no padrão Decorator.
/// </summary>
public class MissilMultiplo(IArma missil) : ArmaDecorator(missil)
{
    public override string Nome => $"{_arma.Nome} múltiplo";
    public override int Mult => 5;
    public override string TipoDano => $"{_arma.TipoDano}, em área";
}