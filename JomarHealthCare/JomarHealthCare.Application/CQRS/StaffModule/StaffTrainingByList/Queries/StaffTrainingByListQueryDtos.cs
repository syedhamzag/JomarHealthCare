using MediatR;
using JomarHealthCare.Application.DataModels.Staff;

namespace JomarHealthCare.Application.CQRS.Staff.Queries;


public record GetStaffTrainingByListByIdQuery() : IRequest<StaffTrainingByListDataModel>
{
    public int Id { get; set; }
}
public record GetAllStaffTrainingByListByIdQuery() : IRequest<List<StaffTrainingByListDataModel>>
{
    public Guid StaffPersonalInfoId { get; set; }
}