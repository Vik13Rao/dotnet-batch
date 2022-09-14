using DigitalRetailer.Data;
using DigitalRetailer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DigitalRetailer.Services
{
    public class SqlLaptopRepository : IRepository<Laptop>
    {
        private DigitalRetailerDbContext _context;
        public SqlLaptopRepository(DigitalRetailerDbContext context)
        {
            _context = context;
        }
        
        public bool Add(Laptop item)
        {
            try
            {
                _context.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                
                return false;
            }
        }

        public bool Delete(Laptop item)
        {
            try
            {
                Laptop laptop = Get(item.Id);
                if (laptop != null)
                {
                    _context.Remove(item);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                
                return false;
            }
        }

        public bool Edit(Laptop item)
        {
            throw new System.NotImplementedException();
        }

        public Laptop Get(int id)
        {
            if (_context.Laptops.Count(x => x.Id == id) > 0)
            {
                return _context.Laptops.FirstOrDefault(x => x.Id == id);
            }
            return null;
        }

        public IEnumerable<Laptop> GetAll()
        {
            return _context.Laptops;
        }
    }
}
