using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        Context c = new Context();
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var values = bm.GetBlogByID(id);
            return View(values);
        }

        public IActionResult BlogListByAuthor()
        {
            var values = bm.GetListWithCategoryByAuthorBm(1);
            return View(values);
        }


        [HttpGet]
        public IActionResult BlogAdd()
        {

            List<SelectListItem> categoryValue = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString(),                                                                                                        

                                                  }).ToList();

            ViewBag.cv = categoryValue;
            return View();
        }

        [HttpPost]
        public IActionResult BlogAdd(Blog blog)
        {
            BlogValidator bv = new BlogValidator();

            ValidationResult results = bv.Validate(blog);

            if (results.IsValid)
            {
                blog.BlogStatus = true;
                blog.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                blog.AuthorID = 1;
                bm.Add(blog);
                return RedirectToAction("BlogListByAuthor", "Blog");
            }

            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }

        public IActionResult DeleteBlog(int id)
        {
            var blogValue = bm.GetById(id);
            bm.Delete(blogValue);

            return RedirectToAction("BlogListByAuthor");
        }

        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            var values = bm.GetById(id);

            List<SelectListItem> categoryValue = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString(),

                                                  }).ToList();

            ViewBag.cv = categoryValue;
            
            return View(values);
        }

        [HttpPost]
        public IActionResult EditBlog(Blog blog)
        {

           
            var blogValue = bm.GetById(blog.BlogID);

            blog.AuthorID = 1;
            //blog.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            blog.BlogCreateDate = DateTime.Parse(blogValue.BlogCreateDate.ToShortDateString());
            blog.BlogStatus = true;
            bm.Update(blog);
            return RedirectToAction("BlogListByAuthor");
        }

    }
}
