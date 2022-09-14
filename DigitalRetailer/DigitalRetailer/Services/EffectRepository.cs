using System.Collections.Generic;
using System;
using DigitalRetailer.Models;
using System.Linq;

namespace DigitalRetailer.Services
{
    public class EffectRepository : IRepository<Effect>
    {
        List<Effect> _effects;
        public EffectRepository()
        {
            _effects = new List<Effect>();
            _effects.Add(new Effect()
            {
                Id = 1,
                Name = "On Sale",
                Description = "Laptops on Sale, Buy Now",
                ImageUrl = "slide1.png"
            });
            _effects.Add(new Effect()
            {
                Id = 2,
                Name = "New Laptops",
                Description = "Recently arrived",
                ImageUrl = "slide2.png"
            });
            _effects.Add(new Effect()
            {
                Id = 3,
                Name = "Subscription",
                Description = "Offers on becoming our Member",
                ImageUrl = "slide3.png"
            });
        }
        public bool Add(Effect item)
        {
            try
            {
                Effect effect = item;
                effect.Id = _effects.Max(x => x.Id) + 1;
                _effects.Add(effect);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool Delete(Effect item)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Effect item)
        {
            throw new NotImplementedException();
        }

        public Effect Get(int id)
        {
            return _effects.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Effect> GetAll()
        {
            return _effects.ToList();
        }
    }
}
