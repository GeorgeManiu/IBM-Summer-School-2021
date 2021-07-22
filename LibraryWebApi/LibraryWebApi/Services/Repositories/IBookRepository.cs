using LibraryWebApi.Entities;
using System;

namespace LibraryWebApi.Services.Repositories
{
    public interface IBookRepository : IRepository<Book>
    {
        Book GetBookDetails(Guid bookId);
    }
 }