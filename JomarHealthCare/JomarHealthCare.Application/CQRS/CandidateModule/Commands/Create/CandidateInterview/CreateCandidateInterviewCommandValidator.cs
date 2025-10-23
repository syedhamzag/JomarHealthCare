using FluentValidation;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
 public class CreateCandidateInterviewCommandValidator : AbstractValidator<CreateCandidateInterviewCommand>
    {
        public CreateCandidateInterviewCommandValidator()
        {
            RuleFor(x => x.DataModel.StaffId).NotEmpty();
            RuleFor(x => x.DataModel.JobPositionId).GreaterThan(0);
            RuleFor(x => x.DataModel.InterviewType).IsInEnum();
        }
    }
}
