using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Client.Commands.InvolvingParty;

public class AddClientInvolvingPartyCommand : IRequest<ClientInvolvingParty>
{
    public string ClientInvolvingPartyItem { get; set; }

    public string Name { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string Telephone { get; set; }
    public string Relationship { get; set; }

    public Guid? ClientId { get; set; }
}


public class DeleteClientInvolvingPartyCommand : IRequest<bool>
{
    public int Id { get; set; }
}

public class UpdateClientInvolvingPartyCommand : IRequest<bool>
{
    public int ClientInvolvingPartyId { get; set; }
    public string ClientInvolvingPartyItem { get; set; }

    public string Name { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string Telephone { get; set; }
    public string Relationship { get; set; }

    public Guid? ClientId { get; set; }
}
