namespace Estagio.Ticket3.Lasers;

/// <summary>
/// Adiciona o efeito de "Duplo" para o laser,
/// aumentando o multiplicador de dano.
/// Atua como "Concrete Decorator" no padrão Decorator.
/// </summary>
public class LaserDuplo(IArma laser) : ArmaDecorator(laser)
{
    public override string Nome => $"{_arma.Nome} duplo";
    public override int Mult => 2;
}