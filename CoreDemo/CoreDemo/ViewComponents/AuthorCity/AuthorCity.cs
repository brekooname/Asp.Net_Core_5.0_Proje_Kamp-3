using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.ViewComponents.AuthorCity
{
    public class AuthorCity : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var authorCity = new List<AuthorCityModel>
            {
                new AuthorCityModel
                {
                    City = "Kütahya",
                },

                new AuthorCityModel
                {
                    City = "İstanbul",
                },

                new AuthorCityModel
                {
                    City = "Ankara",
                },
                new AuthorCityModel
                {
                    City = "Çanakkale",
                },
                new AuthorCityModel
                {
                    City = "Diyarbakır",
                },
                new AuthorCityModel
                {
                    City = "Rize",
                },
                new AuthorCityModel
                {
                    City = "Muş",
                }

            };
            return View(authorCity);
        }
    }
}
