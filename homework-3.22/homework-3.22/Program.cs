/*
практическое применение SOLID принципов.


Описание/Пошаговая инструкция выполнения домашнего задания:
На примере реализации игры «Угадай число» продемонстрировать практическое применение SOLID принципов.
Программа рандомно генерирует число, пользователь должен угадать это число. При каждом вводе числа программа пишет больше или меньше отгадываемого. 
Кол-во попыток отгадывания и диапазон чисел должен задаваться из настроек.
В отчёте написать, что именно сделано по каждому принципу.
Приложить ссылку на проект и написать, сколько времени ушло на выполнение задачи.


Критерии оценки:
2 балла: Принцип единственной ответственности;
1 балла: Принцип инверсии зависимостей;
2 балла: Принцип разделения интерфейса;
2 балла: Принцип открытости/закрытости;
2 балла: Принцип подстановки Барбары Лисков;
1 балл: CodeStyle, грамотная архитектура, всё замечания проверяющего исправлены.

Минимально необходимый балл: 6.
 
 */

using homework_3._22.Core;
using homework_3._22.Models;
using Microsoft.Extensions.DependencyInjection;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// регистрируем настройку для игры
var gameSettings = new GameSettings(MinNumber: 1, MaxNumber: 50, MaxAttempts: 5);

// инициализация контейнера
var services = new ServiceCollection();

// ioc
services.AddSingleton(gameSettings);
services.AddTransient<IRandomGenerator, DefaultRandomGenerator>();
services.AddTransient<IInputReader, ConsoleInputReader>();
services.AddTransient<IColorOutputWriter, AdvancedConsoleOutputWriter>();
services.AddTransient<IGameRules, GameRules>();
services.AddTransient<GameEngine>();

var serviceProvider = services.BuildServiceProvider();

// start
var game = serviceProvider.GetRequiredService<GameEngine>();
game.StartGame();
