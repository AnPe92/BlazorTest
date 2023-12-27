using MovieList.Library.Models;

namespace MovieList.Client.Services.Interfaces
{
    public interface IMovieService
    {
        Task<IEnumerable<MovieItem>> GetMoviesAsync();
    }
}