/// <summary>
/// Стандартная реализация генератора псевдослучайных чисел на основе системного класса Random.
/// </summary>
public class DefaultRandomGenerator : IRandomGenerator
{
    private readonly Random _random = new();
    public int Generate(int min, int max) => _random.Next(min, max + 1);
}


