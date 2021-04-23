using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace KimmoBook.Models
{
    public class Book
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int Stars { get; set; }
        [Column(TypeName="Date")]
        public DateTime FinishedReading { get; set; }
        public int Pages { get; set; }
    }
}
