using MediatR;
using JomarHealthCare.Application.DataModels.Client.BillTo;

namespace JomarHealthCare.Application.CQRS.Client.Queries.BillTo;

public record GetClientBillToByIdQuery(int id) : IRequest<ClientBillToDataModel>;

public record GetAllClientBillToByClientQuery(Guid clientId) : IRequest<List<ClientBillToDataModel>>;