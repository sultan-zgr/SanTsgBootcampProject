using HotelSearch.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HotelSearch.Application.Interfaces
{
    public interface IEmailServices
    { 
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
