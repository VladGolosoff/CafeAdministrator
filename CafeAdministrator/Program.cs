namespace CafeAdministrator
{
    class Program
    {
        static void Main(string[] args)
        {
            Table[] tables = { new Table(1, 4), new Table(2, 8), new Table(3, 10) };
            
            
        }

    }
    
    class Table
    {
        public int Number;
        public int MaxPlaces;
        public int FreePlaces;
        
        public Table(int number, int maxPlaces)
        {
            Number = number;
            MaxPlaces = maxPlaces;
            FreePlaces = maxPlaces;
        }

    }
     }
}