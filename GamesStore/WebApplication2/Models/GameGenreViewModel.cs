using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication2.Models
{
    public class GameGenreViewModel
    {
        public List<Game> games;
        public SelectList genres;
        public string gameGenre { get; set; }
    }
}
