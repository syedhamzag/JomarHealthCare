using MediatR;
using JomarHealthCare.Application.DataModels.Hobby;

namespace JomarHealthCare.Application.CQRS.Hobby.Queries;


public record GetHobbyByIdQuery(int HId) : IRequest<HobbyDataModel>;

public record GetAllHobbyQuery() : IRequest<List<HobbyDataModel>>;

public record GetAllHobbyByCompanyIdQuery(Guid companyId) : IRequest<List<HobbyDataModel>>;
