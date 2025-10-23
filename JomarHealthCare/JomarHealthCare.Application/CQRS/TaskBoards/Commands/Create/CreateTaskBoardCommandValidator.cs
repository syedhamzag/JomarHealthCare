using FluentValidation;

namespace JomarHealthCare.Application.CQRS.TaskBoards.Commands
{
    public class CreateTaskBoardCommandValidator : AbstractValidator<CreateTaskBoardCommand>
    {
        public CreateTaskBoardCommandValidator()
        {
            RuleFor(x => x.DataModel.TaskName).NotEmpty();
            RuleFor(x => x.DataModel.CompletionDate).NotEmpty();
            RuleFor(x => x.DataModel.ClientId).NotEmpty();
            RuleFor(x => x.DataModel.Status).GreaterThan(0);
        }
    }

}