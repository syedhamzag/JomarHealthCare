using MediatR;
using JomarHealthCare.Application.DataModels.Client.InvoiceRate;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.InvoiceRate;

internal class GetClientInvoiceRateByIdQueryHandler : IRequestHandler<GetClientInvoiceRateByIdQuery, ClientInvoiceRateDataModel>
{
    private readonly IClientInvoiceRateRepository _repository;

    public GetClientInvoiceRateByIdQueryHandler(IClientInvoiceRateRepository repository)
    {
        _repository = repository;
    }

    public async Task<ClientInvoiceRateDataModel> Handle(GetClientInvoiceRateByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.id, cancellationToken);
        if (entity == null)
        {
            throw new KeyNotFoundException("Not found");
        }
        return new ClientInvoiceRateDataModel
        {
            Id = entity.Id,
            ServiceType = entity.ServiceType,
            Period = entity.Period,
            Rate = entity.Rate,
            ClientId = entity.ClientId,
        };
    }
}