using System;
using System.Collections.Generic;
using System.Text;

namespace GoodMusic.Data.Models
{
    public class MusicReview
    {
        public int Id { get; set; }
        public string Reviewer { get; set; }
        public string Review { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public Music Music { get; set; } 
    }
}
