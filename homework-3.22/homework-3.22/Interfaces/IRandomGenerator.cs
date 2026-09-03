/// <summary>
/// Определяет контракт для генерации случайных чисел.
/// </summary>
internal interface IRandomGenerator
{
    int Generate(int min, int max);
}
