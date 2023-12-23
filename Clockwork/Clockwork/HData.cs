using System;

namespace Clockwork
{
    // Класс HData представляет собой класс для хранения данных о предыдущей записи пользователя.
    internal class HData
    {
        private static HData _instance;

        // Свойство для хранения имени пользователя.
        public string Name { get; set; }

        // Свойство для хранения номера телефона пользователя.
        public string Phone { get; set; }

        // Свойство для хранения даты и времени предыдущей записи пользователя.
        public DateTime DateTime { get; set; }

        // Свойство для хранения адреса предыдущей записи пользователя.
        public string Address { get; set; }

        // Приватный конструктор для предотвращения создания экземпляров класса.
        private HData() { }

        // Статическое свойство для доступа к единственному экземпляру класса.
        public static HData Instance
        {
            get
            {
                // Если экземпляр еще не создан, создаем его.
                if (_instance == null)
                    _instance = new HData();
                return _instance;
            }
        }
    }
}
