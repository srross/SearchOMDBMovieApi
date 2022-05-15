using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SearchingOMDB.Models
{
    public class SearchMovie
    {
        [Required]
        [DisplayName("Movie Title")]
        public string MovieTitle { get; set; }

        // could add other search types beyond movie title
    }
}