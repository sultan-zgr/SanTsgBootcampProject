using HotelSearch.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSearch.Data
{
    public interface IUow : IDisposable
    {
        public IUserRepository Users { get; }
        void Complete();
    }
  
    
}