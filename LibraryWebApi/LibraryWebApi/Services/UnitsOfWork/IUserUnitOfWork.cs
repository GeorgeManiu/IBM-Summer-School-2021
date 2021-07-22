using LibraryWebApi.Services.Repositories;
using System;

namespace LibraryWebApi.Services.UnitsOfWork
{
    public interface IUserUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }

        int Complete();
    }
}
