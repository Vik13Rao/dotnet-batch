using System.Collections.Generic;
using System;
using DigitalRetailer.Models;
using System.Linq;

namespace DigitalRetailer.Services
{
    public class LaptopRepository : IRepository<Laptop>
    {
        List<Laptop> _laptop;
        public LaptopRepository()
        {
            _laptop = new List<Laptop>()
            { new Laptop()
                {
                Id = 1,
                Name = "Hp pavillion",
                Description = "RYZEN 5, 1650 GTX, 8 GB RAM",
                Price = 55000,
                ImageUrl = "img1.png"

                 },
                 new Laptop()
                {
                Id = 2,
                Name = "Hp Omen",
                Description = "Intel i5 11th Gen, 16gb RAM, 3050rtx",
                Price = 85000,
                ImageUrl = "img2.png"

                 },
                 new Laptop()
                {
                Id = 3,
                Name = "Lenovo Ideapad",
                Description = "Intel i7 11th gen, 2050 RTX, 8 GB RAM, 512GB SSD",
                Price = 70000,
                ImageUrl = "img3.png"

                 },
                  new Laptop()
                {
                Id = 4,
                Name = "Asus Tuff",
                Description = "Intel i5 10th gen,1060 gtx, 8 GB RAM, 1TB HDD",
                Price = 50000,
                ImageUrl = "img4.png"

                 },
                   new Laptop()
                {
                Id = 5,
                Name = "Acer Aspire 7",
                Description = "Intel i5 12th gen, 1650 gtx, 8 GB RAM, 512GB SSD",
                Price = 60000,
                ImageUrl = "img5.png"

                 },
                 new Laptop()
                {
                Id = 6,
                Name = "DELL G-15",
                Description = "Ryzen 5 5600H, 3050 RTX, 16 GB RAM, 512GB SSD",
                Price = 75000,
                ImageUrl = "img6.png"

                 },
                  new Laptop()
                {
                Id = 7,
                Name = "MSI Alpha 15",
                Description = "Ryzen 7 5800H,Radeon RX660M, 16 GB RAM, 1TB SSD",
                Price = 90000,
                ImageUrl = "img7.png"

                 },
                   new Laptop()
                {
                Id = 8,
                Name = "ASUS ROG strix g15",
                Description = "Ryzen 9 5900H, rtx 3050 Ti, 16 GB RAM, 512GB SSD",
                Price = 100000,
                ImageUrl = "img8.png"

                 },
                    new Laptop()
                {
                Id = 9,
                Name = "Acer Predator Helios",
                Description = "Intel i7 11th gen, RTX 3060, 16 GB RAM, 512GB SSD",
                Price = 120000,
                ImageUrl = "img9.png"

                 },

            };
        }
        public bool Add(Laptop item)
        {
            try
            {
                Laptop laptop = item;
                laptop.Id = _laptop.Max(x => x.Id) + 1;
                _laptop.Add(item);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Laptop item)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Laptop item)
        {
            throw new NotImplementedException();
        }

        public Laptop Get(int id)
        {
            return _laptop.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Laptop> GetAll()
        {
            return _laptop.ToList();
        }
    }
}
