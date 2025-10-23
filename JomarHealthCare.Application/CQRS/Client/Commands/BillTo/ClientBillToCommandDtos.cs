using MediatR;
using JomarHealthCare.Application.DataModels.Client.BillTo;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Client.Commands.BillTo;

public class CreateClientBillToCommand : IRequest<ClientBillTo>
{
    public string Email { get; set; }
    public string BillTo { get; set; }

    public Guid? ClientId { get; set; }
}
public class UpdateClientBillToCommand() : IRequest<bool>
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string BillTo { get; set; }
    public Guid? ClientId { get; set; }
}

public class DeleteClientBillToCommand : IRequest<bool>
{
    public int Id { get; set; }
}
