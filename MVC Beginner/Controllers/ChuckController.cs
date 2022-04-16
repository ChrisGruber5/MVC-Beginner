using MVC_Beginner.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MVC_Beginner.Controllers
{
    public class ChuckController : Controller
    {
        // GET: Cuck
        public ActionResult Index()
        {
            RandomChuckJokeAPI joke;
            using(var client = new HttpClient())
            {
                var json = client.GetStringAsync("https://api.chucknorris.io/").Result;
                joke = JsonConvert.DeserializeObject<RandomChuckJokeAPI>(json);
            }
            return View(joke);
        }
    }
}