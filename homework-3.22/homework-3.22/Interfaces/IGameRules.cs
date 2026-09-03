/// <summary>
/// Определяет контракт для проверки правил игры и формирования подсказок.
/// </summary>
public interface IGameRules
{
    string EvaluateHint(int guess, int targetNumber);
}
