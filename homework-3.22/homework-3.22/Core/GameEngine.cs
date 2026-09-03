namespace homework_3._22.Core
{
    using homework_3._22.Models;

    /// <summary>
    /// Ядро игры, управляющее основным игровым циклом.
    /// </summary>
    internal class GameEngine(
    IRandomGenerator randomGenerator,
    IInputReader inputReader,
    IColorOutputWriter outputWriter,
    IGameRules gameRules,
    GameSettings settings)
    {
        public void StartGame()
        {
            outputWriter.Message($"=== ИГРА: УГАДАЙ ЧИСЛО ===");
            outputWriter.Message($"Правила: угадайте число от {settings.MinNumber} до {settings.MaxNumber}.");
            outputWriter.Message($"У вас есть {settings.MaxAttempts} попыток.\n");

            int targetNumber = randomGenerator.Generate(settings.MinNumber, settings.MaxNumber);
            int attemptsLeft = settings.MaxAttempts;
            bool isGuarded = false;

            while (attemptsLeft > 0)
            {
                outputWriter.Message($"Осталось попыток: {attemptsLeft}");
                int userGuess = inputReader.ReadNumber("Введите ваше число: ");

                if (userGuess == targetNumber)
                {
                    outputWriter.Success($"\n🎉 Поздравляем! Вы угадали число {targetNumber}!");
                    isGuarded = true;
                    break;
                }

                string hint = gameRules.EvaluateHint(userGuess, targetNumber);
                outputWriter.Error(hint);

                attemptsLeft--;
                outputWriter.Message(new string('-', 30));
            }

            if (!isGuarded)
            {
                outputWriter.Error($"\n💀 Вы проиграли! Попытки закончились. Было загадано число: {targetNumber}");
            }
        }
    }
}
