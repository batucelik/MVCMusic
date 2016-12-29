using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCMusic.Controllers
{
    class StoreIndexViewModel
    {
        public List<string> Genres { get; set; }

        public int NumberOfGenres { get; set; }
    }
}
