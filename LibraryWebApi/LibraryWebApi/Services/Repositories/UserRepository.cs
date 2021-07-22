using LibraryWebApi.Contexts;
using LibraryWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryWebApi.Services.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly LibraryContext _context;

        public UserRepository(LibraryContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<User> GetAdminUsers()
        {
            return _context.Users
                .Where(u => u.IsAdmin && (u.Deleted == false || u.Deleted == null))
                .ToList();
        }
    }
}
