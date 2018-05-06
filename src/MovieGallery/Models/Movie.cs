using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieGallery.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string DescriptionHtml { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Studio { get; set; }
        public bool Favorite { get; set; }
    }
}