namespace SearchingOMDB.Models.DataAccess
{
    public interface IMovieRepo
    {
        Task<MovieDetail> GetMovie(string searchTerm);
    }
}