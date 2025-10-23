using MediatR;
using JomarHealthCare.Application.DataModels.Client.Medication;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Medication;

public record GetAllClientMedicationByClientQuery(Guid clientId) : IRequest<List<GetClientMedicationDataModel>>;

public record GetByIdClientMedicationQuery(int id) : IRequest<ClientMedicationDataModel>;