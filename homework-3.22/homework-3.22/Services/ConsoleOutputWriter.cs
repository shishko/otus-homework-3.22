/// <summary>
/// Базовая реализация вывода сообщений в стандартную консоль.
/// </summary>
public class ConsoleOutputWriter : IOutputWriter
{
    public virtual void Message(string message) => Console.WriteLine(message);
}


