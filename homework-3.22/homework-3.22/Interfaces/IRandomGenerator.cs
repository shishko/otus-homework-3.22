/// <summary>
/// Определяет контракт для генерации случайных чисел.
/// Принцип разделения интерфейса: отвечает только за одну узкую задачу.
/// </summary>
internal interface IRandomGenerator
{
    int Generate(int min, int max);
}
