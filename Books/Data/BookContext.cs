using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Models;

namespace Books.Data
{
	public class BookContext : DbContext
	{
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
        }

        public DbSet<Books.Models.Book> Book { get; set; } = default!;
    }
}

