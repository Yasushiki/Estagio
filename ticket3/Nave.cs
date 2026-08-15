using Estagio.Ticket3.Lasers;
using Estagio.Ticket3.Misseis;
using Estagio.Ticket3.Desarmados;
using System.Collections.Generic;

namespace Estagio.Ticket3;

public class Nave
{
    private IArma _armaBase = new Desarmado();
    private IArma _arma = new Desarmado();

    private Dictionary<string, Func<IArma, IArma>> _decoratorsAtivos = new();

    public string NomeArma()
    {
        return _arma.Nome;
    }
    public string NomeBaseArma()
    {
        return _arma.NomeBase;
    }
    

    public void EquiparArma(IArma arma)
    {
        _armaBase = arma;
        _arma = arma;
        // limpa os decorators da arma pra garantir que n tem lixo
        _decoratorsAtivos.Clear();
    }

    public void AdicionarRemoverEfeito(string nomeEfeito, Func<IArma, IArma> f)
    {
        // tenta remover o efeito, se não conseguir, adiciona ele
        if (!_decoratorsAtivos.Remove(nomeEfeito))
        {
            _decoratorsAtivos[nomeEfeito] = f;
        }

        ReconstruirArma();
    }

    private void AdicionarEfeito(string nomeEfeito, Func<IArma, IArma> f)
    {
        _decoratorsAtivos[nomeEfeito] = f;
        ReconstruirArma();
    }

    private void RemoverEfeito(string nomeEfeito)
    {
        if (_decoratorsAtivos.Remove(nomeEfeito))
        {
            ReconstruirArma();
        }
        
    }

    private void ReconstruirArma()
    {
        IArma arma = _armaBase;

        foreach(var f in _decoratorsAtivos)
        {
            arma = f.Value(arma);
        }

        _arma = arma;
    }

    public void Atirar()
    {
        Console.WriteLine();
        Console.WriteLine($"Arma atual: {_arma.Nome}");
        Console.WriteLine($"Tipo de dano: {_arma.TipoDano}");
        Console.WriteLine($"Dano da arma: { (_arma.Dano+_arma.Bonus)*_arma.Mult }");
        Console.WriteLine();
    }
    
}