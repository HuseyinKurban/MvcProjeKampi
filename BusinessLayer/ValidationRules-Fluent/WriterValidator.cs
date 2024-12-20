using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules_Fluent
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        private bool IsAboutValid(string arg)
        {
            try
            {
                Regex regex = new Regex(@"^(?=.*[a,A])");
                return regex.IsMatch(arg);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazarın Adını Boş Geçemezsiniz.");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazarın Soyadını Boş Geçemezsiniz.");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Yazarın Mailini Boş Geçemezsiniz.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Yazarın Şifresini Boş Geçemezsiniz.");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Yazarın Hakkında Bilgisini Boş Geçemezsiniz.");

            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen 50 Karakterden Fazla Değer Girişi Yapmayınız.");
            RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("Lütfen 50 Karakterden Fazla Değer Girişi Yapmayınız.");
            RuleFor(x => x.WriterAbout).MaximumLength(100).WithMessage("Lütfen 100 Karakterden Fazla Değer Girişi Yapmayınız.");

            RuleFor(x => x.WriterAbout).Must(IsAboutValid).WithMessage("Hakkında kısmında en az bir defa a harfi kullanılmalıdır");



        }
    }
}
