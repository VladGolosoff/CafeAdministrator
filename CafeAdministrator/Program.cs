namespace CafeAdministrator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Переменна для проверки работы ресторана
            bool isOpen = true;
            // Создание массива столов
            Table[] tables = { new Table(1, 4), new Table(2, 8), new Table(3, 10) };

            while (isOpen)
            {
                Console.WriteLine("Администрирование кафе.\n");
                
                for (int i =0; i < tables.Length; i++)
                {
                    tables[i].ShowInfo();
                }
                Console.Write("\nВведите номер стола: ");
                int wishTable = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.Write("Введите количество гостей: ");
                int wishGuests = Convert.ToInt32(Console.ReadLine());
                
                bool isReserved = tables[wishTable].Reserve(wishGuests);

                if (isReserved)
                {
                    Console.WriteLine("Стол успешно забронирован.");
                }
                else
                {
                    Console.WriteLine("Бронь не прошлa\nНа столе недостаточно мест.");
                }
                
                Console.ReadKey();
                Console.Clear();
            }
        }

    }
    
    // Класс стола
    class Table
    {
        public int Number;
        public int MaxPlaces;
        public int FreePlaces;
        
        // Конструктор стола
        public Table(int number, int maxPlaces)
        {
            Number = number;
            MaxPlaces = maxPlaces;
            FreePlaces = maxPlaces;
        }
        // Метод для отображения информации о столе
        public void ShowInfo()
        {
            Console.WriteLine($"Стол: {Number}.\nСвободно мест: {FreePlaces} из {MaxPlaces}.\n");
        }

        // Метод для резервирования мест
        public bool Reserve(int places)
        {
            if (FreePlaces >= places)
            {
                FreePlaces -= places;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
     
}