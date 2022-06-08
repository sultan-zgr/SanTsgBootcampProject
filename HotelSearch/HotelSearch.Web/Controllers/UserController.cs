using HotelSearch.Data;
using HotelSearch.Data.Repositories.Interfaces;
using HotelSearch.Domain.Entities;
using HotelSearch.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace HotelSearch.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly HotelSearchContext _context;
        private readonly ILogger<UserController> _logger;
             
        public UserController(IUserRepository UserRepository, HotelSearchContext context, ILogger<UserController> logger)
        {
            _userRepository = UserRepository;
            _context = context;
            _logger = logger;
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
        public IActionResult Create(User user)
        {

            if (ModelState.IsValid)
            {
                _userRepository.Add(user);
                _userRepository.SaveAll("Index");
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
