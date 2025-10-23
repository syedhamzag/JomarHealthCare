using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.StaffModule.Commands.CommandDtos;


public class AddJobCategoryCommand : IRequest<CategoryOfStaff>
{
    public string Name { get; set; }
    public Guid? CompanyId { get; set; }
}


public class DeleteJobCategoryCommand : IRequest<bool>
{
    public int Id { get; set; }
}

public class UpdateJobCategoryCommand : IRequest<bool>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Guid? CompanyId { get; set; }
}