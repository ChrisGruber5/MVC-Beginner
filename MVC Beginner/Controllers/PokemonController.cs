using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MVC_Beginner.Controllers
{
    public class PokemonController : Controller
    {
        // GET: Pokemon
        public ActionResult Index()
        {
            PokemonAPI allpokemon;
            using (var client = new HttpClient())
            {
                var json = client.GetStringAsync("https://pokeapi.co/api/v2/pokemon").Result;
                allpokemon = JsonConvert.DeserializeObject<PokemonAPI>(json);
            }
            return View(allpokemon.results);
        }
    }
}