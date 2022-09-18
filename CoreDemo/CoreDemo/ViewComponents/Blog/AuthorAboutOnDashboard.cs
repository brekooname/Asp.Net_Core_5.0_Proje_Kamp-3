using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreDemo.ViewComponents.Blog
{
    public class AuthorAboutOnDashboard : ViewComponent
    {
        AuthorManager auther = new AuthorManager(new EfAuthorRepository());

        public IViewComponentResult Invoke()
        {
            var values = auther.GetAuthorById(1);
            return View(values);
        }
    }
}

