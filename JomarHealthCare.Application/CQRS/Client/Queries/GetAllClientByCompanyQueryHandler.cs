using MediatR;
using JomarHealthCare.Application.DataModels.Client;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries;


internal class GetAllClientByCompanyQueryHandler : IRequestHandler<GetAllClientCompanyIdQuery, List<ClientDataModel>>
{
    private readonly IClientRepository _repository;

    public GetAllClientByCompanyQueryHandler(IClientRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<ClientDataModel>> Handle(GetAllClientCompanyIdQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.GetAllByCompanyId(request.companyId);

        return entities;
    }
}