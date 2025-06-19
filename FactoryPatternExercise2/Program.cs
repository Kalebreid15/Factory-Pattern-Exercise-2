using System;


namespace FactoryPatternExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to work with?");
            Console.WriteLine();
            Console.WriteLine("Type sql");
            Console.WriteLine("Type mongo");
            Console.WriteLine("Type list");
            Console.WriteLine();

            var userInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Invalid input. Please provide a valid database type.");
                return;
            }

            IDataAccess db = DataAccessFactory.GetDataAccessType(userInput);

            if (db == null)
            {
                Console.WriteLine("The specified database type is not supported.");
                return;
            }

            
            db.SaveData();
            var products = db.LoadData();

            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
            }



        }
    }
}
