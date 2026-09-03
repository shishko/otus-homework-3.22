/// <summary>
/// Классические правила игры «Угадай число» (Больше / Меньше).
/// </summary>
internal class GameRules : IGameRules
{
    public string EvaluateHint(int guess, int targetNumber)
    {
        if (guess < targetNumber) return "Загаданное число БОЛЬШЕ.";
        if (guess > targetNumber) return "Загаданное число МЕНЬШЕ.";
        return "Вы угадали!";
    }
}