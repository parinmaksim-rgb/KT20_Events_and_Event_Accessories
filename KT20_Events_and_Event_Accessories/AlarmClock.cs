using System;

namespace KT20_Events_and_Event_Accessories
{
    public class AlarmClock
    {
        private EventHandler? _ringingDelegate;

        public event EventHandler? Ringing
        {
            add
            {
                _ringingDelegate += value;
                Console.WriteLine("Лог: в лог выводится сообщение о новой подписке");
            }
            remove
            {
                _ringingDelegate -= value;
                Console.WriteLine("Лог: в лог выводится сообщение об отписке");
            }
        }

        public void Trigger()
        {
            Console.WriteLine("Действие: Вызов Trigger()...");

            _ringingDelegate?.Invoke(this, EventArgs.Empty);
        }
    }
}