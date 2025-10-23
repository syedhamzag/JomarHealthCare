using MediatR;
using JomarHealthCare.Application.DataModels.HumanResourcesModule.Complaints;

namespace JomarHealthCare.Application.CQRS.HumanResourcesModule.Queries;


public record GetByCompanyComplainRegisterQuery(Guid companyId) : IRequest<List<ComplainRegistorDataModel>>;
public record GetByIdComplainRegisterQuery(int id) : IRequest<ComplainRegistorDataModel>;

public record GetByClientComplainRegisterQuery(Guid clientId) : IRequest<List<ComplainRegistorDataModel>>;
