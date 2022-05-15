using System.ComponentModel.DataAnnotations;

namespace SearchingOMDB.Models
{
    public class SearchMovie
    {
        [Required]
        public string MovieTitle { get; set; }

        // could add other search types beyond movie title
    }
}