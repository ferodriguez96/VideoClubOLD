using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VideoClub.DataBase;

namespace VideoClub.Controllers
{
    public class ClienteController : Controller
    {
        private readonly VideoClubDbContext _DbContext;

        public ClienteController(VideoClubDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = _DbContext.Clientes.ToList();

            return View(model);
        }

        public IActionResult Crear()
        {
            return View();
        }
    }
}