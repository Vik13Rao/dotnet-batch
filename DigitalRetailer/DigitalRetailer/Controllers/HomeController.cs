using DigitalRetailer.Models;
using DigitalRetailer.Services;
using DigitalRetailer.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DigitalRetailer.Controllers
{
    public class HomeController : Controller
    {
        List<Laptop> _laptop;
        IRepository<Laptop> _repo;
        IRepository<Effect> _EffectRepo;
        IRepository<Order> _OrdersRepo;
        public HomeController(IRepository<Laptop> laptop, IRepository<Effect> effect, IRepository<Order> order)
        {
            _repo = laptop;
            //_laptop = new List<Laptop>();
            _EffectRepo = effect;
            _OrdersRepo = order;

        }
        public IActionResult Index()
        {
            HomeIndexViewModel model = new HomeIndexViewModel()
            {
                Laptops = _repo.GetAll(),
                Effects = _EffectRepo.GetAll()
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult AddLaptop()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddLaptop(Laptop laptop)
        {
            if(ModelState.IsValid)
            {
                Laptop item = new Laptop()
                {
                    Id = _repo.GetAll().Max(m => m.Id) + 1,
                    Name = laptop.Name,
                    Description = laptop.Description,
                    Price = laptop.Price,
                    ImageUrl = laptop.ImageUrl
                };
                _repo.Add(item);
                return RedirectToAction("Index");

            }
            else
            {
                return View();

            }
            
            
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            Laptop laptop = _repo.Get(id);
            return View(laptop);
        }
        [HttpGet]
        public IActionResult Order(int? id)
        {
            if(id!=null && id>=0)
            {
                OrdViewModel model = new OrdViewModel()
                {
                    LaptopOrder = _repo.Get((int)id),
                    OrderDetails = new Order()
                    {
                        LaptopId = (int)id
                    }
                };
                return View(model);
            }
            return View();
        }

        [HttpPost]
        public IActionResult Order(int id,Order orderDetails)
        {
            //if (ModelState.IsValid)
            //{
                if (_repo.GetAll().Count(x => x.Id == id) >= 1)
                {
                    orderDetails.LaptopId= id;
                    _OrdersRepo.Add(orderDetails);
                    return RedirectToAction("ThankYou");
                }
                else
                {
                    return View();
                }
            //}
            //else
            //{
            //    return View(new OrdViewModel()
            //    {
            //        OrderDetails = orderDetails,
            //        LaptopOrder = _repo.Get(id)
            //    });
            //}
        }

        public IActionResult ThankYou()
        {
            return View();
        }

        public IActionResult OrderList()
        {
            return View(_OrdersRepo.GetAll());
        }

    }
}
