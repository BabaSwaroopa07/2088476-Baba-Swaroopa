using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
namespace BookStore.Models
{
    public class Books
    {
        public int Id { get; set; }
        [Required, StringLength(20)]
        public string Title { get; set; }
        public double Price { get; set; }
    }
}
