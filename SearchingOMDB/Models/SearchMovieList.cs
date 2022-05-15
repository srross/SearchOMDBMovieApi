namespace SearchingOMDB.Models
{
    public class SearchMovieList
    {
        public string MovieTitle1 { get; set; }
        public string MovieTitle2 { get; set; }
        public string MovieTitle3 { get; set; }

        // could add a viewModel with logic that allows any number of movies.  What data structure would work best?
        // add a List<MovieDetail> property.  VM: method create new MovieDetailObj, method to add new MovieDetailObj to List.
        // Would the above logic belong in the repo?
    }
}