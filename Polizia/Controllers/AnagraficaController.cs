using Microsoft.AspNetCore.Mvc;

namespace Polizia.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class AnagraficaController : Controller
    {
        private readonly string _connectionString;

        public AnagraficaController()
        {
            var configuration = new ConfigurationBuilder()
                     .SetBasePath(Directory.GetCurrentDirectory())
                     .AddJsonFile("appsettings.json", false, true)
                     .Build();

            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }


        [HttpGet]

    }
}
