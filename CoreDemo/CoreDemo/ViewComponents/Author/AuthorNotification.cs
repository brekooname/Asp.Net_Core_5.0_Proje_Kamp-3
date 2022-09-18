using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Author
{
    public class AuthorNotification : ViewComponent
    {
        NotificationManager nm = new NotificationManager(new EfNotificationRepository());
    
    
        public IViewComponentResult Invoke()
        {
            var values = nm.GetList();
            return View(values);
        }
    }
}
