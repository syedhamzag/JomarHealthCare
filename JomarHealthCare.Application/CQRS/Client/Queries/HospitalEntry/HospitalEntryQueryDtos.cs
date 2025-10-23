using MediatR;
using JomarHealthCare.Application.DataModels.client.HospitalEntry;

namespace JomarHealthCare.Application.CQRS.Client.Queries.HospitalEntry;


public record GetByClientHospitalEntryQuery(Guid clientId) : IRequest<List<HospitalEntryDataModel>>;
public record GetByIdClienHospitalEntryQuery(int id) : IRequest<HospitalEntryDataModel>;
