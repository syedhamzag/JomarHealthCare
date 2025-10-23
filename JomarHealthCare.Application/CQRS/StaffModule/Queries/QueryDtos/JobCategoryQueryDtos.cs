using MediatR;
using JomarHealthCare.Application.DataModels.StaffModule.StaffJobCategory;

namespace JomarHealthCare.Application.CQRS.StaffModule.Queries.QueryDtos;

public record GetJobCategoryByIdQuery(int id) : IRequest<JobCategoryDataModel>;

public record GetAllJobCategoryQuery() : IRequest<List<JobCategoryDataModel>>;

public record GetAllJobCategoryCompanyIdQuery(Guid companyId) : IRequest<List<JobCategoryDataModel>>;
