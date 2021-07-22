using LibraryWebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryWebApi.Contexts
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
          : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Editor> Editors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}

