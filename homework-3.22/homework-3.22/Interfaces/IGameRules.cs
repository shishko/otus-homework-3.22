/// <summary>
/// Определяет контракт для проверки правил игры и формирования подсказок.
/// Принцип открытости/закрытости
/// </summary>
public interface IGameRules
{
    string EvaluateHint(int guess, int targetNumber);
}
