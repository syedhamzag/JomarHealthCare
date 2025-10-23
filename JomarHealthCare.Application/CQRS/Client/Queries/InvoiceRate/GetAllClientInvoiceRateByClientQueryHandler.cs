using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Client.InvoiceRate;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.InvoiceRate;


internal class GetAllClientInvoiceRateByClientQueryHandler : IRequestHandler<GetAllClientInvoiceRateByClientQuery, List<ClientInvoiceRateDataModel>>
{
    private readonly IClientInvoiceRateRepository _repository;

    public GetAllClientInvoiceRateByClientQueryHandler(IClientInvoiceRateRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<ClientInvoiceRateDataModel>> Handle(GetAllClientInvoiceRateByClientQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.ClientId == request.clientId && !x.IsDeleted).ToListAsync(); // This method should return all records.

        return entities.Select(entity => new ClientInvoiceRateDataModel
        {
            Id = entity.Id,
            ServiceType = entity.ServiceType,
            Period = entity.Period,
            Rate = entity.Rate,
            ClientId = entity.ClientId
        }).ToList();
    }
}