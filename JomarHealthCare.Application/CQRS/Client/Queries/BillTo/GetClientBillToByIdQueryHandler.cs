using MediatR;
using JomarHealthCare.Application.DataModels.Client.BillTo;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.BillTo;


internal class GetClientBillToByIdQueryHandler : IRequestHandler<GetClientBillToByIdQuery, ClientBillToDataModel>
{
    private readonly IClientBillToRepository _repository;

    public GetClientBillToByIdQueryHandler(IClientBillToRepository repository)
    {
        _repository = repository;
    }

    public async Task<ClientBillToDataModel> Handle(GetClientBillToByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.id, cancellationToken);
        if (entity == null)
        {
            throw new KeyNotFoundException("Not found");
        }
        return new ClientBillToDataModel
        {
            Id = entity.Id,
            Email = entity.Email,
            BillTo = entity.Email,
            ClientId = entity.ClientId
        };
    }
}