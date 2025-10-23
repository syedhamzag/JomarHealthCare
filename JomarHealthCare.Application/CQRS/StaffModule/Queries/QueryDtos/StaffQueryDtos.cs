using MediatR;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.DataModels.StaffModule.StaffJobPosition;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.StaffModule.Queries.QueryDtos;

public record GetAllStaffByCompanyIdQuery(Guid companyId) : IRequest<List<GetStaffByCompanyDataModel>>;
public record GetAllUserByCompanyIdQuery(Guid companyId) : IRequest<List<ApplicationUserDto>>;