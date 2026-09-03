/// <summary>
/// Определяет контракт для чтения данных, вводимых пользователем.
/// Принцип разделения интерфейса: отвечает только за одну узкую задачу.
/// </summary>
internal interface IInputReader
{
    int ReadNumber(string prompt);
}
