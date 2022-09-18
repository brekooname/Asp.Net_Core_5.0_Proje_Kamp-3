using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class NewsLetterController : Controller
    {

        NewsLetterManager nl = new NewsLetterManager( new EfNewsLetterRepository());


        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult SubscribeMail(NewsLetter news)
        {
            news.MailStatus = true;     
            //Id oto artıyor, maili kullanıcı news parametresi ile yolluyor vt ye kaydoluyor biz de manuel olarak statusu true yapıyoruz.
            nl.AddNewsLetter(news);
            return PartialView();
        }
    }
}
