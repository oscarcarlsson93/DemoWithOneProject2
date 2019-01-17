using System;
using System.Collections.Generic;

namespace DemoWithOneProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClearAndInItDatabase();
            DisplayAllFruits();
            DisplayJustSkenfrukter();

        }

        private static void DisplayJustSkenfrukter()
        {
            var dataAccess = new DataAccess();
            IEnumerable<Fruit> fruits = dataAccess.GetFruitsInCategory("Exotisk");
            Console.WriteLine();
            Console.WriteLine("SKENFRUKTER");
            Console.WriteLine();

            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit.Name);
            }
        }

        private static void DisplayAllFruits()
        {
            var dataAccess = new DataAccess();
            foreach (Fruit item in dataAccess.GetAll())
            {
                Console.WriteLine(item.Id.ToString().PadRight(10) + item.Name.PadRight(15) + item.Price.ToString().PadRight(15) + item.Category.Name);
            }
        }

        private static void ClearAndInItDatabase()
        {
            var dataAccess = new DataAccess();
            dataAccess.ClearDatabase();
            dataAccess.AddCategoriesAndFruits();


        }
    }
}
