using DailyApp.Security.User.Validators;
using FluentValidation;

namespace DailyApp.Security.User.Registration
{
    public class RegistrationValidation : AbstractValidator<RegistrationCommand>
    {
		public RegistrationValidation()
		{
			RuleFor(x => x.DisplayName).NotEmpty();
			RuleFor(x => x.UserName).NotEmpty();
			RuleFor(x => x.Email).NotEmpty().EmailAddress();
			RuleFor(x => x.Password).NotEmpty().Password();
		}
	}
}
