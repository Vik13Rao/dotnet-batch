using DigitalRetailer.Data;
using DigitalRetailer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DigitalRetailer.Services
{
    public class MainEffectRepository : IRepository<Effect>
    {
        private DigitalRetailerDbContext _context;

        public MainEffectRepository(DigitalRetailerDbContext context)
        {
            _context = context;
        }

        public bool Add(Effect item)
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

        public bool Delete(Effect item)
        {
            try
            {
                Effect effect = Get(item.Id);
                if (effect != null)
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

        public bool Edit(Effect item)
        {
            throw new System.NotImplementedException();
        }

        public Effect Get(int id)
        {
            if (_context.Effects.Count(x => x.Id == id) > 0)
            {
                return _context.Effects.FirstOrDefault(x => x.Id == id);
            }
            return null;
        }

        public IEnumerable<Effect> GetAll()
        {
            return _context.Effects;
        }
    }
}
