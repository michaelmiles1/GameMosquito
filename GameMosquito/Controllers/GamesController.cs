using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GameMosquito.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GameMosquito.Controllers
{
    public class GamesController : Controller
    {
        // GET: Games/Random
        public IActionResult Random()
        {
            var game = new Game() {Name = "Grand Theft Auto 5"};

            //ViewData["Game"] = game;
            //ViewBag.Game = game
            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model

            return View(game);
        }

        [Route("games/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

    }
}
