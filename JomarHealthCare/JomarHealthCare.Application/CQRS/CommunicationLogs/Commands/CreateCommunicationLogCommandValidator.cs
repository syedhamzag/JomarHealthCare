using FluentValidation;

namespace JomarHealthCare.Application.CQRS.CommunicationLogs.Commands
{
    public class CreateCommunicationLogCommandValidator : AbstractValidator<CreateCommunicationLogCommand>
    {
        public CreateCommunicationLogCommandValidator()
        {
            RuleFor(x => x.DataModel.MeetingTitle).NotEmpty();
            RuleFor(x => x.DataModel.Date).NotEmpty();
            RuleFor(x => x.DataModel.Status).GreaterThan(0);
        }
    }

}