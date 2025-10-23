using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Hobby.Commands;

public class AddHobbyCommand : IRequest<Hobbies>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Guid? CompanyId { get; set; }
}


public class DeleteHobbyCommand : IRequest<bool>
{
    public int HobbyId { get; set; }
}

public class UpdateHobbyCommand : IRequest<bool>
{
    public int HId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Guid? CompanyId { get; set; }
}
