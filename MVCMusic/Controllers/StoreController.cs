using MVCMusic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMusic.Controllers
{
    public class StoreController : Controller
    {
       
            // GET: Store
        public ActionResult Index()
        {
            var genres = new List<string> { "Rock", "Jazz", "Country", "Pop", "Disco" };
            var viewModel = new StoreIndexViewModel
            {

                NumberOfGenres = genres.Count(),
                Genres = genres
            };

            return View(viewModel);
        }


        // GET: Browse?genre=Disco
        public String Browse(string genre)
        {

            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);

            return message;
        }

        // GET: Store/Details/5
        public ActionResult Details(int id)
        {
            var album = new Album { Title = "Album " + id };
            return View(album);
        }
	}
}