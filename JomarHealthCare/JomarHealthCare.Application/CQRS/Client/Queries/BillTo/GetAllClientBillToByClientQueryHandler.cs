using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Client.BillTo;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.BillTo;

internal class GetAllClientBillToByClientQueryHandler : IRequestHandler<GetAllClientBillToByClientQuery, List<ClientBillToDataModel>>
{
    private readonly IClientBillToRepository _repository;

    public GetAllClientBillToByClientQueryHandler(IClientBillToRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<ClientBillToDataModel>> Handle(GetAllClientBillToByClientQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.ClientId == request.clientId && !x.IsDeleted).ToListAsync(); // This method should return all records.

        return entities.Select(entity => new ClientBillToDataModel
        {
            Id = entity.Id,
            Email = entity.Email,
            BillTo = entity.BillTo,
            ClientId = entity.ClientId
        }).ToList();
    }
}