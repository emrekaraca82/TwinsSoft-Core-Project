using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
    public class SettingValidator : AbstractValidator<Setting>
    {
        public SettingValidator()
        {
            RuleFor(p => p.Adres).NotEmpty();
            RuleFor(p => p.Gsm).MinimumLength(10);         
        }
    }
}
