using HotelSearch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HotelSearch.Application.Interfaces
{
    public interface IUserService
    {
        Task CreateUser(User user);
    }
}
