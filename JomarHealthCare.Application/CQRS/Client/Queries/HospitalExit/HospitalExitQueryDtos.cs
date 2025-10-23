using MediatR;
using JomarHealthCare.Application.DataModels.Client.HospitalExit;

namespace JomarHealthCare.Application.CQRS.Client.Queries.HospitalExit;

public record GetByClientHospitalExitQuery(Guid clientId) : IRequest<List<HospitalExitDataModel>>;
public record GetByIdClienHospitalExitQuery(int id) : IRequest<HospitalExitDataModel>;