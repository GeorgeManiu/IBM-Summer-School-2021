using LibraryWebApi.Entities;
using System.Collections.Generic;

namespace LibraryWebApi.Services.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<User> GetAdminUsers();
    }
}

