using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        AuthorManager au = new AuthorManager(new EfAuthorRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(Author author)
        {

            AuthorValidator ar = new AuthorValidator();

            ValidationResult results = ar.Validate(author);

            if (results.IsValid)
            {
                author.AuthorStatus = true;
                author.AuthorAbout = "Honurbu";
                au.Add(author);
                return RedirectToAction("Index", "Blog");
            }

            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();

            
        }
    }
}
