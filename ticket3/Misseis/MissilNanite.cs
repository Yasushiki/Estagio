namespace Estagio.Ticket3.Misseis;

/// <summary>
/// Adiciona o efeito de "Nanite" para o míssil,
/// dando aumento bônus no dano base.
/// Atua como "Concrete Decorator" no padrão Decorator.
/// </summary>
public class MissilNanite(IArma missil) : ArmaDecorator(missil)
{
    public override string Nome => $"{_arma.Nome} de nanite";
    public override int Bonus => 300;
}