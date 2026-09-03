/// <summary>
/// Базовая реализация вывода сообщений в стандартную консоль.
/// </summary>
internal class ConsoleOutputWriter : IOutputWriter
{
    public virtual void Message(string message) => Console.WriteLine(message);
}


