namespace Estagio.Ticket3;

/// <summary>
/// Interface fundamental do sistema de armamento.
/// Representa múltiplos papéis arquiteturais:
/// 1 - "Component" no padrão Decorator,
///     sendo o alvo das decorações.
/// 2 - "State" na relação com a nave,
///     definindo o comportamento de ataque.
/// </summary>
public interface IArma
{
    /// <summary>
    /// Nome atual da arma, incluindo os efeitos aplicados.
    /// </summary>
    public string Nome { get; }
    
    /// <summary>
    /// Nome da arma base, sem efeitos.
    /// </summary>
    public string NomeBase { get; }

    /// <summary>
    /// Dano base causado pela arma.
    /// </summary>
    public int Dano { get; }
    
    /// <summary>
    /// Multiplicador de dano aplicado à arma.
    /// </summary>
    public int Mult { get; }

    /// <summary>
    /// Bônus de dano fixo aplicado à arma.
    /// </summary>
    public int Bonus { get; }
    
    /// <summary>
    /// Descrição do tipo de dano causado pela arma e pelos efeitos.
    /// </summary>
    public string TipoDano { get; }
}