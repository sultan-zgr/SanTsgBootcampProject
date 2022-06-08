using HotelSearch.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSearch.Data
{
    public interface IUw : IDisposable
    {
        public IUserRepository UserRepository { get; }
        void Complete();
    }

    public class Uow : IUow
    {
        private readonly HotelSearchContext _context;

        public IUserRepository Users { get; private set; }

        public Uow(HotelSearchContext context)
        {
            _context = context;
            Users = new UserRepository(context);
        }

        public void Complete()
        {
           _context.SaveChanges();
        }

        public void Dispose()
        {
           _context?.Dispose(); 
        }
    }
}
