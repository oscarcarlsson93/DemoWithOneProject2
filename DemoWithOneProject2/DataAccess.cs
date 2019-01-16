using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

            _context.Fruits.Add(new Fruit { Name = "Mango", Category = skenfrukt, Price = 13 });
            _context.Fruits.Add(new Fruit { Name = "Passionsfrukt", Category = saftig, Price = 10 });
            _context.Fruits.Add(new Fruit { Name = "Apelsin", Category = exotisk, Price = 15});


            _context.SaveChanges();

        }

        internal IEnumerable<Fruit> GetFruitsInCategory(string v)
        {
            return _context.Fruits.Where(x => x.Category.Name == v); //.ToList();

        internal IEnumerable<Fruit> GetAll()
        {
            return _context.Fruits.Include(x=>x.Category);

        }

        internal void ClearDatabase()
        {
            //foreach
            //remove

            foreach (var item in _context.FruitCategories )
            {
                _context.Remove(item);
            }

            foreach (var item in _context.Fruits)
            {
                _context.Remove(item);
            }
           // _context.RemoveRange(Fruit);

            _context.SaveChanges();

        }
    }
}

