using MediatR;
using JomarHealthCare.Application.DataModels.Client.InvoiceRate;

namespace JomarHealthCare.Application.CQRS.Client.Queries.InvoiceRate;
public record GetClientInvoiceRateByIdQuery(int id) : IRequest<ClientInvoiceRateDataModel>;

public record GetAllClientInvoiceRateByClientQuery(Guid clientId) : IRequest<List<ClientInvoiceRateDataModel>>;