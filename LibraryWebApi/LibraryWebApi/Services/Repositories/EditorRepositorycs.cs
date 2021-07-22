using LibraryWebApi.Contexts;
using LibraryWebApi.Entities;
using System;

namespace LibraryWebApi.Services.Repositories
{
    public class EditorRepository : Repository<Editor>, IEditorRepository
    {
        private readonly LibraryContext _context;

        public EditorRepository(LibraryContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
    }
}