using Estagio.Ticket3.Lasers;
using Estagio.Ticket3.Misseis;
using Estagio.Ticket3.Desarmados;
using System.Collections.Generic;

namespace Estagio.Ticket3;

/// <summary>
/// Implementa o padrão criacional Factory.
/// Fábrica responsável por centralizar a criação das armas base
/// e seus decoradores.
/// </summary>
public class ArmaFactory
{
    /// <summary>
    /// Dicionário que mapeia o nome da arma base para as
    /// funções que criam os decoradores aplicáveis.
    /// </summary>
    public static readonly Dictionary<string, List<(string Nome, Func<IArma, IArma> CriarEfeito)>> Armas = new()
    {
        ["Desarmado"] = [],
        ["Laser"] = [
            ("Laser Duplo", arma => new LaserDuplo(arma)),
            ("Laser Helicoidal", arma => new LaserHelicoidal(arma))
        ],
        ["Míssil"] = [
            ("Míssil Múltiplo", arma => new MissilMultiplo(arma)),
            ("Míssil de Nanite", arma => new MissilNanite(arma))
        ]
    };

    /// <summary>
    /// Funções que criam as armas base.
    /// </summary>
    public static IArma CDesarmado() => new Desarmado();
    public static IArma CLaser() => new Laser();
    public static IArma CMissil() => new Missil();
}