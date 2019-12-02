using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WorldCup.Models;
using WorldCup;

namespace WorldCup.Controllers
{
    public class HomeController : Controller
    {
        public List<Time> ListaDeTimes = new List<Time>(){//Criando os Dados que seram usados no Programa
        new Time { Nome = "Russia", Forca = 3 },
        new Time { Nome = "Brasil", Forca = 4 },
        new Time { Nome = "Ira", Forca = 1 },
        new Time { Nome = "Japao", Forca = 3 },
        new Time { Nome = "Mexico", Forca = 3 },
        new Time { Nome = "Belgica", Forca = 3 },
        new Time { Nome = "Coreia do sul", Forca = 2 },
        new Time { Nome = "Arabia Saudita", Forca = 1 },
        new Time { Nome = "Alemanha", Forca = 4 },
        new Time { Nome = "Inglaterra", Forca = 4 },
        new Time { Nome = "Espanha", Forca = 4 },
        new Time { Nome = "Nigeria", Forca = 3 },
        new Time { Nome = "Costa Rica", Forca = 2 },
        new Time { Nome = "Polonia", Forca = 2 },
        new Time { Nome = "Egito", Forca = 2 },
        new Time { Nome = "Islandia", Forca = 3 },
        new Time { Nome = "Servia", Forca = 3 },
        new Time { Nome = "Franca", Forca = 4 },
        new Time { Nome = "Portugal", Forca = 4 },
        new Time { Nome = "Argentina", Forca = 4 },
        new Time { Nome = "Colombia", Forca = 3 },
        new Time { Nome = "Uruguai", Forca = 3 },
        new Time { Nome = "Panama", Forca = 2 },
        new Time { Nome = "Senegal", Forca = 1 },
        new Time { Nome = "Marrocos", Forca = 1 },
        new Time { Nome = "Tunisia", Forca = 1 },
        new Time { Nome = "Suica", Forca = 3 },
        new Time { Nome = "Croacia", Forca = 3 },
        new Time { Nome = "Suecia", Forca = 3 },
        new Time { Nome = "Dinamarca", Forca = 3 },
        new Time { Nome = "Australia", Forca = 2 },
        new Time { Nome = "Peru", Forca = 3 },
        };
        
        
        public IActionResult Index()
        {/*acessando o banco de dados, infelizmente nao consegui terminar de implementar e trocar a logica
        mas o banco de dados foi criado e pode ser acessado. Abra o browser e veja no console os dados do banco de dados sao acessiveis.*/
            var myDb = new TimeModelContext(); 
            foreach(var each in myDb.Times){
                ViewBag.myDb = each;
            }
            ViewBag.Times = ListaDeTimes;
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
            ViewBag.Id = id;
            ViewBag.Times = ListaDeTimes;
            return View();
        }
    }
}
