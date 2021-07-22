using LibraryWebApi.Contexts;
using LibraryWebApi.Entities;
using System;

namespace LibraryWebApi.Services.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        private readonly LibraryContext _context;

        public AuthorRepository(LibraryContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
    }
}