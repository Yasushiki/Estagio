namespace Estagio;

public class Luz
{
    public bool LuzLigada { get; private set; } = true;

    public void AtivarCritico()
    {
        LuzLigada = false;
    }

    public void DesativarCritico()
    {
        LuzLigada = true;
    }   
}