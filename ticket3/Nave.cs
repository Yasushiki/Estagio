using Estagio.Ticket3.Lasers;
using Estagio.Ticket3.Misseis;
using Estagio.Ticket3.Desarmados;
using System.Collections.Generic;

namespace Estagio.Ticket3;

/// <summary>
/// Representa a nave que consegue atacar;
/// Atua como "Context" no padrão State, permitindo alterar a
/// arma base dinamicamente.
/// Atua como "Client" no padrão Decorator, orquestrando os
/// modificadores sobre a arma.
/// </summary>
public class Nave
{
    /// <summary>
    /// Estado atual da arma, sem nenhuma modificação.
    /// </summary>
    private IArma _armaBase = new Desarmado();

    /// <summary>
    /// Arma final após os decoradores.
    /// É a arma que realmente ataca.
    /// </summary>
    private IArma _arma = new Desarmado();

    /// <summary>
    /// Dicionário usado para identificar os decoradores ativos.
    /// </summary>
    private Dictionary<string, Func<IArma, IArma>> _decoratorsAtivos = new();

    /// <summary>
    /// Retorna o nome completo da arma com os decoradores.
    /// Apenas impressão.
    /// </summary>
    public string NomeArma()
    {
        return _arma.Nome;
    }

    /// <summary>
    /// Retorna o nome da arma base.
    /// É utilizada para acessar os modificadores da arma.
    /// </summary>
    public string NomeBaseArma()
    {
        return _arma.NomeBase;
    }
    
    /// <summary>
    /// Altera o estado (arma base) da nave.
    /// </summary>
    public void EquiparArma(IArma arma)
    {
        _armaBase = arma;
        _arma = arma;
        // limpa os decoradores ativos ao trocar de arma.
        _decoratorsAtivos.Clear();
    }

    /// <summary>
    /// Adiciona ou remove os decoradores/efeitos na arma.
    /// </summary>
    /// <param name="nomeEfeito">Nome do efeito que vai ser adicionado ou removido.</param>
    /// <param name="f">Função que vai adicionar o efeito.</param>
    public void AdicionarRemoverEfeito(string nomeEfeito, Func<IArma, IArma> f)
    {
        // Tenta remover o efeito, se não conseguir, adiciona ele
        if (!_decoratorsAtivos.Remove(nomeEfeito))
        {
            _decoratorsAtivos[nomeEfeito] = f;
        }

        ReconstruirArma();
    }

    /// <summary>
    /// Recalcula o objeto final encapsulando o Component
    /// de acordo com decoradores registrados.
    /// </summary>
    private void ReconstruirArma()
    {
        IArma arma = _armaBase;

        foreach(var f in _decoratorsAtivos)
        {
            arma = f.Value(arma);
        }

        _arma = arma;
    }

    /// <summary>
    /// Executa a ação de atirar.
    /// Altera os valores de acordo com o estado (arma base)
    /// e com os decoradores (efeitos da arma).
    /// </summary>
    public void Atirar()
    {
        Console.WriteLine();
        Console.WriteLine($"Arma atual: {_arma.Nome}");
        Console.WriteLine($"Tipo de dano: {_arma.TipoDano}");
        Console.WriteLine($"Dano da arma: { (_arma.Dano+_arma.Bonus)*_arma.Mult }");
        Console.WriteLine();
    }
}