using MediatR;
using JomarHealthCare.Application.DataModels.StaffModule.StaffJobPosition;
using JomarHealthCare.Application.DataModels.Territory;

namespace JomarHealthCare.Application.CQRS.StaffModule.Queries.QueryDtos;
public record GetJobPositionByIdQuery(int id) : IRequest<JobPositionDataModel>;

public record GetAllJobPositionQuery() : IRequest<List<JobPositionDataModel>>;

public record GetAllJobPositionCompanyIdQuery(Guid companyId) : IRequest<List<JobPositionDataModel>>;