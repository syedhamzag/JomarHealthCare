using FluentValidation;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateInterviewQuestionCommandValidator : AbstractValidator<CreateInterviewQuestionCommand>
    {
        public CreateInterviewQuestionCommandValidator()
        {
            RuleFor(x => x.DataModel.Question).NotEmpty();
            RuleFor(x => x.DataModel.JobPosition).GreaterThan(0);
            RuleFor(x => x.DataModel.InterviewType).IsInEnum();
        }
    }

}
