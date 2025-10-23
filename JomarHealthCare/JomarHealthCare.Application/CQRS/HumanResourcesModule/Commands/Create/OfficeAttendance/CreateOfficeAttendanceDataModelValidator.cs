using FluentValidation;

namespace JomarHealthCare.Application.Validators.HumanResourcesModule
{
    public class CreateOfficeAttendanceDataModelValidator : AbstractValidator<CreateOfficeAttendanceCommand>
    {
        public CreateOfficeAttendanceDataModelValidator()
        {
            RuleFor(x => x.DataModel.Date).NotEmpty();
            RuleFor(x => x.DataModel.JobTitle).NotEmpty().MaximumLength(100);
            RuleFor(x => x.DataModel.Location).NotEmpty().MaximumLength(255);
        }
    }
}
