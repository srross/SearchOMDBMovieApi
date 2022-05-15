using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SearchingOMDB.Models
{
    public class SearchMovieList
    {
        [Required]
        [DisplayName("Movie Title 1")]
        public string MovieTitle1 { get; set; }

        [Required]
        [DisplayName("Movie Title 2 ")]
        public string MovieTitle2 { get; set; }

        [DisplayName("Movie Title 3")]
        public string MovieTitle3 { get; set; }

        // could add a viewModel with logic that allows any number of movies.  What data structure would work best?
        // add a List<MovieDetail> property.  VM: method create new MovieDetailObj, method to add new MovieDetailObj to List.
        // Would the above logic belong in the repo?
    }
}