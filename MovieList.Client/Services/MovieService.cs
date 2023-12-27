using MovieList.Client.Services.Interfaces;
using MovieList.Library.Models;
using System.Net.Http.Json;

namespace MovieList.Client.Services
{
    public class MovieService : IMovieService
    {

        private readonly HttpClient _httpClient;

        public MovieService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<IEnumerable<MovieItem>> GetMoviesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
