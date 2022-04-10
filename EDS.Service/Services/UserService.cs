using EDS.Core.DTOs;
using EDS.Repository;
using System.Collections.Generic;
using System.Linq;

namespace EDS.Service.Services
{
    public class UserService
    {
        private readonly AppDbContext _context;
        public UserService()
        {
            _context = new AppDbContext();
        }
        public IQueryable<UserDto> All()
        {
            var result = from u in _context.Users
                         select new UserDto
                         {
                             FirstName = u.FirstName,
                             LastName = u.LastName,
                             EMail = u.EMail,
                             UserName = u.UserName,
                             Password = u.Password,
                             CreatedOn = u.CreatedOn
                         };
            return result;
        }
    }
}
