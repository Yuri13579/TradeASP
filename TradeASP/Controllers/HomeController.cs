using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TradeASP.Models;

namespace TradeASP.Controllers
{
    public class HomeController : Controller
    {
        private GoodContext db;


        public HomeController(GoodContext context)
        {
            db = context;
        }
        

        public async Task<IActionResult> Index()
        {
            return View(await db.Goods.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Good good)
        {
            db.Goods.Add(good);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(string id)
        {
            if (id != null)
            {
                Good good = await db.Goods.FirstOrDefaultAsync(p => p.id == id);
                if (good != null)
                    return View(good);
            }
            return NotFound();
        }

        public async Task<IActionResult> Edit(string id)
        {
            if (id != null)
            {
                Good good = await db.Goods.FirstOrDefaultAsync(p => p.id == id);
                if (good != null)
                    return View(good);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Good good)
        {
            db.Goods.Update(good);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(string id)
        {
            if (id != null)
            {
                Good good = await db.Goods.FirstOrDefaultAsync(p => p.id == id);
                 if (good != null)
                    return View(good);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            if (id != null)
            {
                Good good = new Good { id = id };
                db.Entry(good).State = EntityState.Deleted;
                await db.SaveChangesAsync();         
                return RedirectToAction("Index");
            }
            return NotFound();
        }


    //      using (UserContex db = new UserContex())
    //            {
    //                // создаем два объекта User
    //                //User user1 = new User { Name = "Tom", Age = 33 };
    //                //User user2 = new User { Name = "Sam", Age = 26 };

    //                // добавляем их в бд
    //                //db.Users.Add(user1);
    //                //db.Users.Add(user2);
    //                //db.SaveChanges();
    //                Console.WriteLine("Объекты успешно сохранены");

    //                // получаем объекты из бд и выводим на консоль
    //                var users = db.Users;
    //Console.WriteLine("Список объектов:");
                    //foreach (User u in users)
                    //{
                    //    Console.WriteLine("{0}.{1} - {2}", u.Id, u.Name, u.Age);
                    //}
                }


        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }

