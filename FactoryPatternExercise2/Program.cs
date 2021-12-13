using System;

namespace FactoryPatternExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to work with?");
            Console.WriteLine("Type: SQL \r\nType: Mongo \r\nType: List");

            var userInput = Console.ReadLine();

            IDataAccess db = DataAccessFactory.GetDataAccessType(userInput);

            var products = db.LoadData();

            foreach(var item in products)
            {
                Console.WriteLine($"Name: {item.Name} Price: {item.Price}");
            }

            db.SaveData();
        }
    }
}
