using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog Başlığını Boş Geçemezsiniz !");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog İçeriğini Boş Geçemezsiniz !");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog Görselini Boş Geçemezsiniz !");
            RuleFor(x => x.BlogTitle).MaximumLength(75).WithMessage("Blog Başlığı Maksimum 75 Karakter Olabilir ! ");
            RuleFor(x => x.BlogTitle).MinimumLength(4).WithMessage("Blog Başlığı Minimum 4 Karakter Olabilir ! ");
            RuleFor(x => x.BlogContent).MinimumLength(40).WithMessage("Blog İçeriği Minimum 40 Karakter Olabilir ! ");

        }
    }
}
