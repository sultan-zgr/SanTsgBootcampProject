using HotelSearch.Data.Repositories.Interfaces;
using HotelSearch.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HotelSearch.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository UserRepository)
        {
            _userRepository = UserRepository;
        }

        public IActionResult Index()
        {
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
                return NotFound();

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
            var user = _userRepository.Get(id);

            _userRepository.Remove(user);
            _userRepository.SaveAll("Index");

            return RedirectToAction("Index");
        }
    }
}
