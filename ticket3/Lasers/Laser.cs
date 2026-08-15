namespace Estagio.Ticket3.Lasers;

/// <summary>
/// Atua como "Concrete State" no padrão State, alterando
/// o comportamento da nave.
/// Atua como "Concrete Component" no padrão Decorator,
/// podendo ser encapsulado.
/// </summary>
public class Laser : IArma
{
    public virtual string Nome => "Laser";
    public virtual string NomeBase => "Laser";
    public int Dano => 5;
    public int Mult => 1;
    public int Bonus => 0;
    public int DanoTotal => (Dano+Bonus)*Mult;
    public void Atirar()
    {
        Console.WriteLine();
        Console.WriteLine($"Arma atual: {Nome}");
        Console.WriteLine($"Tipo de dano: {TipoDano}");
        Console.WriteLine($"Dano da arma: {DanoTotal}");
        Console.WriteLine();
    }
    public string TipoDano => "Contínuo (por segundo)";
}