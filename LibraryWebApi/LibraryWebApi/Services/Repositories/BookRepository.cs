using LibraryWebApi.Contexts;
using LibraryWebApi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace LibraryWebApi.Services.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        private readonly LibraryContext _context;

        public BookRepository(LibraryContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Book GetBookDetails(Guid bookId)
        {
            return _context.Books
                .Where(b => b.Id == bookId && (b.Deleted == false || b.Deleted == null))
                .Include(b => b.Author)
                .FirstOrDefault();
        }
    }
}
