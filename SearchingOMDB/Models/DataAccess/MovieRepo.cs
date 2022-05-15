namespace SearchingOMDB.Models.DataAccess
{
    public class MovieRepo : IMovieRepo
    {
        public async Task<MovieDetail> GetMovie(string searchTerm)
        {
            HttpClient client = new HttpClient();

            // could configure this in appSettings
            client.BaseAddress = new Uri("http://www.omdbapi.com"); 

            // could add null check and error handling
            var response = await client.GetFromJsonAsync<MovieDetail>("?t=" + searchTerm + "&apiKey=39e4f81d");

            return response;
        }
    }
}