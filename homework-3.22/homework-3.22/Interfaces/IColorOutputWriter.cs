/// <summary>
/// Расширенный контракт для вывода сообщений с поддержкой цветов.
/// Принцип подстановки Барбары Лисков
/// </summary>
internal interface IColorOutputWriter : IOutputWriter
{
    void Success(string message);

    void Error(string message);
}

