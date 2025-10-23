using MediatR;
using JomarHealthCare.Application.DataModels.Client;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries;

internal class GetClientDetailByIdQueryHandler : IRequestHandler<GetClientDetailByIdQuery, ClientDetailDataModel>
{
    private readonly IClientRepository _repository;

    public GetClientDetailByIdQueryHandler(IClientRepository repository)
    {
        _repository = repository;
    }

    public async Task<ClientDetailDataModel> Handle(GetClientDetailByIdQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.GetClientDetailById(request.clientId);
        return entities;
    }
}