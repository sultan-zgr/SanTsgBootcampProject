using HotelSearch.Application.Interfaces;
using HotelSearch.Domain.Entities;
using HotelSearch.Data;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using HotelSearch.Application.Models;

namespace HotelSearch.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUow _uow;
        private readonly IEmailServices _emailServices;
        private readonly ILogger<UserService> _logger;

        public UserService(IUow uow, IEmailServices emailServices, ILogger<UserService> logger )
        {
            _uow = uow;
            _emailServices = emailServices;
            _logger = logger;
        }

        public async Task CreateUser(User user)
        {
            _uow.Users.Add(user);

            MailRequest mail = new MailRequest();
            {
               
            };
          

            await _emailServices.SendEmailAsync(mail);
            _uow.Complete();
            _logger.LogInformation("Eklendi {@user}", user);
        }


    }

  
    
 
}

