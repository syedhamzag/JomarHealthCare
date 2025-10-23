using MediatR;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries;

internal class GetClientForUpdateByIdQueryHandler : IRequestHandler<GetClientForUpdateByIdQuery, JomarHealthCare.Domain.Entities.Client>
{
    private readonly IClientRepository _repository;

    public GetClientForUpdateByIdQueryHandler(IClientRepository repository)
    {
        _repository = repository;
    }

    public async Task<JomarHealthCare.Domain.Entities.Client> Handle(GetClientForUpdateByIdQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.GetByKeyAsync(request.clientId, cancellationToken);
        return entities;
    }
}