using HotelSearch.Application.Interfaces;
using HotelSearch.Data;
using HotelSearch.Data.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelSearch.Web.Controllers
{
    public class HotelController : Controller
    {
        private string token = "";
        private readonly HotelSearchContext _context;
        private readonly IEmailServices _emailservices;
        private readonly ILogger<HotelController> _logger;

       List<string> cities = new List<string>();
        public HotelController(HotelSearchContext context, ILogger<HotelController> logger, IEmailServices emailservices)
        {
            _context = context;
            _logger = logger;
            _emailservices = emailservices;
            login();
        }  
        void login()
        {
            Models.Request.Authentication.LoginRequest request = new Models.Request.Authentication.LoginRequest();
            request.Agency = "PXM25397";
            request.User = "USR1";
            request.Password = "test!23";
            Models.Response.Authentication.LoginResponse response = Api.Post<Models.Response.Authentication.LoginResponse>(Global.LoginUrl, request);
            this.token = response.body.token;

            //CookieOptions cookie = new CookieOptions();
            //cookie.Expires = DateTime.Now.AddYears(10);
            //Response.Cookies.Append("token", token, cookie); 
        }
   
        public IActionResult Index()
        {
            string t2 = Request.Cookies["token"];


            Models.Request.HotelProduct.GetArrivalAutocompleteRequest request = new Models.Request.HotelProduct.GetArrivalAutocompleteRequest();
            request.Culture = "en-US";
            request.ProductType = 2;
            request.Query = "anta";

            Models.Response.HotelProduct.GetArrivalAutocompleteResponse response = Api.Post<Models.Response.HotelProduct.GetArrivalAutocompleteResponse>(Global.GetArrivalautocompleteUrl, request, token);

            var myList = response.body.items.Where(a => a.country.id.Equals("TR"));
 

            foreach (var item in myList)
            {
                cities.Add(item.city.name);
            }
      
            return View(response);
        }

        public IActionResult HotelList(string City, string Country)
        {

            Models.Request.HotelProduct.GetArrivalAutocompleteRequest request = new Models.Request.HotelProduct.GetArrivalAutocompleteRequest();
            request.Culture = "en-US";
            request.ProductType = 2;
            request.Query = "anta";

            Models.Response.HotelProduct.GetArrivalAutocompleteResponse response = Api.Post<Models.Response.HotelProduct.GetArrivalAutocompleteResponse>(Global.GetArrivalautocompleteUrl, request, token);

            var myList = response.body.items.Where(a => a.type == 2 && a.country.name.Equals(Country)).ToList();

 

            return View(myList);
        }


        public JsonResult CityList()
        {
            return Json(cities);
        }
 
    }
}
