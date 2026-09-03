/// <summary>
/// Определяет контракт для чтения данных, вводимых пользователем.
/// </summary>
internal interface IInputReader
{
    int ReadNumber(string prompt);
}
