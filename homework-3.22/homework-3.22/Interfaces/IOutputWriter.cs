/// <summary>
/// Определяет контракт для чтения данных, вводимых пользователем.
/// Принцип разделения интерфейса: отвечает только за одну узкую задачу.
/// </summary>
internal interface IOutputWriter
{
    void Message(string message);
}



