using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using WorldCup.Models;

namespace WorldCup
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new TimeModelContext())
            {
                //Criando o Banco de dados
                db.Add(new Time { Nome = "Russia", Forca = 3 });
                db.Add(new Time { Nome = "Brasil", Forca = 4 });
                db.Add(new Time { Nome = "Ira", Forca = 1 });
                db.Add(new Time { Nome = "Japao", Forca = 3 });
                db.Add(new Time { Nome = "Mexico", Forca = 3 });
                db.Add(new Time { Nome = "Belgica", Forca = 3 });
                db.Add(new Time { Nome = "Coreia do sul", Forca = 2 });
                db.Add(new Time { Nome = "Arabia Saudita", Forca = 1 });
                db.Add(new Time { Nome = "Alemanha", Forca = 4 });
                db.Add(new Time { Nome = "Inglaterra", Forca = 4 });
                db.Add(new Time { Nome = "Espanha", Forca = 4 });
                db.Add(new Time { Nome = "Nigeria", Forca = 3 });
                db.Add(new Time { Nome = "Costa Rica", Forca = 2 });
                db.Add(new Time { Nome = "Polonia", Forca = 2 });
                db.Add(new Time { Nome = "Egito", Forca = 2 });
                db.Add(new Time { Nome = "Islandia", Forca = 3 });
                db.Add(new Time { Nome = "Servia", Forca = 3 });
                db.Add(new Time { Nome = "Franca", Forca = 4 });
                db.Add(new Time { Nome = "Portugal", Forca = 4 });
                db.Add(new Time { Nome = "Argentina", Forca = 4 });
                db.Add(new Time { Nome = "Colombia", Forca = 3 });
                db.Add(new Time { Nome = "Uruguai", Forca = 3 });
                db.Add(new Time { Nome = "Panama", Forca = 2 });
                db.Add(new Time { Nome = "Senegal", Forca = 1 });
                db.Add(new Time { Nome = "Marrocos", Forca = 1 });
                db.Add(new Time { Nome = "Tunisia", Forca = 1 });
                db.Add(new Time { Nome = "Suica", Forca = 3 });
                db.Add(new Time { Nome = "Croacia", Forca = 3 });
                db.Add(new Time { Nome = "Suecia", Forca = 3 });
                db.Add(new Time { Nome = "Dinamarca", Forca = 3 });
                db.Add(new Time { Nome = "Australia", Forca = 2 });
                db.Add(new Time { Nome = "Peru", Forca = 3 });
                db.SaveChanges();
            }

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
