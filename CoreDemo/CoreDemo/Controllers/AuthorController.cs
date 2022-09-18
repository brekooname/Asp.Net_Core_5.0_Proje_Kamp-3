using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using FluentValidation.Results;
using ValidationResult = FluentValidation.Results.ValidationResult;
using System.IO;
using CoreDemo.Models;
using System;

namespace CoreDemo.Controllers
{
    public class AuthorController : Controller
    {
        AuthorManager manager = new AuthorManager(new EfAuthorRepository());

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }

        [AllowAnonymous]

        public PartialViewResult AuthorNavBar()
        {
            return PartialView();
        }

        [AllowAnonymous]

        public PartialViewResult AuthorFooterPartial()
        {
            return PartialView();
        }


        [AllowAnonymous]
        [HttpGet]
        public IActionResult AuthorEditProfile()
        {
            var values = manager.GetById(1);
            return View(values);
        }

        [AllowAnonymous]

        [HttpPost]
        public IActionResult AuthorEditProfile(Author p)
        {
            AuthorValidator av = new AuthorValidator();

           ValidationResult results = av.Validate(p);


            if(results.IsValid)
            {
                manager.Update(p);
                return RedirectToAction("Index","Dashboard");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

                return View();
            }
        
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult AuthorAdd()
        {
            return View();
        }


        [AllowAnonymous]
        [HttpPost]
        public IActionResult AuthorAdd(AddProfileImage img)
        {
            Author au = new Author();

            if(img.AuthorImage != null)
            {
                var extension = Path.GetExtension(img.AuthorImage.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/AuthorImageFile/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                img.AuthorImage.CopyTo(stream);
                au.AuthorImage = newimagename;            
            }

            au.AuthorName = img.AuthorName;
            au.AuthorMail = img.AuthorMail;
            au.AuthorPassword = img.AuthorPassword;
            au.AuthorStatus = true;
            au.AuthorAbout = img.AuthorAbout;

            manager.Add(au);
            return View();
        }


    }
}
