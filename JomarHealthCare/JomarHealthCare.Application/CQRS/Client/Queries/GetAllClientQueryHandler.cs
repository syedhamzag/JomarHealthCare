using MediatR;
using JomarHealthCare.Application.DataModels.Client;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries;


internal class GetAllClientQueryHandler : IRequestHandler<GetAllClientQuery, List<ClientDataModel>>
{
    private readonly IClientRepository _repository;

    public GetAllClientQueryHandler(IClientRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<ClientDataModel>> Handle(GetAllClientQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.GetAll();
        return entities;
    }
}