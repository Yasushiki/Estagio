using Estagio.Ticket3.Lasers;
using Estagio.Ticket3.Misseis;
using Estagio.Ticket3.Desarmados;
using System.Collections.Generic;

namespace Estagio.Ticket3;

public class ArmaFactory
{
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

    public static IArma CDesarmado() => new Desarmado();
    public static IArma CLaser() => new Laser();
    public static IArma CMissil() => new Missil();
}