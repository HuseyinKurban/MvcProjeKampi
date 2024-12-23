using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules_Fluent
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator() 
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adını Boş Geçemezsiniz.");
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail Adresini Boş Geçemezsiniz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu Boş Geçemezsiniz.");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Mail İçeriğini Boş Geçemezsiniz.");

            RuleFor(x => x.UserName).MaximumLength(50).WithMessage("Kullanıcı Adına 50 Karakterden Fazla Değer Girişi Yapmayınız.");
            RuleFor(x => x.UserMail).MaximumLength(50).WithMessage("Mail Adresine 50 Karakterden Fazla Değer Girişi Yapmayınız.");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Konuya 50 Karakterden Fazla Değer Girişi Yapmayınız.");
        }     
    }
}
