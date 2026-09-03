/// <summary>
/// Расширенная реализация вывода в консоль, добавляющая цвета для разных типов сообщений.
/// </summary>
public class AdvancedConsoleOutputWriter : ConsoleOutputWriter, IColorOutputWriter
{
    public void Success(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Message(message);
        Console.ResetColor();
    }

    public void Error(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Message(message);
        Console.ResetColor();
    }
}


