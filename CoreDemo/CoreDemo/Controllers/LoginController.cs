using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class LoginController : Controller
    {

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [AllowAnonymous]

        public async Task<IActionResult> Index(Author a)
        {
            Context cc = new Context();
            var dataValue = cc.Authors.FirstOrDefault(x => x.AuthorMail == a.AuthorMail && x.AuthorPassword == a.AuthorPassword);

            if (dataValue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, a.AuthorMail)
                };

                var useridentity = new ClaimsIdentity(claims,"user");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index","Author");
               
            }
            else
            {
                return View();
            }

        }
    }
}







//Context cc = new Context();
//            var dataValue = cc.Authors.FirstOrDefault(x => x.AuthorMail == a.AuthorMail && x.AuthorPassword == a.AuthorPassword);

//            if (dataValue != null)
//            {

//                HttpContext.Session.SetString("username", a.AuthorMail);
//                return RedirectToAction("Index", "Author");
//            }
//            else
//            {
//                return View();
//            }
