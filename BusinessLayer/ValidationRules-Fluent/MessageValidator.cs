using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules_Fluent
{
    public class MessageValidator :AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Mail Adresini Boş Geçemezsiniz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu Boş Geçemezsiniz.");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesaj İçeriğini Boş Geçemezsiniz.");

            RuleFor(x => x.ReceiverMail).MaximumLength(50).WithMessage("Mail Adresine 50 Karakterden Fazla Değer Girişi Yapmayınız.");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Konuya 50 Karakterden Fazla Değer Girişi Yapmayınız.");

            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("E-posta adresi boş olamaz.").EmailAddress().WithMessage("Geçersiz e-posta adresi.");
        }
    }
}
