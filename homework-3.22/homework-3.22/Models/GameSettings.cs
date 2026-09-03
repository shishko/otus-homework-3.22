namespace homework_3._22.Models
{
    /// <summary>
    /// Хранит конфигурационные настройки для игрового процесса.
    /// </summary>
    /// <param name="MinNumber">Минимальная граница диапазона загадываемых чисел.</param>
    /// <param name="MaxNumber">Максимальная граница диапазона загадываемых чисел.</param>
    /// <param name="MaxAttempts">Максимально доступное количество попыток для игрока.</param>
    internal record GameSettings(int MinNumber, int MaxNumber, int MaxAttempts);
}
