using MediatR;
using JomarHealthCare.Application.DataModels.Staff;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record UpdateCandidateInterviewCommand(CandidateInterviewDataModel DataModel) : IRequest<bool>;
}
