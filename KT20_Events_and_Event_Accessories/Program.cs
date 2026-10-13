using System;

namespace KT20_Events_and_Event_Accessories
{
    class Program
    {
        static void Main()
        {
            AlarmClock alarm = new();
            EventHandler handler = AlarmHandler;

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\n--- Меню управления будильником ---");
                Console.WriteLine("1. подписка обработчика");
                Console.WriteLine("2. Вызвать Trigger()");
                Console.WriteLine("3. Отписать обработчик");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите действие: ");

                string? choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Действие: подписка обработчика");
                        alarm.Ringing += handler;
                        break;
                    case "2":
                        alarm.Trigger();
                        break;
                    case "3":
                        Console.WriteLine("Действие: отписка обработчика");
                        alarm.Ringing -= handler;
                        break;
                    case "0":
                        isRunning = false;
                        Console.WriteLine("Завершение программы.");
                        break;
                    default:
                        Console.WriteLine("Неверный ввод. Пожалуйста, введите число от 0 до 3.");
                        break;
                }
            }
        }

        private static void AlarmHandler(object? sender, EventArgs e)
        {
            Console.WriteLine("Результат: подписанный обработчик срабатывает");
        }
    }
}