/// <summary>
/// Реализует чтение данных из стандартной системной консоли с валидацией ввода.
/// </summary>
internal class ConsoleInputReader : IInputReader
{
    public int ReadNumber(string prompt)
    {
        // если написать ерунду
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                return result;
            }
            Console.WriteLine("Ошибка: Пожалуйста, введите корректное целое число.");
        }
    }
}


