namespace Estagio;

public class Escudo
{
    public string Foco { get; private set; } = "Foco padrão";

    public void AtivarCritico()
    {
        Foco = "Foco Crítico!";
    }

    public void DesativarCritico()
    {
        Foco = "Foco padrão";
    }
}