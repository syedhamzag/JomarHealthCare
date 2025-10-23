using MediatR;

namespace JomarHealthCare.Application.CQRS.Client.Commands.ClientHobbies;


public class AddClientHobbiesListCommand : IRequest<List<Domain.Entities.ClientHobbies>>
{
    public List<AddClientHobbiesCommand> Commands { get; set; }
}

public class AddClientHobbiesCommand
{
    public int CHId { get; set; }
    public int HId { get; set; }
    public Guid? ClientId { get; set; }
}



public class DeleteClientHobbiesCommand : IRequest<bool>
{
    public int Id { get; set; }
}