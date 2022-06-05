using HotelSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSearch.Data.Repositories.Interfaces
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(HotelSearchContext context) : base(context)
        {
        }

        public void Remove(IEnumerable<User> user)
        {
            throw new NotImplementedException();
        }
    }
}
