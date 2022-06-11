using HotelSearch.Application.Interfaces;
using HotelSearch.Application.Models;
using HotelSearch.Data;
using HotelSearch.Data.Repositories.Interfaces;
using HotelSearch.Domain.Entities;
using HotelSearch.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace HotelSearch.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly HotelSearchContext _context;
        private readonly IEmailServices _emailservices;
        private readonly ILogger<UserController> _logger;

        public UserController(IUserRepository UserRepository, HotelSearchContext context, ILogger<UserController> logger, IEmailServices emailservices)
        {
            _userRepository = UserRepository;
            _context = context;
            _logger = logger;
            _emailservices = emailservices;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Sayfa başarılı açıldı");

            var user = _userRepository.GetAll();
            return View(user);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            MailRequest mail = new MailRequest()
            {
                Body = "Kaydiniz basariyla alinmistir",
                Subject = "DiyetisyeniSec Kayit Onayi",
                ToEmail = user.Email

            };


            if (ModelState.IsValid)
            {
                user.Registration = DateTime.Now;
                _userRepository.Add(user);
                _userRepository.SaveAll("Index");
                await _emailservices.SendEmailAsync(mail);
            }
            return View(user);
        }
        public IActionResult Edit(int id)
        {
            var user = _userRepository.Get(id);

            if (user == null)
            {
                return NotFound();
            }
            else
            {
                _userRepository.Update(user);
            }
                

          
            return View(user);
        }
        [HttpPost]
        public IActionResult Edit(User user)
        {
           if (ModelState.IsValid)
            {
                _userRepository.Update(user);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
           

        }
        public IActionResult Delete(int id)
        {
            var user = _userRepository.Get(id);
            return View(user);
        }
        [HttpPost, ActionName("Delete")]

        public IActionResult DeletePost(int id)
        {
            var data = _userRepository.Get(id);

            if (data == null)
                return NotFound();

            _userRepository.Remove(data);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
       
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
