using HotelSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSearch.Data.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {

        void Remove(IEnumerable<User> user);
        void Update(User user);
    }
}
