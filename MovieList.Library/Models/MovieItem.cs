using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieList.Library.Models
{
    public class MovieItem(string movieName, string movieDesc, bool movieWatched)
    {
        public long movie_id { get; set; }
        public string movie_name { get; set; } = movieName;
        public bool movie_watched { get; set; } = movieWatched;
        public string? movie_desc { get; set; } = movieDesc;
        
    }
    
}
