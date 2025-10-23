using FluentValidation;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffTrainingByListCommandValidator : AbstractValidator<CreateStaffTrainingByListCommand>
    {
        public CreateStaffTrainingByListCommandValidator()
        {
            RuleFor(x => x.DataModel.Trainer).NotEmpty();
            RuleFor(x => x.DataModel.StartDate).NotEmpty();
            RuleFor(x => x.DataModel.Training).NotEmpty();
            RuleFor(x => x.DataModel.TrainingType).NotEmpty();
            RuleFor(x => x.DataModel.ExpiredDate).NotEmpty();
        }
    }

}