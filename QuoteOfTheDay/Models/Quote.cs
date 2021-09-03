using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteOfTheDay.Models
{
    public class Quote
    {
        [Required(ErrorMessage ="A Quote is required ")]
        public string Text { get; set; }
        [Required(ErrorMessage = "An author name is required ")]
        public string Author { get; set; }
    }
}
