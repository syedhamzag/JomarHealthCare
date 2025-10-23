using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.DataModels.Client.Program;

namespace JomarHealthCare.Application.CQRS.Client.Commands.Program;

public record CreateClientProgramCommand(ClientProgramDataModel DataModel) : IRequest<ClientProgramDataModel>;
public record UpdateClientProgramCommand(ClientProgramDataModel DataModel) : IRequest<bool>;

public class DeleteClientProgramCommand : IRequest<bool>
{
    public int Id { get; set; }
}