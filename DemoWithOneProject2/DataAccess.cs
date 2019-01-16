using System;
using System.Collections.Generic;
using System.Text;

namespace DemoWithOneProject2
{
    public class DataAccess

    {
        private Fruitcontext _context;

        public DataAccess()
        {
            _context = new Fruitcontext();
        }

        internal void AddCategoriesAndFruits()
        {
            var skenfrukt = new FruitCategory { Name = "Skenfrukt" };
            var saftig = new FruitCategory { Name = "Saftig" };
            var exotisk = new FruitCategory { Name = "Exotisk" };

            _context.FruitCategories.Add(skenfrukt);
            _context.FruitCategories.Add(saftig);
            _context.FruitCategories.Add(exotisk);

            _context.Fruits.Add(new Fruit { Name = "Mango", Category = skenfrukt });
            _context.Fruits.Add(new Fruit { Name = "Passionsfrukt", Category = saftig });
            _context.Fruits.Add(new Fruit { Name = "Apelsin", Category = exotisk });

            _context.SaveChanges();

        }


    }
}

