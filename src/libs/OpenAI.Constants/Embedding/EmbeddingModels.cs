// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

public readonly partial record struct EmbeddingModels(
    string Id,
    int MaxInputTokens,
    double PricePerTokenInUsd)
{
    /// <inheritdoc/>
    public override string ToString()
    {
        return Id;
    }

    /// <summary>
    /// Implicitly converts <see cref="EmbeddingModels"/> to <see cref="string"/>.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static implicit operator string(EmbeddingModels model)
    {
        return model.Id;
    }
    
    /// <summary>
    /// According https://openai.com/pricing/ <br/>
    /// </summary>
    /// <param name="tokens"></param>
    /// <returns></returns>
    public double GetPriceInUsd(
        int tokens)
    {
        return tokens * PricePerTokenInUsd;
    }
}