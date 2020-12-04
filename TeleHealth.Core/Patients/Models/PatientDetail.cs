using FluentValidation;

namespace TeleHealth.Core.Patients.Models
{
    public class PatientDetail
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Gender { get; set; }

    }

    public class PatientValidator : AbstractValidator<PatientDetail>
    {
        public PatientValidator()
        {
            RuleFor(x => x.Firstname).NotEmpty().WithMessage("Please specify a first name");
            RuleFor(x => x.Lastname).NotEmpty().WithMessage("Please specify a last name");
            RuleFor(x => x.Gender).NotNull().WithMessage("Please choose a Gender");
        }
    }
}
