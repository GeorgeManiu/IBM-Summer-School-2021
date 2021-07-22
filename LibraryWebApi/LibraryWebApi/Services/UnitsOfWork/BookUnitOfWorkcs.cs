using LibraryWebApi.Contexts;
using LibraryWebApi.Services.Repositories;
using System;

namespace LibraryWebApi.Services.UnitsOfWork
{
    public class BookUnitOfWork : IBookUnitOfWork
    {
        private readonly LibraryContext _context;

        public BookUnitOfWork(LibraryContext context, IBookRepository books,
            IAuthorRepository authors, IEditorRepository editors)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            Books = books ?? throw new ArgumentNullException(nameof(context));
            Authors = authors ?? throw new ArgumentNullException(nameof(context));
            Editors = editors ?? throw new ArgumentNullException(nameof(context));
        }

        public IBookRepository Books { get; }

        public IAuthorRepository Authors { get; }

        public IEditorRepository Editors { get; }


        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
