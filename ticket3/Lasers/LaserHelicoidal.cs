namespace Estagio.Ticket3.Lasers;

/// <summary>
/// Adiciona o efeito de "Helicoidal" para o laser,
/// dando aumento bônus no dano base.
/// Atua como "Concrete Decorator" no padrão Decorator.
/// </summary>
public class LaserHelicoidal(IArma laser) : ArmaDecorator(laser)
{
    public override string Nome => $"{_arma.Nome} helicoidal";
    public override int Bonus => 3;
    public override string TipoDano => $"{_arma.TipoDano}, em área";
}