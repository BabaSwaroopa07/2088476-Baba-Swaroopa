using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
namespace BookStore.Models
{
    public class BooksDbContext : DbContext
    {
        public virtual DbSet<Books> Books { get; set; }
        public BooksDbContext(DbContextOptions<BooksDbContext> options) : base(options)
        {

        }
    }
}
