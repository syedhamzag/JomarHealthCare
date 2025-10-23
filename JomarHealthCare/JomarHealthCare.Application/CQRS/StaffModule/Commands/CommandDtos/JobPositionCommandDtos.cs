using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.StaffModule.Commands.CommandDtos;


public class AddJobPositionCommand : IRequest<JobPosition>
{
    public string Name { get; set; }
    public Guid? CompanyId { get; set; }
}


public class DeleteJobPositionCommand : IRequest<bool>
{
    public int Id { get; set; }
}

public class UpdateJobPositionCommand : IRequest<bool>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Guid? CompanyId { get; set; }
}