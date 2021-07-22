using LibraryWebApi.Services.Repositories;
using System;

namespace LibraryWebApi.Services.UnitsOfWork
{
    public interface IBookUnitOfWork : IDisposable
    {
        IBookRepository Books { get; }

        IAuthorRepository Authors { get; }

        IEditorRepository Editors { get; }


        int Complete();
    }
}
