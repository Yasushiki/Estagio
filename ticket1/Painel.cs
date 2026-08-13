namespace Estagio.ticket1;

public class Painel
{
    public string Alertas { get; private set; } = "";

    public void AtivarCritico()
    {
        Alertas = "Alertas Críticos!";
    }

    public void DesativarCritico()
    {
        Alertas = "";
    }
}