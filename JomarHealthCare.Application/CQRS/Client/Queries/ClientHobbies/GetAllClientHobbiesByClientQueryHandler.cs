using MediatR;
using JomarHealthCare.Application.DataModels.Client.ClientHobbies;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.ClientHobbies;

internal class GetAllClientHobbiesByClientQueryHandler : IRequestHandler<GetClientHobbiesByClientIdQuery, List<ClientHobbiesDataModel>>
{
    private readonly IClientHobbiesRepository _repository;

    public GetAllClientHobbiesByClientQueryHandler(IClientHobbiesRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<ClientHobbiesDataModel>> Handle(GetClientHobbiesByClientIdQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetAllByClientId(request.clientId);
    }
}