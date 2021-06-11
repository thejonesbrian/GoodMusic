using System;
using System.Collections.Generic;
using System.Text;

namespace GoodMusic.Data.Models
{
    public class Music
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string BandName { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
