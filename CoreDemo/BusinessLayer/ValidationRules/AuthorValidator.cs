using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AuthorValidator:AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.AuthorName).NotEmpty().WithMessage("Yazar Adı Soyadı kısmı boş geçilemez !");

            RuleFor(x => x.AuthorMail).NotEmpty().WithMessage("Yazar Mail adresi boş geçilemez !");

            RuleFor(x => x.AuthorPassword).NotEmpty().WithMessage("Şifre alanı boş geçilemez !");

            RuleFor(x => x.AuthorName).MinimumLength(2).WithMessage("En az 2 karakter kullanılmalıdır !");

            RuleFor(x => x.AuthorName).MaximumLength(50).WithMessage("En fazla 50 karakter kullanabilirsiniz !");

            RuleFor(x => x.AuthorPassword).Matches(@"[A-Z]+").WithMessage("Şifreniz en az 1 Büyük harf içermelidir");

            RuleFor(x => x.AuthorPassword).Matches(@"[a-z]+").WithMessage("Şifreniz en az 1 Küçük harf içermelidir");

            RuleFor(x => x.AuthorPassword).Matches(@"[0-9]+").WithMessage("Şifreniz en az 1 sayı içermelidir");


        }
    }
} 
