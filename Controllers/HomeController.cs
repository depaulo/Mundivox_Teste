using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WorldCup.Models;
using WorldCup;

namespace WorldCup.Controllers
{
    public class HomeController : Controller
    {       
        
        public IActionResult Index()
        {
            var myDb = new TimeModelContext(); 
            ViewBag.Times = myDb.Times;
            return View(myDb.Times);        
        }

        public IActionResult WorldCup()
        {
            
            var Id = new List<int>(){//Metodo usados para misturar os times
            0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31
            };
            var id = new List<int>();
            Random rnd = new Random();
            while (Id.Count != 0){
                var number = rnd.Next(Id.Count);
                id.Add(Id[number]);
                Id.RemoveAt(number);
            }
            var myDb = new TimeModelContext(); 
            ViewBag.Id = id;
            ViewBag.Times = myDb.Times;
            return View();
        }
    }
}
