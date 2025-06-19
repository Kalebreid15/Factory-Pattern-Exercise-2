using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    class MongoDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>
        {
            new Product (){ Name = "PS5", Price = 275 },
            new Product (){ Name = "Empire State building", Price = 480000000 },
            new Product () { Name = "Soccer Ball", Price = 19 },
            new Product () { Name = "Corner Flags", Price = 34 },
            new Product () { Name = "Lexus ES 350", Price = 79500 },
            new Product () { Name = "Thinking Cap", Price = 16 },
            new Product () { Name = "Unicycle", Price = 22 },
            new Product () { Name = "Human Chess Board", Price = 75 },
            new Product () { Name = "Bling-Bling King", Price = 1200 }
        };
        public List<Product> LoadData()
        {
            Console.WriteLine(" I am reading data from Mongo Data Access.");

            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine(" I am saving data from Mongo Data Access.");


        }
    }
}
